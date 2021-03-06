﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Leveleditor;
using System.IO;
using System.Diagnostics;

namespace AdvancedWars
{
    public partial class Titelmenu : Form
    {
        public Titelmenu()
        {
            InitializeComponent();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            GameEdit Edit = new GameEdit();
            this.Hide();
            if(Edit.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btn_Leveleditor_Click(object sender, EventArgs e)
        {
            Leveleditor.Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Titelmenu_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Process.Start("help.txt");
        }
    }
}
