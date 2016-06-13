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
        GameManager mGameManager;

        public Game(Bitmap GameBoard, Field[,] fields, String pRedName, String pBlueName)
        {
            InitializeComponent();
            mGameManager = new GameManager(GameBoard, fields, pRedName, pBlueName);            
            initializeGameUI();
            mGameManager.ActivePlayerChanged += new ActivePlayerChangedHandler(onActivePlayerChanged);
        }

        private void onActivePlayerChanged()
        {
            setActivePlayerUI();
        }

        private void initializeGameUI()
        {
            pic_GameField.Image = mGameManager.GameBoard;
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
        }

    }
}
