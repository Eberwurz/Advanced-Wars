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
        private Field[,] mFields;
        private Player mPlayerRed;
        private Player mPlayerBlue;
        private Bitmap mGameBoard;
        private Player mActivePlayer;
        private int mActivePhase;

        public Game(Bitmap GameBoard, Field[,] fields, String pRedName, String pBlueName)
        {
            InitializeComponent();
            mFields = fields;
            mGameBoard = GameBoard;
            mPlayerRed = new Player(pRedName, Color.Red);
            mPlayerBlue = new Player(pBlueName, Color.Blue);           
            initializeGame();           
        }

        //Nanem und Gold setzen, Aktiver Spieler bestimmen, Bilder setzen.
        private void initializeGame()
        {
            pic_GameField.Image = mGameBoard;
            lbl_player1name.Text = mPlayerRed.Name;
            lbl_player2name.Text = mPlayerBlue.Name;
            lbl_player1gold.Text = mPlayerRed.Gold.ToString();
            lbl_player2gold.Text = mPlayerBlue.Gold.ToString();
            lbl_StandartPrize.Text = GameConstants.SHIP_COST.ToString();
            lbl_DefenderPrice.Text = (GameConstants.SHIP_COST + GameConstants.DEFENSE_COSTMOD).ToString();
            lbl_TransPrice.Text = (GameConstants.SHIP_COST + GameConstants.TRANSPORTER_COSTMOD).ToString();
            lbl_BigPrize.Text = (GameConstants.SHIP_COST + GameConstants.BIGSHIP_COSTMOD).ToString();
            setActivePlayer(mPlayerRed);
            setPhase(GameConstants.PHASE_SET);
        }

        private void setPhase(int phase)
        {
            mActivePhase = phase;
            switch(phase)
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

        private void setActivePlayer(Player player)
        {
            mActivePlayer = player;
            if (player == mPlayerRed)
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
            lbl_aktiverSpieler.Text = player.Name; 
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            mActivePhase++;
            mActivePhase %= 3;
        }

    }
}
