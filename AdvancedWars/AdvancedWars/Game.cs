using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvancedWars
{
    public partial class Game : Form
    {
        private GameManager mGameManager;
        private PictureBox[] imgShips;
        private bool mClearDraw;
        private Ship mActivatedShip;
        private bool mShowRadius = false;
        private bool mShowMovement = false;
        private Point mClickedPoint = new Point(-1,-1);

        //Konstruktor
        public Game(Bitmap GameBoard, Field[,] fields, String pRedName, String pBlueName)
        {
            InitializeComponent();
            mGameManager = new GameManager(GameBoard, fields, pRedName, pBlueName);            
            initializeGameUI();
            mGameManager.ActivePlayerChanged += new GameManagerChangedHandler(onActivePlayerChanged);
            mGameManager.GameOver += new GameManagerChangedHandler(onGameOver);
            imgShips = new PictureBox[] {pic_defense,pic_big, pic_normal, pic_transport };
            mClearDraw = false;
            mActivatedShip = null;
        }

        private void onGameOver()
        {
            // Tu was wenn GameOver.
            log(Color.Green, String.Format("{0} hat gewonnen", mGameManager.ActivePlayer.Name));
            pic_GameField.Enabled = false;
        }

        //Event, dass vom GameManager geworfen wird, wenn der aktuelle Spieler wechselt.
        private void onActivePlayerChanged()
        {
            setActivePlayerUI();
        }

        //Initialisiert das User Interface
        private void initializeGameUI()
        {
            lbl_player1name.Text = mGameManager.PlayerRed.Name;
            lbl_player2name.Text = mGameManager.PlayerBlue.Name;
            updateUI();
            lbl_StandartPrize.Text = GameConstants.SHIP_COST.ToString();
            lbl_DefenderPrice.Text = (GameConstants.SHIP_COST + GameConstants.DEFENSE_COSTMOD).ToString();
            lbl_TransPrice.Text = (GameConstants.SHIP_COST + GameConstants.TRANSPORTER_COSTMOD).ToString();
            lbl_BigPrize.Text = (GameConstants.SHIP_COST + GameConstants.BIGSHIP_COSTMOD).ToString();
            setActivePlayerUI();
            setActivePhaseUI();
            pic_GameField.Refresh();
        }

        //Updated das Spielbrett und die Goldanzeige.
        private void updateUI()
        {
            pic_GameField.BackgroundImage = mGameManager.GameBoard;
            lbl_player1gold.Text = mGameManager.PlayerRed.Gold.ToString();
            lbl_player2gold.Text = mGameManager.PlayerBlue.Gold.ToString();
            lblBluePlayerHealth.Text = mGameManager.PlayerBlue.Health.ToString();
            lblRedPlayerHealth.Text = mGameManager.PlayerRed.Health.ToString();
            pic_GameField.Refresh();
        }

        //Aktualisiert das User Interface für die aktuelle Phase,
        private void setActivePhaseUI()
        {
            int phase = mGameManager.ActivePhase;
            switch (phase)
            {
                case GameConstants.PHASE_SET:
                    enableShipIcons(true);
                    lbl_Spielphase.Text = "Bauphase";
                    break;
                case GameConstants.PHASE_MOVE:
                    enableShipIcons(false);
                    lbl_Spielphase.Text = "Bewegungsphase";
                    break;
                case GameConstants.PHASE_FIGHT:
                    lbl_Spielphase.Text = "Kampfphase";
                    break;
            }
        }

        /// <summary>
        /// Enabled/Disabled ShipIcons.
        /// </summary>
        /// <param name="enable">Gibt an ob die Icons enabled werden sollen.</param>
        private void enableShipIcons(bool enable)
        {
            pic_normal.Enabled = enable;
            pic_big.Enabled = enable;
            pic_defense.Enabled = enable;
            pic_transport.Enabled = enable;
        }

        //Aktualisiert das User Interface für den aktuellen Spieler
        private void setActivePlayerUI()
        {
            Player activePlayer = mGameManager.ActivePlayer;
            if (activePlayer.Color == Color.Red)
            {
                pic_normal.Image = Images.Instance.GetImage(Images.TYPE_STANDART_RED_100);
                pic_big.Image = Images.Instance.GetImage(Images.TYPE_BIGSHIP_RED_100);
                pic_defense.Image = Images.Instance.GetImage(Images.TYPE_DEFENSESHIP_RED_100);
                pic_transport.Image = Images.Instance.GetImage(Images.TYPE_TRANSPORTER_RED_100);
            }
            else
            {
                pic_normal.Image = Images.Instance.GetImage(Images.TYPE_STANDART_BLUE_100);
                pic_big.Image = Images.Instance.GetImage(Images.TYPE_BIGSHIP_BLUE_100);
                pic_defense.Image = Images.Instance.GetImage(Images.TYPE_DEFENSESHIP_BLUE_100);
                pic_transport.Image = Images.Instance.GetImage(Images.TYPE_TRANSPORTER_BLUE_100);
            }
            lbl_aktiverSpieler.Text = activePlayer.Name; 
        }

        //Programm beenden
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Phasenwechsel
        private void btn_next_Click(object sender, EventArgs e)
        {
            mShowMovement = false;
            mShowRadius = false;           
            mGameManager.nextPhase();
            setActivePhaseUI();
            updateUI();
        }

        //Bei Klick auf ein Schiff wird das aktivierte Schiff gesetzt
        private void onShipClick(object sender, EventArgs e)
        {
            PictureBox selected = sender as PictureBox;
            if (selected != null)
            {
                setSelectedShipBorder(selected);
                switch(selected.Name)
                {
                    case "pic_normal":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_STANDART), mGameManager.ActivePlayer);
                        break;
                    case "pic_big":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_BIGSHIP), mGameManager.ActivePlayer);
                        break;
                    case "pic_defense":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_DEFENSESHIP), mGameManager.ActivePlayer);
                        break;
                    case "pic_transport":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_TRANSPORTER), mGameManager.ActivePlayer);
                        break;
                    default:
                        mActivatedShip = null;
                        break;
                }              
            }
        }

        //Aktualisiert den Border des ausgewählten Schiffes.
        private void setSelectedShipBorder(PictureBox selected)
        {
            foreach (PictureBox pic in imgShips)
            {
                if (pic == selected)
                {
                    pic.BackColor = Color.Red;
                }else
                {
                    pic.BackColor = Color.Black;
                }
            }
        }

        //Paint Event für das Spielbrettpanel
        private void pic_GameField_Paint(object sender, PaintEventArgs e)
        {
            if(!mClearDraw)
            {
                Graphics g = pic_GameField.CreateGraphics();
                if (mGameManager.ActivePhase == GameConstants.PHASE_SET)
                {
                    setGraphicalArea(g, mGameManager.ActivePlaySpawnAreaPoints);
                }
                if (mGameManager.ActivePhase == GameConstants.PHASE_MOVE)
                {
                    //Zeichne beim Move
                    if (mShowMovement)
                    {
                        //Zeichne Bewegungskreuz TODO
                        if (mGameManager.ActivePlayersShipClicked(mClickedPoint))
                            setGraphicalArea(g, mGameManager.ShipMovementAreaPoints);
                        else
                            log(Color.Red, "Kein gültiges Schiff gewählt!");
                    }
                }
                if (mGameManager.ActivePhase == GameConstants.PHASE_FIGHT)
                {
                    //Zeichne beim Fight
                    if (mShowRadius)
                    {
                        if (mGameManager.ActivePlayersShipClicked(mClickedPoint))
                            setGraphicalArea(g, mGameManager.ShipCombatAreaPoints);
                        else
                            log(Color.Red, "Kein gültiges Schiff gewählt!");
                    }
                }
                g.Dispose();
            }
        }

        //Makiert Bereiche, in denen Figueren gesetzt werden können.
        private void setGraphicalArea(Graphics g, Point[] points)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(100, mGameManager.ActivePlayer.Color));
            foreach(Point p in points)
            {
                Rectangle rec = new Rectangle(p.X * GameConstants.GAMEFIELD_TILESIZE, 
                    p.Y * GameConstants.GAMEFIELD_TILESIZE, GameConstants.GAMEFIELD_TILESIZE, GameConstants.GAMEFIELD_TILESIZE);
                g.FillRectangle(brush, rec);
            }          
        }

        //Führt Aktion aus, wenn auf das Spielfeld geklickt wird.
        private void pic_GameField_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            int x = me.X / GameConstants.GAMEFIELD_TILESIZE;
            int y = me.Y / GameConstants.GAMEFIELD_TILESIZE;
            mClickedPoint.X = x;
            mClickedPoint.Y = y;
            switch (mGameManager.ActivePhase)
            {
                case GameConstants.PHASE_SET:
                    if (mActivatedShip != null)
                    {
                       lbl_Log.Text = "";
                       if (!mGameManager.TrySetShip(mActivatedShip,x,y))
                       {
                            log(Color.Red, "Schiff konnte nicht gesetzt werden");
                        }
                        else { log(Color.Green, "Schiff wurde gesetzt."); }
                    }
                    break;
                case GameConstants.PHASE_MOVE:
                    if (mShowMovement)
                    {
                        if (mGameManager.TryMoveShip(new Point(x, y)))
                        {
                            mShowMovement = false;
                        }
                    }
                    else
                    {                      
                        mShowMovement = true;
                    }                        
                    break;
                case GameConstants.PHASE_FIGHT:
                    if (mShowRadius)
                    {
                        if(mGameManager.TryAttackShip(new Point(x,y)))
                        {
                            mShowRadius = false;
                        }                  
                    }    
                    else
                    {
                        mShowRadius = true;
                    }
                    break;
            }
            updateUI();
        }

        private void log(Color color, string message)
        {
            lbl_Log.ForeColor = color;
            lbl_Log.Text = message;
        }

    }
}
