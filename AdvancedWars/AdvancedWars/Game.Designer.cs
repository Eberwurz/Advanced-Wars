namespace AdvancedWars
{
    partial class Game
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_player1name = new System.Windows.Forms.Label();
            this.lbl_player1gold = new System.Windows.Forms.Label();
            this.lbl_player2name = new System.Windows.Forms.Label();
            this.lbl_player2gold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_aktiverSpieler = new System.Windows.Forms.Label();
            this.lbl_aktiv = new System.Windows.Forms.Label();
            this.lbl_Spielphase = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.pic_normal = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.pic_fast = new System.Windows.Forms.PictureBox();
            this.pic_defense = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_defense)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_player1name
            // 
            this.lbl_player1name.AutoSize = true;
            this.lbl_player1name.Location = new System.Drawing.Point(818, 32);
            this.lbl_player1name.Name = "lbl_player1name";
            this.lbl_player1name.Size = new System.Drawing.Size(45, 13);
            this.lbl_player1name.TabIndex = 5;
            this.lbl_player1name.Text = "Spieler1";
            // 
            // lbl_player1gold
            // 
            this.lbl_player1gold.AutoSize = true;
            this.lbl_player1gold.Location = new System.Drawing.Point(864, 71);
            this.lbl_player1gold.Name = "lbl_player1gold";
            this.lbl_player1gold.Size = new System.Drawing.Size(29, 13);
            this.lbl_player1gold.TabIndex = 6;
            this.lbl_player1gold.Text = "Gold";
            // 
            // lbl_player2name
            // 
            this.lbl_player2name.AutoSize = true;
            this.lbl_player2name.Location = new System.Drawing.Point(818, 268);
            this.lbl_player2name.Name = "lbl_player2name";
            this.lbl_player2name.Size = new System.Drawing.Size(45, 13);
            this.lbl_player2name.TabIndex = 7;
            this.lbl_player2name.Text = "Spieler2";
            // 
            // lbl_player2gold
            // 
            this.lbl_player2gold.AutoSize = true;
            this.lbl_player2gold.Location = new System.Drawing.Point(864, 310);
            this.lbl_player2gold.Name = "lbl_player2gold";
            this.lbl_player2gold.Size = new System.Drawing.Size(29, 13);
            this.lbl_player2gold.TabIndex = 8;
            this.lbl_player2gold.Text = "Gold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gold:";
            // 
            // lbl_aktiverSpieler
            // 
            this.lbl_aktiverSpieler.AutoSize = true;
            this.lbl_aktiverSpieler.Location = new System.Drawing.Point(263, 523);
            this.lbl_aktiverSpieler.Name = "lbl_aktiverSpieler";
            this.lbl_aktiverSpieler.Size = new System.Drawing.Size(86, 13);
            this.lbl_aktiverSpieler.TabIndex = 11;
            this.lbl_aktiverSpieler.Text = "<aktiver Spieler>";
            // 
            // lbl_aktiv
            // 
            this.lbl_aktiv.AutoSize = true;
            this.lbl_aktiv.Location = new System.Drawing.Point(355, 523);
            this.lbl_aktiv.Name = "lbl_aktiv";
            this.lbl_aktiv.Size = new System.Drawing.Size(30, 13);
            this.lbl_aktiv.TabIndex = 12;
            this.lbl_aktiv.Text = "aktiv";
            this.lbl_aktiv.Click += new System.EventHandler(this.lbl_aktiv_Click);
            // 
            // lbl_Spielphase
            // 
            this.lbl_Spielphase.AutoSize = true;
            this.lbl_Spielphase.Location = new System.Drawing.Point(639, 523);
            this.lbl_Spielphase.Name = "lbl_Spielphase";
            this.lbl_Spielphase.Size = new System.Drawing.Size(99, 13);
            this.lbl_Spielphase.TabIndex = 13;
            this.lbl_Spielphase.Text = "aktuelle Spielphase";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(773, 559);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(111, 25);
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = "Nächste Phase";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // pic_normal
            // 
            this.pic_normal.BackColor = System.Drawing.Color.Black;
            this.pic_normal.Image = ((System.Drawing.Image)(resources.GetObject("pic_normal.Image")));
            this.pic_normal.Location = new System.Drawing.Point(35, 12);
            this.pic_normal.Name = "pic_normal";
            this.pic_normal.Padding = new System.Windows.Forms.Padding(2);
            this.pic_normal.Size = new System.Drawing.Size(104, 104);
            this.pic_normal.TabIndex = 1;
            this.pic_normal.TabStop = false;
            // 
            // pic_big
            // 
            this.pic_big.BackColor = System.Drawing.Color.Black;
            this.pic_big.Image = ((System.Drawing.Image)(resources.GetObject("pic_big.Image")));
            this.pic_big.Location = new System.Drawing.Point(35, 128);
            this.pic_big.Name = "pic_big";
            this.pic_big.Padding = new System.Windows.Forms.Padding(2);
            this.pic_big.Size = new System.Drawing.Size(104, 104);
            this.pic_big.TabIndex = 2;
            this.pic_big.TabStop = false;
            // 
            // pic_fast
            // 
            this.pic_fast.BackColor = System.Drawing.Color.Black;
            this.pic_fast.Image = ((System.Drawing.Image)(resources.GetObject("pic_fast.Image")));
            this.pic_fast.Location = new System.Drawing.Point(35, 243);
            this.pic_fast.Name = "pic_fast";
            this.pic_fast.Padding = new System.Windows.Forms.Padding(2);
            this.pic_fast.Size = new System.Drawing.Size(104, 104);
            this.pic_fast.TabIndex = 3;
            this.pic_fast.TabStop = false;
            // 
            // pic_defense
            // 
            this.pic_defense.BackColor = System.Drawing.Color.Black;
            this.pic_defense.Image = ((System.Drawing.Image)(resources.GetObject("pic_defense.Image")));
            this.pic_defense.Location = new System.Drawing.Point(35, 358);
            this.pic_defense.Name = "pic_defense";
            this.pic_defense.Padding = new System.Windows.Forms.Padding(2);
            this.pic_defense.Size = new System.Drawing.Size(104, 104);
            this.pic_defense.TabIndex = 4;
            this.pic_defense.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_Spielphase);
            this.Controls.Add(this.lbl_aktiv);
            this.Controls.Add(this.lbl_aktiverSpieler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_player2gold);
            this.Controls.Add(this.lbl_player2name);
            this.Controls.Add(this.lbl_player1gold);
            this.Controls.Add(this.lbl_player1name);
            this.Controls.Add(this.pic_defense);
            this.Controls.Add(this.pic_fast);
            this.Controls.Add(this.pic_big);
            this.Controls.Add(this.pic_normal);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Game";
            this.Text = "Advanced Wars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_defense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_player1name;
        private System.Windows.Forms.Label lbl_player1gold;
        private System.Windows.Forms.Label lbl_player2name;
        private System.Windows.Forms.Label lbl_player2gold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_aktiverSpieler;
        private System.Windows.Forms.Label lbl_aktiv;
        private System.Windows.Forms.Label lbl_Spielphase;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pic_normal;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.PictureBox pic_fast;
        private System.Windows.Forms.PictureBox pic_defense;
    }
}