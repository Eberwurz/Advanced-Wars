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
        private string mPath = "";
       // private Field[,] mFields;

        public Game()
        {
            InitializeComponent();
        }

        public Game(string path) //Field[,] fields)
        {
            InitializeComponent();
            mPath =path;
           // mFields = fields;
        }

        private void lbl_aktiv_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
