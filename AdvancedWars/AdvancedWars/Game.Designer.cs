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
            this.lbl_player1name = new System.Windows.Forms.Label();
            this.lbl_player1gold = new System.Windows.Forms.Label();
            this.lbl_player2name = new System.Windows.Forms.Label();
            this.lbl_player2gold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_aktiverSpieler = new System.Windows.Forms.Label();
            this.lbl_aktiv = new System.Windows.Forms.Label();
            this.lbl_Spielphase = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.pic_normal = new System.Windows.Forms.PictureBox();
            this.pic_defense = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.pic_transport = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_TransPrice = new System.Windows.Forms.Label();
            this.lbl_StandartPrize = new System.Windows.Forms.Label();
            this.lbl_BigPrize = new System.Windows.Forms.Label();
            this.lbl_DefenderPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pic_GameField = new System.Windows.Forms.Panel();
            this.lbl_Log = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_defense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_transport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_player1name
            // 
            this.lbl_player1name.Location = new System.Drawing.Point(67, 47);
            this.lbl_player1name.Name = "lbl_player1name";
            this.lbl_player1name.Size = new System.Drawing.Size(154, 13);
            this.lbl_player1name.TabIndex = 5;
            this.lbl_player1name.Text = "<Spieler1Name>";
            // 
            // lbl_player1gold
            // 
            this.lbl_player1gold.Location = new System.Drawing.Point(67, 95);
            this.lbl_player1gold.Name = "lbl_player1gold";
            this.lbl_player1gold.Size = new System.Drawing.Size(154, 14);
            this.lbl_player1gold.TabIndex = 6;
            this.lbl_player1gold.Text = "<Gold>";
            // 
            // lbl_player2name
            // 
            this.lbl_player2name.Location = new System.Drawing.Point(69, 47);
            this.lbl_player2name.Name = "lbl_player2name";
            this.lbl_player2name.Size = new System.Drawing.Size(144, 13);
            this.lbl_player2name.TabIndex = 7;
            this.lbl_player2name.Text = "<Spieler2Name>";
            // 
            // lbl_player2gold
            // 
            this.lbl_player2gold.Location = new System.Drawing.Point(69, 95);
            this.lbl_player2gold.Name = "lbl_player2gold";
            this.lbl_player2gold.Size = new System.Drawing.Size(144, 14);
            this.lbl_player2gold.TabIndex = 8;
            this.lbl_player2gold.Text = "<Gold>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gold:";
            // 
            // lbl_aktiverSpieler
            // 
            this.lbl_aktiverSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aktiverSpieler.Location = new System.Drawing.Point(3, 2);
            this.lbl_aktiverSpieler.Name = "lbl_aktiverSpieler";
            this.lbl_aktiverSpieler.Size = new System.Drawing.Size(468, 77);
            this.lbl_aktiverSpieler.TabIndex = 11;
            this.lbl_aktiverSpieler.Text = "<aktiver Spieler>";
            this.lbl_aktiverSpieler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_aktiv
            // 
            this.lbl_aktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aktiv.Location = new System.Drawing.Point(465, 0);
            this.lbl_aktiv.Name = "lbl_aktiv";
            this.lbl_aktiv.Size = new System.Drawing.Size(106, 79);
            this.lbl_aktiv.TabIndex = 12;
            this.lbl_aktiv.Text = "am Zug";
            this.lbl_aktiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Spielphase
            // 
            this.lbl_Spielphase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Spielphase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spielphase.Location = new System.Drawing.Point(612, 600);
            this.lbl_Spielphase.Name = "lbl_Spielphase";
            this.lbl_Spielphase.Size = new System.Drawing.Size(288, 81);
            this.lbl_Spielphase.TabIndex = 13;
            this.lbl_Spielphase.Text = "<aktuelle Spielphase>";
            this.lbl_Spielphase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(956, 600);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(148, 81);
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = "Nächste Phase";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pic_normal
            // 
            this.pic_normal.BackColor = System.Drawing.Color.Black;
            this.pic_normal.Image = ((System.Drawing.Image)(resources.GetObject("pic_normal.Image")));
            this.pic_normal.Location = new System.Drawing.Point(30, 192);
            this.pic_normal.Name = "pic_normal";
            this.pic_normal.Padding = new System.Windows.Forms.Padding(2);
            this.pic_normal.Size = new System.Drawing.Size(104, 104);
            this.pic_normal.TabIndex = 1;
            this.pic_normal.TabStop = false;
            this.pic_normal.Click += new System.EventHandler(this.onShipClick);
            // 
            // pic_defense
            // 
            this.pic_defense.BackColor = System.Drawing.Color.Black;
            this.pic_defense.Image = ((System.Drawing.Image)(resources.GetObject("pic_defense.Image")));
            this.pic_defense.Location = new System.Drawing.Point(30, 318);
            this.pic_defense.Name = "pic_defense";
            this.pic_defense.Padding = new System.Windows.Forms.Padding(2);
            this.pic_defense.Size = new System.Drawing.Size(104, 104);
            this.pic_defense.TabIndex = 2;
            this.pic_defense.TabStop = false;
            this.pic_defense.Click += new System.EventHandler(this.onShipClick);
            // 
            // pic_big
            // 
            this.pic_big.BackColor = System.Drawing.Color.Black;
            this.pic_big.Image = ((System.Drawing.Image)(resources.GetObject("pic_big.Image")));
            this.pic_big.Location = new System.Drawing.Point(30, 443);
            this.pic_big.Name = "pic_big";
            this.pic_big.Padding = new System.Windows.Forms.Padding(2);
            this.pic_big.Size = new System.Drawing.Size(104, 104);
            this.pic_big.TabIndex = 3;
            this.pic_big.TabStop = false;
            this.pic_big.Click += new System.EventHandler(this.onShipClick);
            // 
            // pic_transport
            // 
            this.pic_transport.BackColor = System.Drawing.Color.Black;
            this.pic_transport.Image = ((System.Drawing.Image)(resources.GetObject("pic_transport.Image")));
            this.pic_transport.Location = new System.Drawing.Point(30, 66);
            this.pic_transport.Name = "pic_transport";
            this.pic_transport.Padding = new System.Windows.Forms.Padding(2);
            this.pic_transport.Size = new System.Drawing.Size(104, 104);
            this.pic_transport.TabIndex = 4;
            this.pic_transport.TabStop = false;
            this.pic_transport.Click += new System.EventHandler(this.onShipClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Spieler Rot:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Transporter";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(31, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Standart";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Galeere";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(31, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Verteidiger";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Einheiten";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(181, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kosten";
            // 
            // lbl_TransPrice
            // 
            this.lbl_TransPrice.AutoSize = true;
            this.lbl_TransPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransPrice.Location = new System.Drawing.Point(168, 101);
            this.lbl_TransPrice.Name = "lbl_TransPrice";
            this.lbl_TransPrice.Size = new System.Drawing.Size(111, 25);
            this.lbl_TransPrice.TabIndex = 23;
            this.lbl_TransPrice.Text = "<Kosten>";
            // 
            // lbl_StandartPrize
            // 
            this.lbl_StandartPrize.AutoSize = true;
            this.lbl_StandartPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StandartPrize.Location = new System.Drawing.Point(168, 232);
            this.lbl_StandartPrize.Name = "lbl_StandartPrize";
            this.lbl_StandartPrize.Size = new System.Drawing.Size(111, 25);
            this.lbl_StandartPrize.TabIndex = 24;
            this.lbl_StandartPrize.Text = "<Kosten>";
            // 
            // lbl_BigPrize
            // 
            this.lbl_BigPrize.AutoSize = true;
            this.lbl_BigPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BigPrize.Location = new System.Drawing.Point(168, 476);
            this.lbl_BigPrize.Name = "lbl_BigPrize";
            this.lbl_BigPrize.Size = new System.Drawing.Size(111, 25);
            this.lbl_BigPrize.TabIndex = 25;
            this.lbl_BigPrize.Text = "<Kosten>";
            // 
            // lbl_DefenderPrice
            // 
            this.lbl_DefenderPrice.AutoSize = true;
            this.lbl_DefenderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefenderPrice.Location = new System.Drawing.Point(168, 360);
            this.lbl_DefenderPrice.Name = "lbl_DefenderPrice";
            this.lbl_DefenderPrice.Size = new System.Drawing.Size(111, 25);
            this.lbl_DefenderPrice.TabIndex = 26;
            this.lbl_DefenderPrice.Text = "<Kosten>";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_aktiverSpieler);
            this.panel1.Controls.Add(this.lbl_aktiv);
            this.panel1.Location = new System.Drawing.Point(30, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 81);
            this.panel1.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(920, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Spielerinformationen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbl_player1name);
            this.panel2.Controls.Add(this.lbl_player1gold);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(925, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 133);
            this.panel2.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.lbl_player2name);
            this.panel4.Controls.Add(this.lbl_player2gold);
            this.panel4.Location = new System.Drawing.Point(925, 339);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 133);
            this.panel4.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 24);
            this.label18.TabIndex = 16;
            this.label18.Text = "Spieler Blau:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(4, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 18);
            this.label19.TabIndex = 29;
            this.label19.Text = "Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(4, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 18);
            this.label22.TabIndex = 9;
            this.label22.Text = "Gold:";
            // 
            // pic_GameField
            // 
            this.pic_GameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_GameField.Location = new System.Drawing.Point(300, 50);
            this.pic_GameField.Name = "pic_GameField";
            this.pic_GameField.Size = new System.Drawing.Size(600, 500);
            this.pic_GameField.TabIndex = 32;
            this.pic_GameField.Click += new System.EventHandler(this.pic_GameField_Click);
            this.pic_GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_GameField_Paint);
            // 
            // lbl_Log
            // 
            this.lbl_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log.Location = new System.Drawing.Point(30, 696);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(870, 48);
            this.lbl_Log.TabIndex = 33;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lbl_BigPrize);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.pic_GameField);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_DefenderPrice);
            this.Controls.Add(this.lbl_StandartPrize);
            this.Controls.Add(this.lbl_TransPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_Spielphase);
            this.Controls.Add(this.pic_transport);
            this.Controls.Add(this.pic_big);
            this.Controls.Add(this.pic_defense);
            this.Controls.Add(this.pic_normal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Game";
            this.Text = "Advanced Wars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_defense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_transport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_player1name;
        private System.Windows.Forms.Label lbl_player1gold;
        private System.Windows.Forms.Label lbl_player2name;
        private System.Windows.Forms.Label lbl_player2gold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_aktiverSpieler;
        private System.Windows.Forms.Label lbl_aktiv;
        private System.Windows.Forms.Label lbl_Spielphase;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pic_normal;
        private System.Windows.Forms.PictureBox pic_defense;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.PictureBox pic_transport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_TransPrice;
        private System.Windows.Forms.Label lbl_StandartPrize;
        private System.Windows.Forms.Label lbl_BigPrize;
        private System.Windows.Forms.Label lbl_DefenderPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel pic_GameField;
        private System.Windows.Forms.Label lbl_Log;
    }
}