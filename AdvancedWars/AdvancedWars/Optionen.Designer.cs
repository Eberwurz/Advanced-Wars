namespace AdvancedWars
{
    partial class GameEdit
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
            this.lbl_Spieler1 = new System.Windows.Forms.Label();
            this.lbl_Spieler2 = new System.Windows.Forms.Label();
            this.lbl_map = new System.Windows.Forms.Label();
            this.tb_Spieler1 = new System.Windows.Forms.TextBox();
            this.tb_Spieler2 = new System.Windows.Forms.TextBox();
            this.btn_SpielStarten = new System.Windows.Forms.Button();
            this.lbl_MapPfad = new System.Windows.Forms.Label();
            this.btn_MapAufrufen = new System.Windows.Forms.Button();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Spieler1
            // 
            this.lbl_Spieler1.AutoSize = true;
            this.lbl_Spieler1.Location = new System.Drawing.Point(13, 24);
            this.lbl_Spieler1.Name = "lbl_Spieler1";
            this.lbl_Spieler1.Size = new System.Drawing.Size(48, 13);
            this.lbl_Spieler1.TabIndex = 0;
            this.lbl_Spieler1.Text = "Spieler1:";
            // 
            // lbl_Spieler2
            // 
            this.lbl_Spieler2.AutoSize = true;
            this.lbl_Spieler2.Location = new System.Drawing.Point(13, 68);
            this.lbl_Spieler2.Name = "lbl_Spieler2";
            this.lbl_Spieler2.Size = new System.Drawing.Size(48, 13);
            this.lbl_Spieler2.TabIndex = 1;
            this.lbl_Spieler2.Text = "Spieler2:";
            // 
            // lbl_map
            // 
            this.lbl_map.AutoSize = true;
            this.lbl_map.Location = new System.Drawing.Point(13, 120);
            this.lbl_map.Name = "lbl_map";
            this.lbl_map.Size = new System.Drawing.Size(31, 13);
            this.lbl_map.TabIndex = 2;
            this.lbl_map.Text = "Map:";
            // 
            // tb_Spieler1
            // 
            this.tb_Spieler1.Location = new System.Drawing.Point(77, 21);
            this.tb_Spieler1.Name = "tb_Spieler1";
            this.tb_Spieler1.Size = new System.Drawing.Size(84, 20);
            this.tb_Spieler1.TabIndex = 3;
            // 
            // tb_Spieler2
            // 
            this.tb_Spieler2.Location = new System.Drawing.Point(77, 68);
            this.tb_Spieler2.Name = "tb_Spieler2";
            this.tb_Spieler2.Size = new System.Drawing.Size(84, 20);
            this.tb_Spieler2.TabIndex = 4;
            // 
            // btn_SpielStarten
            // 
            this.btn_SpielStarten.Location = new System.Drawing.Point(261, 167);
            this.btn_SpielStarten.Name = "btn_SpielStarten";
            this.btn_SpielStarten.Size = new System.Drawing.Size(114, 48);
            this.btn_SpielStarten.TabIndex = 5;
            this.btn_SpielStarten.Text = "Spiel starten!";
            this.btn_SpielStarten.UseVisualStyleBackColor = true;
            this.btn_SpielStarten.Click += new System.EventHandler(this.btn_SpielStarten_Click);
            // 
            // lbl_MapPfad
            // 
            this.lbl_MapPfad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MapPfad.Location = new System.Drawing.Point(76, 115);
            this.lbl_MapPfad.Name = "lbl_MapPfad";
            this.lbl_MapPfad.Size = new System.Drawing.Size(87, 20);
            this.lbl_MapPfad.TabIndex = 6;
            // 
            // btn_MapAufrufen
            // 
            this.btn_MapAufrufen.Location = new System.Drawing.Point(185, 105);
            this.btn_MapAufrufen.Name = "btn_MapAufrufen";
            this.btn_MapAufrufen.Size = new System.Drawing.Size(73, 42);
            this.btn_MapAufrufen.TabIndex = 7;
            this.btn_MapAufrufen.Text = "Map auswählen";
            this.btn_MapAufrufen.UseVisualStyleBackColor = true;
            this.btn_MapAufrufen.Click += new System.EventHandler(this.btn_MapAufrufen_Click);
            // 
            // lbl_Log
            // 
            this.lbl_Log.Location = new System.Drawing.Point(20, 167);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(222, 48);
            this.lbl_Log.TabIndex = 8;
            this.lbl_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.btn_MapAufrufen);
            this.Controls.Add(this.lbl_MapPfad);
            this.Controls.Add(this.btn_SpielStarten);
            this.Controls.Add(this.tb_Spieler2);
            this.Controls.Add(this.tb_Spieler1);
            this.Controls.Add(this.lbl_map);
            this.Controls.Add(this.lbl_Spieler2);
            this.Controls.Add(this.lbl_Spieler1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(403, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "GameEdit";
            this.Text = "Spiel einrichten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Spieler1;
        private System.Windows.Forms.Label lbl_Spieler2;
        private System.Windows.Forms.Label lbl_map;
        private System.Windows.Forms.TextBox tb_Spieler1;
        private System.Windows.Forms.TextBox tb_Spieler2;
        private System.Windows.Forms.Button btn_SpielStarten;
        private System.Windows.Forms.Label lbl_MapPfad;
        private System.Windows.Forms.Button btn_MapAufrufen;
        private System.Windows.Forms.Label lbl_Log;
    }
}

