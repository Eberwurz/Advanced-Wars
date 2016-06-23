using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AdvancedWars
{
    public partial class GameEdit : Form
    {
        private bool mMapLoaded;
        private MapReader mReader;


        public GameEdit()
        {
            InitializeComponent();
            mMapLoaded = false;
        }
        //Versucht aus dem übergebenen Pfad mit Hilfe des MapReaders die Map einzulesen.
        private void btn_MapAufrufen_Click(object sender, EventArgs e)
        {
            lbl_Log.Text = "";
            FolderBrowserDialog ofDialog = new FolderBrowserDialog();
            ofDialog.ShowNewFolderButton = false;
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                string path = ofDialog.SelectedPath;
                mReader = new MapReader(path);
                if(mReader.TryLoadXMLFromPath() && mReader.TryLoadBitmap())
                {
                    lbl_MapPfad.Text = mReader.MapName;
                    mMapLoaded = true;
                }
                else
                {
                    lbl_Log.Text = "Ungültiger Pfad!";
                }
            }
        }
        //Wenn die Map geladen wurde und Spielernamen eingegeben wurden startet er das Spiel.
        private void btn_SpielStarten_Click(object sender, EventArgs e)
        {
            lbl_Log.Text = "";
            bool success = true;            
            if (String.IsNullOrEmpty(tb_Spieler1.Text) || String.IsNullOrEmpty(tb_Spieler2.Text))
            {
                lbl_Log.Text = "Bitte Spielername eingeben!";
                success = false;
            }else if (mMapLoaded == false)
            {
                lbl_Log.Text = "Bitte eine Map auswählen!";
                success = false;
            }
            if (success)
            {
                //lade spiel
                Game game = new Game(mReader.Bitmap,mReader.Fields, tb_Spieler1.Text, tb_Spieler2.Text);
                this.Hide();
                game.ShowDialog();                
            }           
        }

    }
}



