﻿
namespace Mediaregister
{
    partial class Mediaregisterform
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bokTab = new System.Windows.Forms.TabPage();
            this.pagesUpDwn = new System.Windows.Forms.NumericUpDown();
            this.bokBtn = new System.Windows.Forms.Button();
            this.sidorLabel = new System.Windows.Forms.Label();
            this.författareLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.bokTitelTextBox = new System.Windows.Forms.TextBox();
            this.bokTitelLabel = new System.Windows.Forms.Label();
            this.filmTab = new System.Windows.Forms.TabPage();
            this.filmBtn = new System.Windows.Forms.Button();
            this.spellängeNumUpDwn = new System.Windows.Forms.NumericUpDown();
            this.spellängdLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.filmTitelTextBox = new System.Windows.Forms.TextBox();
            this.filmTitelLabel = new System.Windows.Forms.Label();
            this.visaRadioGroup = new System.Windows.Forms.GroupBox();
            this.filmRadio = new System.Windows.Forms.RadioButton();
            this.bokRadio = new System.Windows.Forms.RadioButton();
            this.allaRadio = new System.Windows.Forms.RadioButton();
            this.listaTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.bokTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesUpDwn)).BeginInit();
            this.filmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellängeNumUpDwn)).BeginInit();
            this.visaRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bokTab);
            this.tabControl.Controls.Add(this.filmTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 429);
            this.tabControl.TabIndex = 0;
            // 
            // bokTab
            // 
            this.bokTab.Controls.Add(this.pagesUpDwn);
            this.bokTab.Controls.Add(this.bokBtn);
            this.bokTab.Controls.Add(this.sidorLabel);
            this.bokTab.Controls.Add(this.författareLabel);
            this.bokTab.Controls.Add(this.authorTextBox);
            this.bokTab.Controls.Add(this.bokTitelTextBox);
            this.bokTab.Controls.Add(this.bokTitelLabel);
            this.bokTab.Location = new System.Drawing.Point(4, 29);
            this.bokTab.Name = "bokTab";
            this.bokTab.Padding = new System.Windows.Forms.Padding(3);
            this.bokTab.Size = new System.Drawing.Size(376, 396);
            this.bokTab.TabIndex = 0;
            this.bokTab.Text = "Lägg till bok";
            this.bokTab.UseVisualStyleBackColor = true;
            // 
            // sidorNumUpDwn
            // 
            this.pagesUpDwn.Location = new System.Drawing.Point(136, 118);
            this.pagesUpDwn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagesUpDwn.Name = "sidorNumUpDwn";
            this.pagesUpDwn.Size = new System.Drawing.Size(152, 26);
            this.pagesUpDwn.TabIndex = 7;
            // 
            // bokBtn
            // 
            this.bokBtn.Location = new System.Drawing.Point(162, 305);
            this.bokBtn.Name = "bokBtn";
            this.bokBtn.Size = new System.Drawing.Size(123, 34);
            this.bokBtn.TabIndex = 6;
            this.bokBtn.Text = "Lägg till Bok";
            this.bokBtn.UseVisualStyleBackColor = true;
            this.bokBtn.Click += new System.EventHandler(this.addBookBtn);
            // 
            // sidorLabel
            // 
            this.sidorLabel.AutoSize = true;
            this.sidorLabel.Location = new System.Drawing.Point(40, 120);
            this.sidorLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidorLabel.Name = "sidorLabel";
            this.sidorLabel.Size = new System.Drawing.Size(50, 20);
            this.sidorLabel.TabIndex = 5;
            this.sidorLabel.Text = "Sidor:";
            // 
            // författareLabel
            // 
            this.författareLabel.AutoSize = true;
            this.författareLabel.Location = new System.Drawing.Point(40, 83);
            this.författareLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.författareLabel.Name = "författareLabel";
            this.författareLabel.Size = new System.Drawing.Size(84, 20);
            this.författareLabel.TabIndex = 4;
            this.författareLabel.Text = "Författare:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(136, 78);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(150, 26);
            this.authorTextBox.TabIndex = 2;
            // 
            // bokTitelTextBox
            // 
            this.bokTitelTextBox.Location = new System.Drawing.Point(136, 38);
            this.bokTitelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bokTitelTextBox.Name = "bokTitelTextBox";
            this.bokTitelTextBox.Size = new System.Drawing.Size(150, 26);
            this.bokTitelTextBox.TabIndex = 1;
            // 
            // bokTitelLabel
            // 
            this.bokTitelLabel.AutoSize = true;
            this.bokTitelLabel.Location = new System.Drawing.Point(40, 43);
            this.bokTitelLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bokTitelLabel.Name = "bokTitelLabel";
            this.bokTitelLabel.Size = new System.Drawing.Size(42, 20);
            this.bokTitelLabel.TabIndex = 0;
            this.bokTitelLabel.Text = "Titel:";
            // 
            // filmTab
            // 
            this.filmTab.Controls.Add(this.filmBtn);
            this.filmTab.Controls.Add(this.spellängeNumUpDwn);
            this.filmTab.Controls.Add(this.spellängdLabel);
            this.filmTab.Controls.Add(this.directorLabel);
            this.filmTab.Controls.Add(this.directorTextBox);
            this.filmTab.Controls.Add(this.filmTitelTextBox);
            this.filmTab.Controls.Add(this.filmTitelLabel);
            this.filmTab.Location = new System.Drawing.Point(4, 29);
            this.filmTab.Name = "filmTab";
            this.filmTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmTab.Size = new System.Drawing.Size(376, 396);
            this.filmTab.TabIndex = 1;
            this.filmTab.Text = "Lägg till film";
            this.filmTab.UseVisualStyleBackColor = true;
            // 
            // filmBtn
            // 
            this.filmBtn.Location = new System.Drawing.Point(162, 305);
            this.filmBtn.Name = "filmBtn";
            this.filmBtn.Size = new System.Drawing.Size(123, 34);
            this.filmBtn.TabIndex = 13;
            this.filmBtn.Text = "Lägg till Film";
            this.filmBtn.UseVisualStyleBackColor = true;
            this.filmBtn.Click += new System.EventHandler(this.addBookBtn);
            // 
            // spellängeNumUpDwn
            // 
            this.spellängeNumUpDwn.Location = new System.Drawing.Point(136, 118);
            this.spellängeNumUpDwn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spellängeNumUpDwn.Name = "spellängeNumUpDwn";
            this.spellängeNumUpDwn.Size = new System.Drawing.Size(152, 26);
            this.spellängeNumUpDwn.TabIndex = 12;
            // 
            // spellängdLabel
            // 
            this.spellängdLabel.AutoSize = true;
            this.spellängdLabel.Location = new System.Drawing.Point(36, 122);
            this.spellängdLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spellängdLabel.Name = "spellängdLabel";
            this.spellängdLabel.Size = new System.Drawing.Size(84, 20);
            this.spellängdLabel.TabIndex = 11;
            this.spellängdLabel.Text = "Spellängd:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(36, 83);
            this.directorLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(76, 20);
            this.directorLabel.TabIndex = 10;
            this.directorLabel.Text = "Regissör:";
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(136, 78);
            this.directorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(150, 26);
            this.directorTextBox.TabIndex = 8;
            // 
            // filmTitelTextBox
            // 
            this.filmTitelTextBox.Location = new System.Drawing.Point(136, 38);
            this.filmTitelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filmTitelTextBox.Name = "filmTitelTextBox";
            this.filmTitelTextBox.Size = new System.Drawing.Size(150, 26);
            this.filmTitelTextBox.TabIndex = 7;
            // 
            // filmTitelLabel
            // 
            this.filmTitelLabel.AutoSize = true;
            this.filmTitelLabel.Location = new System.Drawing.Point(36, 43);
            this.filmTitelLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filmTitelLabel.Name = "filmTitelLabel";
            this.filmTitelLabel.Size = new System.Drawing.Size(42, 20);
            this.filmTitelLabel.TabIndex = 6;
            this.filmTitelLabel.Text = "Titel:";
            // 
            // visaRadioGroup
            // 
            this.visaRadioGroup.Controls.Add(this.filmRadio);
            this.visaRadioGroup.Controls.Add(this.bokRadio);
            this.visaRadioGroup.Controls.Add(this.allaRadio);
            this.visaRadioGroup.Location = new System.Drawing.Point(402, 445);
            this.visaRadioGroup.Name = "visaRadioGroup";
            this.visaRadioGroup.Size = new System.Drawing.Size(342, 75);
            this.visaRadioGroup.TabIndex = 3;
            this.visaRadioGroup.TabStop = false;
            this.visaRadioGroup.Text = "Visa";
            // 
            // filmRadio
            // 
            this.filmRadio.AutoSize = true;
            this.filmRadio.Location = new System.Drawing.Point(230, 25);
            this.filmRadio.Name = "filmRadio";
            this.filmRadio.Size = new System.Drawing.Size(77, 24);
            this.filmRadio.TabIndex = 2;
            this.filmRadio.Text = "Filmer";
            this.filmRadio.UseVisualStyleBackColor = true;
            // 
            // bokRadio
            // 
            this.bokRadio.AutoSize = true;
            this.bokRadio.Location = new System.Drawing.Point(117, 25);
            this.bokRadio.Name = "bokRadio";
            this.bokRadio.Size = new System.Drawing.Size(84, 24);
            this.bokRadio.TabIndex = 1;
            this.bokRadio.Text = "Böcker";
            this.bokRadio.UseVisualStyleBackColor = true;
            // 
            // allaRadio
            // 
            this.allaRadio.AutoSize = true;
            this.allaRadio.Checked = true;
            this.allaRadio.Location = new System.Drawing.Point(21, 25);
            this.allaRadio.Name = "allaRadio";
            this.allaRadio.Size = new System.Drawing.Size(60, 24);
            this.allaRadio.TabIndex = 0;
            this.allaRadio.TabStop = true;
            this.allaRadio.Text = "Alla";
            this.allaRadio.UseVisualStyleBackColor = true;
            // 
            // listaTextBox
            // 
            this.listaTextBox.Location = new System.Drawing.Point(402, 42);
            this.listaTextBox.Multiline = true;
            this.listaTextBox.Name = "listaTextBox";
            this.listaTextBox.Size = new System.Drawing.Size(386, 396);
            this.listaTextBox.TabIndex = 4;
            // 
            // Mediaregisterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.listaTextBox);
            this.Controls.Add(this.visaRadioGroup);
            this.Controls.Add(this.tabControl);
            this.Name = "Mediaregisterform";
            this.tabControl.ResumeLayout(false);
            this.bokTab.ResumeLayout(false);
            this.bokTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesUpDwn)).EndInit();
            this.filmTab.ResumeLayout(false);
            this.filmTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellängeNumUpDwn)).EndInit();
            this.visaRadioGroup.ResumeLayout(false);
            this.visaRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bokTab;
        private System.Windows.Forms.TabPage filmTab;
        private System.Windows.Forms.GroupBox visaRadioGroup;
        private System.Windows.Forms.RadioButton filmRadio;
        private System.Windows.Forms.RadioButton bokRadio;
        private System.Windows.Forms.RadioButton allaRadio;
        private System.Windows.Forms.TextBox bokTitelTextBox;
        private System.Windows.Forms.Label bokTitelLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label sidorLabel;
        private System.Windows.Forms.Label författareLabel;
        private System.Windows.Forms.Button bokBtn;
        private System.Windows.Forms.Label spellängdLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox filmTitelTextBox;
        private System.Windows.Forms.Label filmTitelLabel;
        private System.Windows.Forms.NumericUpDown pagesUpDwn;
        private System.Windows.Forms.Button filmBtn;
        private System.Windows.Forms.NumericUpDown spellängeNumUpDwn;
        private System.Windows.Forms.TextBox listaTextBox;
    }
}