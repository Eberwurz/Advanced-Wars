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

        public Game(Bitmap GameBoard, Field[,] fields, String pRedName, String pBlueName)
        {
            InitializeComponent();
            mGameManager = new GameManager(GameBoard, fields, pRedName, pBlueName);            
            initializeGameUI();
            mGameManager.ActivePlayerChanged += new ActivePlayerChangedHandler(onActivePlayerChanged);
            imgShips = new PictureBox[] {pic_defense,pic_big, pic_normal, pic_transport };
            mClearDraw = false;
            mActivatedShip = null;
        }

        private void onActivePlayerChanged()
        {
            setActivePlayerUI();
        }

        private void initializeGameUI()
        {
            pic_GameField.BackgroundImage = mGameManager.GameBoard;
            lbl_player1name.Text = mGameManager.PlayerRed.Name;
            lbl_player2name.Text = mGameManager.PlayerBlue.Name;
            lbl_player1gold.Text = mGameManager.PlayerRed.Gold.ToString();
            lbl_player2gold.Text = mGameManager.PlayerBlue.Gold.ToString();
            lbl_StandartPrize.Text = GameConstants.SHIP_COST.ToString();
            lbl_DefenderPrice.Text = (GameConstants.SHIP_COST + GameConstants.DEFENSE_COSTMOD).ToString();
            lbl_TransPrice.Text = (GameConstants.SHIP_COST + GameConstants.TRANSPORTER_COSTMOD).ToString();
            lbl_BigPrize.Text = (GameConstants.SHIP_COST + GameConstants.BIGSHIP_COSTMOD).ToString();
            setActivePlayerUI();
            setActivePhaseUI();
            pic_GameField.Refresh();
        }

        private void setActivePhaseUI()
        {
            int phase = mGameManager.ActivePhase;
            switch (phase)
            {
                case GameConstants.PHASE_SET:
                    lbl_Spielphase.Text = "Bauphase";
                    break;
                case GameConstants.PHASE_MOVE:
                    lbl_Spielphase.Text = "Bewegungsphase";
                    break;
                case GameConstants.PHASE_FIGHT:
                    lbl_Spielphase.Text = "Kampfphase";
                    break;
            }
        }

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

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            mGameManager.nextPhase();
            setActivePhaseUI();
            pic_GameField.Refresh();
        }

        private void onShipClick(object sender, EventArgs e)
        {
            PictureBox selected = sender as PictureBox;
            if (selected != null)
            {
                setSelectedShip(selected);
                switch(selected.Name)
                {
                    case "pic_normal":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_STANDART));
                        break;
                    case "pic_big":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_BIGSHIP));
                        break;
                    case "pic_defense":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_DEFENSESHIP));
                        break;
                    case "pic_transport":
                        mActivatedShip = new Ship(new Type(GameConstants.TYPE_TRANSPORTER));
                        break;
                    default:
                        mActivatedShip = null;
                        break;
                }              
            }
        }

        private void setSelectedShip(PictureBox selected)
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

        private void pic_GameField_Paint(object sender, PaintEventArgs e)
        {
            if(!mClearDraw)
            {
                Graphics g = pic_GameField.CreateGraphics();
                if (mGameManager.ActivePhase == GameConstants.PHASE_SET)
                {
                    setBuildingGraphicalArea(g);
                }
                g.Dispose();
            }
        }

        private void setBuildingGraphicalArea(Graphics g)
        {
            Point basePoint = mGameManager.ActivePlayerBase;
            Color color = Color.FromArgb(100,mGameManager.ActivePlayer.Color);
            for (int x= basePoint.X - GameConstants.GAMEFIELD_TILESIZE; x<= basePoint.X + GameConstants.GAMEFIELD_TILESIZE; x= x+ GameConstants.GAMEFIELD_TILESIZE)
            {
                for (int y = basePoint.Y - GameConstants.GAMEFIELD_TILESIZE; y <= basePoint.Y + GameConstants.GAMEFIELD_TILESIZE; y = y + GameConstants.GAMEFIELD_TILESIZE)
                {
                    if (x >= 0 && x < GameConstants.GAMEFIELD_WIDTH - GameConstants.GAMEFIELD_TILESIZE)
                    {
                        if (y >= 0 && y < GameConstants.GAMEFIELD_HEIGHT - GameConstants.GAMEFIELD_TILESIZE)
                        {
                            if (basePoint.X != x || basePoint.Y != y)
                            {
                                SolidBrush brush = new SolidBrush(color);
                                g.FillRectangle(brush, new Rectangle(x, y, GameConstants.GAMEFIELD_TILESIZE, GameConstants.GAMEFIELD_TILESIZE));
                            }                        
                        }
                    }
                }
            }
        }

        private void pic_GameField_Click(object sender, EventArgs e)
        {

        }
    }
}
