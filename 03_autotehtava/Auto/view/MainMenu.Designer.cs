﻿namespace Autokauppa.view
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSeuraava = new System.Windows.Forms.Button();
            gbAuto = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cbPolttoaine = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cbVari = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cbMalli = new System.Windows.Forms.ComboBox();
            dtpPaiva = new System.Windows.Forms.DateTimePicker();
            tbMittarilukema = new System.Windows.Forms.TextBox();
            tbTilavuus = new System.Windows.Forms.TextBox();
            tbHinta = new System.Windows.Forms.TextBox();
            tbId = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cbMerkki = new System.Windows.Forms.ComboBox();
            btnEdellinen = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            testaaTietokantaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnLisaa = new System.Windows.Forms.Button();
            gbAuto.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSeuraava
            // 
            btnSeuraava.Location = new System.Drawing.Point(111, 291);
            btnSeuraava.Name = "btnSeuraava";
            btnSeuraava.Size = new System.Drawing.Size(78, 31);
            btnSeuraava.TabIndex = 17;
            btnSeuraava.Text = "Seuraava";
            btnSeuraava.UseVisualStyleBackColor = true;
            btnSeuraava.Click += btnSeuraava_Click;
            // 
            // gbAuto
            // 
            gbAuto.Controls.Add(label9);
            gbAuto.Controls.Add(label8);
            gbAuto.Controls.Add(label7);
            gbAuto.Controls.Add(label6);
            gbAuto.Controls.Add(label5);
            gbAuto.Controls.Add(label4);
            gbAuto.Controls.Add(cbPolttoaine);
            gbAuto.Controls.Add(label3);
            gbAuto.Controls.Add(cbVari);
            gbAuto.Controls.Add(label2);
            gbAuto.Controls.Add(cbMalli);
            gbAuto.Controls.Add(dtpPaiva);
            gbAuto.Controls.Add(tbMittarilukema);
            gbAuto.Controls.Add(tbTilavuus);
            gbAuto.Controls.Add(tbHinta);
            gbAuto.Controls.Add(tbId);
            gbAuto.Controls.Add(label1);
            gbAuto.Controls.Add(cbMerkki);
            gbAuto.Location = new System.Drawing.Point(10, 34);
            gbAuto.Name = "gbAuto";
            gbAuto.Size = new System.Drawing.Size(550, 251);
            gbAuto.TabIndex = 18;
            gbAuto.TabStop = false;
            gbAuto.Text = "Auton tiedot";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(385, 121);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(18, 15);
            label9.TabIndex = 34;
            label9.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(270, 121);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 15);
            label8.TabIndex = 33;
            label8.Text = "RekisteriPVM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(158, 121);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 15);
            label7.TabIndex = 32;
            label7.Text = "Mittarilukema";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(381, 74);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 15);
            label6.TabIndex = 31;
            label6.Text = "Tilavuus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(270, 74);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 15);
            label5.TabIndex = 30;
            label5.Text = "Hinta";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(158, 74);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 15);
            label4.TabIndex = 29;
            label4.Text = "Polttoaine";
            // 
            // cbPolttoaine
            // 
            cbPolttoaine.FormattingEnabled = true;
            cbPolttoaine.Location = new System.Drawing.Point(158, 95);
            cbPolttoaine.Name = "cbPolttoaine";
            cbPolttoaine.Size = new System.Drawing.Size(106, 23);
            cbPolttoaine.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(381, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(26, 15);
            label3.TabIndex = 27;
            label3.Text = "Väri";
            // 
            // cbVari
            // 
            cbVari.FormattingEnabled = true;
            cbVari.Location = new System.Drawing.Point(381, 49);
            cbVari.Name = "cbVari";
            cbVari.Size = new System.Drawing.Size(106, 23);
            cbVari.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(270, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 15);
            label2.TabIndex = 25;
            label2.Text = "Malli";
            // 
            // cbMalli
            // 
            cbMalli.FormattingEnabled = true;
            cbMalli.Location = new System.Drawing.Point(270, 49);
            cbMalli.Name = "cbMalli";
            cbMalli.Size = new System.Drawing.Size(106, 23);
            cbMalli.TabIndex = 24;
            // 
            // dtpPaiva
            // 
            dtpPaiva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpPaiva.Location = new System.Drawing.Point(274, 139);
            dtpPaiva.Name = "dtpPaiva";
            dtpPaiva.Size = new System.Drawing.Size(102, 23);
            dtpPaiva.TabIndex = 23;
            // 
            // tbMittarilukema
            // 
            tbMittarilukema.Location = new System.Drawing.Point(158, 139);
            tbMittarilukema.Name = "tbMittarilukema";
            tbMittarilukema.Size = new System.Drawing.Size(102, 23);
            tbMittarilukema.TabIndex = 22;
            // 
            // tbTilavuus
            // 
            tbTilavuus.Location = new System.Drawing.Point(381, 96);
            tbTilavuus.Name = "tbTilavuus";
            tbTilavuus.Size = new System.Drawing.Size(102, 23);
            tbTilavuus.TabIndex = 21;
            // 
            // tbHinta
            // 
            tbHinta.Location = new System.Drawing.Point(274, 96);
            tbHinta.Name = "tbHinta";
            tbHinta.Size = new System.Drawing.Size(102, 23);
            tbHinta.TabIndex = 20;
            // 
            // tbId
            // 
            tbId.Location = new System.Drawing.Point(385, 139);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new System.Drawing.Size(102, 23);
            tbId.TabIndex = 19;
            tbId.Text = "1";
            tbId.TextChanged += tbId_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(158, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 18;
            label1.Text = "Automerkki";
            // 
            // cbMerkki
            // 
            cbMerkki.FormattingEnabled = true;
            cbMerkki.Location = new System.Drawing.Point(158, 49);
            cbMerkki.Name = "cbMerkki";
            cbMerkki.Size = new System.Drawing.Size(106, 23);
            cbMerkki.TabIndex = 17;
            // 
            // btnEdellinen
            // 
            btnEdellinen.Location = new System.Drawing.Point(10, 291);
            btnEdellinen.Name = "btnEdellinen";
            btnEdellinen.Size = new System.Drawing.Size(81, 31);
            btnEdellinen.TabIndex = 19;
            btnEdellinen.Text = "Edellinen";
            btnEdellinen.UseVisualStyleBackColor = true;
            btnEdellinen.Click += btnEdellinen_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(570, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem1 });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            exitToolStripMenuItem.Text = "Tiedosto";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            exitToolStripMenuItem1.Text = "Poistu";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { testaaTietokantaaToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            aboutToolStripMenuItem.Text = "Muuta...";
            // 
            // testaaTietokantaaToolStripMenuItem
            // 
            testaaTietokantaaToolStripMenuItem.Name = "testaaTietokantaaToolStripMenuItem";
            testaaTietokantaaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            testaaTietokantaaToolStripMenuItem.Text = "Testaa tietokantaa";
            testaaTietokantaaToolStripMenuItem.Click += testaaTietokantaaToolStripMenuItem_Click;
            // 
            // btnLisaa
            // 
            btnLisaa.Location = new System.Drawing.Point(214, 291);
            btnLisaa.Name = "btnLisaa";
            btnLisaa.Size = new System.Drawing.Size(78, 31);
            btnLisaa.TabIndex = 21;
            btnLisaa.Text = "Lisää";
            btnLisaa.UseVisualStyleBackColor = true;
            btnLisaa.Click += btnLisaa_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(570, 350);
            Controls.Add(btnLisaa);
            Controls.Add(btnEdellinen);
            Controls.Add(gbAuto);
            Controls.Add(btnSeuraava);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            gbAuto.ResumeLayout(false);
            gbAuto.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPolttoaine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMalli;
        private System.Windows.Forms.DateTimePicker dtpPaiva;
        private System.Windows.Forms.TextBox tbMittarilukema;
        private System.Windows.Forms.TextBox tbTilavuus;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMerkki;
        private System.Windows.Forms.Button btnEdellinen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantaaToolStripMenuItem;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}