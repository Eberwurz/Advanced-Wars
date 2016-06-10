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
    public partial class GameEdit : Form
    {
        private bool mMapLoaded = false;
        private string mPath = "";
        //private Field[,] mFields;


        public GameEdit()
        {
            InitializeComponent();
        }

        private void btn_MapAufrufen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofDialog = new FolderBrowserDialog();
            ofDialog.ShowNewFolderButton = false;
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                mPath = ofDialog.SelectedPath;
                lbl_MapPfad.Text = mPath;
                //mFields setzen
            }
        }

        private void lbl_MapPfad_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_SpielStarten_Click(object sender, EventArgs e)
        {
            bool success = true;
            
            if (tb_Spieler1.Text == "" || tb_Spieler2.Text == "")
            {
                lbl_Log.Text = "Bitte Spielername eingeben!";
                success = false;
            }

           /* if (mMapLoaded == false)
            {
                lbl_Log.Text = "Bitte eine Map auswählen!";
                success = false;
            }*/

            if (success)
            {
                //lade spiel
                Game game = new Game();//mPath, mFields);
                game.Show();
                this.Hide();
            }
            
        }
    }
}



