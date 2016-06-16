namespace AdvancedWars
{
    partial class Titelmenu
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
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Leveleditor = new System.Windows.Forms.Button();
            this.lbl_AdvancedWars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_newGame
            // 
            this.btn_newGame.Location = new System.Drawing.Point(93, 103);
            this.btn_newGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(246, 82);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.Text = "Neues Spiel";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(93, 428);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(246, 91);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Leveleditor
            // 
            this.btn_Leveleditor.Location = new System.Drawing.Point(93, 265);
            this.btn_Leveleditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Leveleditor.Name = "btn_Leveleditor";
            this.btn_Leveleditor.Size = new System.Drawing.Size(246, 82);
            this.btn_Leveleditor.TabIndex = 2;
            this.btn_Leveleditor.Text = "Leveleditor";
            this.btn_Leveleditor.UseVisualStyleBackColor = true;
            this.btn_Leveleditor.Click += new System.EventHandler(this.btn_Leveleditor_Click);
            // 
            // lbl_AdvancedWars
            // 
            this.lbl_AdvancedWars.AutoSize = true;
            this.lbl_AdvancedWars.Location = new System.Drawing.Point(150, 29);
            this.lbl_AdvancedWars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AdvancedWars.Name = "lbl_AdvancedWars";
            this.lbl_AdvancedWars.Size = new System.Drawing.Size(121, 20);
            this.lbl_AdvancedWars.TabIndex = 3;
            this.lbl_AdvancedWars.Text = "Advanced Wars";
            // 
            // Titelmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 578);
            this.Controls.Add(this.lbl_AdvancedWars);
            this.Controls.Add(this.btn_Leveleditor);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_newGame);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 634);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 634);
            this.Name = "Titelmenu";
            this.Text = "Titelmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Leveleditor;
        private System.Windows.Forms.Label lbl_AdvancedWars;
    }
}