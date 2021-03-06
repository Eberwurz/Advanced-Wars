﻿namespace Leveleditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picGameField = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFieldTypes = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.picIslandBlue = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picRiff = new System.Windows.Forms.PictureBox();
            this.picIslandRed = new System.Windows.Forms.PictureBox();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.tabPowerUps = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoost = new System.Windows.Forms.PictureBox();
            this.picNone = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.picSlow = new System.Windows.Forms.PictureBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGameField)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabFieldTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIslandBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIslandRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            this.tabPowerUps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlow)).BeginInit();
            this.SuspendLayout();
            // 
            // picGameField
            // 
            this.picGameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGameField.Image = ((System.Drawing.Image)(resources.GetObject("picGameField.Image")));
            this.picGameField.Location = new System.Drawing.Point(300, 20);
            this.picGameField.Name = "picGameField";
            this.picGameField.Size = new System.Drawing.Size(600, 500);
            this.picGameField.TabIndex = 0;
            this.picGameField.TabStop = false;
            this.picGameField.Click += new System.EventHandler(this.onGameFieldClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFieldTypes);
            this.tabControl1.Controls.Add(this.tabPowerUps);
            this.tabControl1.Location = new System.Drawing.Point(5, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(290, 520);
            this.tabControl1.TabIndex = 1;
            // 
            // tabFieldTypes
            // 
            this.tabFieldTypes.Controls.Add(this.label7);
            this.tabFieldTypes.Controls.Add(this.picIslandBlue);
            this.tabFieldTypes.Controls.Add(this.label3);
            this.tabFieldTypes.Controls.Add(this.Rot);
            this.tabFieldTypes.Controls.Add(this.label1);
            this.tabFieldTypes.Controls.Add(this.picRiff);
            this.tabFieldTypes.Controls.Add(this.picIslandRed);
            this.tabFieldTypes.Controls.Add(this.picWater);
            this.tabFieldTypes.Location = new System.Drawing.Point(4, 22);
            this.tabFieldTypes.Name = "tabFieldTypes";
            this.tabFieldTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabFieldTypes.Size = new System.Drawing.Size(282, 494);
            this.tabFieldTypes.TabIndex = 0;
            this.tabFieldTypes.Text = "Fieldtypes";
            this.tabFieldTypes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Blau";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picIslandBlue
            // 
            this.picIslandBlue.BackColor = System.Drawing.Color.Black;
            this.picIslandBlue.Image = ((System.Drawing.Image)(resources.GetObject("picIslandBlue.Image")));
            this.picIslandBlue.Location = new System.Drawing.Point(158, 193);
            this.picIslandBlue.Name = "picIslandBlue";
            this.picIslandBlue.Padding = new System.Windows.Forms.Padding(2);
            this.picIslandBlue.Size = new System.Drawing.Size(104, 104);
            this.picIslandBlue.TabIndex = 6;
            this.picIslandBlue.TabStop = false;
            this.picIslandBlue.Click += new System.EventHandler(this.onFieldTypeClicked);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Riff";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Rot
            // 
            this.Rot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rot.Location = new System.Drawing.Point(6, 157);
            this.Rot.Name = "Rot";
            this.Rot.Size = new System.Drawing.Size(104, 33);
            this.Rot.TabIndex = 4;
            this.Rot.Text = "Rot";
            this.Rot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wasser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picRiff
            // 
            this.picRiff.BackColor = System.Drawing.Color.Black;
            this.picRiff.Image = ((System.Drawing.Image)(resources.GetObject("picRiff.Image")));
            this.picRiff.Location = new System.Drawing.Point(88, 346);
            this.picRiff.Name = "picRiff";
            this.picRiff.Padding = new System.Windows.Forms.Padding(2);
            this.picRiff.Size = new System.Drawing.Size(104, 104);
            this.picRiff.TabIndex = 2;
            this.picRiff.TabStop = false;
            this.picRiff.Click += new System.EventHandler(this.onFieldTypeClicked);
            // 
            // picIslandRed
            // 
            this.picIslandRed.BackColor = System.Drawing.Color.Black;
            this.picIslandRed.Image = ((System.Drawing.Image)(resources.GetObject("picIslandRed.Image")));
            this.picIslandRed.Location = new System.Drawing.Point(6, 193);
            this.picIslandRed.Name = "picIslandRed";
            this.picIslandRed.Padding = new System.Windows.Forms.Padding(2);
            this.picIslandRed.Size = new System.Drawing.Size(104, 104);
            this.picIslandRed.TabIndex = 1;
            this.picIslandRed.TabStop = false;
            this.picIslandRed.Click += new System.EventHandler(this.onFieldTypeClicked);
            // 
            // picWater
            // 
            this.picWater.BackColor = System.Drawing.Color.Black;
            this.picWater.Image = ((System.Drawing.Image)(resources.GetObject("picWater.Image")));
            this.picWater.Location = new System.Drawing.Point(88, 43);
            this.picWater.Name = "picWater";
            this.picWater.Padding = new System.Windows.Forms.Padding(2);
            this.picWater.Size = new System.Drawing.Size(104, 104);
            this.picWater.TabIndex = 0;
            this.picWater.TabStop = false;
            this.picWater.Click += new System.EventHandler(this.onFieldTypeClicked);
            // 
            // tabPowerUps
            // 
            this.tabPowerUps.Controls.Add(this.label4);
            this.tabPowerUps.Controls.Add(this.label5);
            this.tabPowerUps.Controls.Add(this.picBoost);
            this.tabPowerUps.Controls.Add(this.picNone);
            this.tabPowerUps.Controls.Add(this.lbl);
            this.tabPowerUps.Controls.Add(this.picSlow);
            this.tabPowerUps.Location = new System.Drawing.Point(4, 22);
            this.tabPowerUps.Name = "tabPowerUps";
            this.tabPowerUps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPowerUps.Size = new System.Drawing.Size(282, 494);
            this.tabPowerUps.TabIndex = 1;
            this.tabPowerUps.Text = "PowerUps";
            this.tabPowerUps.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Keins";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Slow";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picBoost
            // 
            this.picBoost.BackColor = System.Drawing.Color.Black;
            this.picBoost.Image = ((System.Drawing.Image)(resources.GetObject("picBoost.Image")));
            this.picBoost.Location = new System.Drawing.Point(88, 342);
            this.picBoost.Name = "picBoost";
            this.picBoost.Padding = new System.Windows.Forms.Padding(2);
            this.picBoost.Size = new System.Drawing.Size(104, 104);
            this.picBoost.TabIndex = 6;
            this.picBoost.TabStop = false;
            this.picBoost.Click += new System.EventHandler(this.onFieldBoostClicked);
            // 
            // picNone
            // 
            this.picNone.BackColor = System.Drawing.Color.Black;
            this.picNone.Image = ((System.Drawing.Image)(resources.GetObject("picNone.Image")));
            this.picNone.Location = new System.Drawing.Point(88, 50);
            this.picNone.Name = "picNone";
            this.picNone.Padding = new System.Windows.Forms.Padding(2);
            this.picNone.Size = new System.Drawing.Size(104, 104);
            this.picNone.TabIndex = 11;
            this.picNone.TabStop = false;
            this.picNone.Click += new System.EventHandler(this.onFieldBoostClicked);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(88, 306);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 33);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Boost";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picSlow
            // 
            this.picSlow.BackColor = System.Drawing.Color.Black;
            this.picSlow.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picSlow.ErrorImage")));
            this.picSlow.Image = ((System.Drawing.Image)(resources.GetObject("picSlow.Image")));
            this.picSlow.Location = new System.Drawing.Point(88, 193);
            this.picSlow.Name = "picSlow";
            this.picSlow.Padding = new System.Windows.Forms.Padding(2);
            this.picSlow.Size = new System.Drawing.Size(104, 104);
            this.picSlow.TabIndex = 7;
            this.picSlow.TabStop = false;
            this.picSlow.Click += new System.EventHandler(this.onFieldBoostClicked);
            // 
            // lblLog
            // 
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.Red;
            this.lblLog.Location = new System.Drawing.Point(5, 556);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(895, 46);
            this.lblLog.TabIndex = 2;
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onSaveButtonClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(514, 530);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Map Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 611);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.picGameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Leveleditor";
            ((System.ComponentModel.ISupportInitialize)(this.picGameField)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabFieldTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIslandBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIslandRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            this.tabPowerUps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGameField;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFieldTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRiff;
        private System.Windows.Forms.PictureBox picIslandRed;
        private System.Windows.Forms.PictureBox picWater;
        private System.Windows.Forms.TabPage tabPowerUps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBoost;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox picSlow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picNone;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picIslandBlue;
    }
}

