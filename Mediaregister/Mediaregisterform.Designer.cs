
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
            this.sidorNumUpDw = new System.Windows.Forms.NumericUpDown();
            this.bokBtn = new System.Windows.Forms.Button();
            this.sidorLabel = new System.Windows.Forms.Label();
            this.författareLabel = new System.Windows.Forms.Label();
            this.författareTextBox = new System.Windows.Forms.TextBox();
            this.bokTitelTextBox = new System.Windows.Forms.TextBox();
            this.bokTitelLabel = new System.Windows.Forms.Label();
            this.filmTab = new System.Windows.Forms.TabPage();
            this.filmBtn = new System.Windows.Forms.Button();
            this.spellängeNumUpDw = new System.Windows.Forms.NumericUpDown();
            this.spellängdLabel = new System.Windows.Forms.Label();
            this.regissörLabel = new System.Windows.Forms.Label();
            this.regissörTextBox = new System.Windows.Forms.TextBox();
            this.filmTitelTextBox = new System.Windows.Forms.TextBox();
            this.filmTitelLabel = new System.Windows.Forms.Label();
            this.listaTextBox = new System.Windows.Forms.RichTextBox();
            this.visaRadioGroup = new System.Windows.Forms.GroupBox();
            this.filmRadio = new System.Windows.Forms.RadioButton();
            this.bokRadio = new System.Windows.Forms.RadioButton();
            this.allaRadio = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.bokTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidorNumUpDw)).BeginInit();
            this.filmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellängeNumUpDw)).BeginInit();
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
            this.bokTab.Controls.Add(this.sidorNumUpDw);
            this.bokTab.Controls.Add(this.bokBtn);
            this.bokTab.Controls.Add(this.sidorLabel);
            this.bokTab.Controls.Add(this.författareLabel);
            this.bokTab.Controls.Add(this.författareTextBox);
            this.bokTab.Controls.Add(this.bokTitelTextBox);
            this.bokTab.Controls.Add(this.bokTitelLabel);
            this.bokTab.Location = new System.Drawing.Point(4, 29);
            this.bokTab.Name = "bokTab";
            this.bokTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.bokTab.Size = new System.Drawing.Size(376, 396);
            this.bokTab.TabIndex = 0;
            this.bokTab.Text = "Lägg till bok";
            this.bokTab.UseVisualStyleBackColor = true;
            // 
            // sidorNumUpDw
            // 
            this.sidorNumUpDw.Location = new System.Drawing.Point(136, 118);
            this.sidorNumUpDw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidorNumUpDw.Name = "sidorNumUpDw";
            this.sidorNumUpDw.Size = new System.Drawing.Size(152, 26);
            this.sidorNumUpDw.TabIndex = 7;
            // 
            // bokBtn
            // 
            this.bokBtn.Location = new System.Drawing.Point(162, 305);
            this.bokBtn.Name = "bokBtn";
            this.bokBtn.Size = new System.Drawing.Size(123, 34);
            this.bokBtn.TabIndex = 6;
            this.bokBtn.Text = "Lägg till Bok";
            this.bokBtn.UseVisualStyleBackColor = true;
            // 
            // sidorLabel
            // 
            this.sidorLabel.AutoSize = true;
            this.sidorLabel.Location = new System.Drawing.Point(40, 129);
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
            // författareTextBox
            // 
            this.författareTextBox.Location = new System.Drawing.Point(136, 78);
            this.författareTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.författareTextBox.Name = "författareTextBox";
            this.författareTextBox.Size = new System.Drawing.Size(150, 26);
            this.författareTextBox.TabIndex = 2;
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
            this.filmTab.Controls.Add(this.spellängeNumUpDw);
            this.filmTab.Controls.Add(this.spellängdLabel);
            this.filmTab.Controls.Add(this.regissörLabel);
            this.filmTab.Controls.Add(this.regissörTextBox);
            this.filmTab.Controls.Add(this.filmTitelTextBox);
            this.filmTab.Controls.Add(this.filmTitelLabel);
            this.filmTab.Location = new System.Drawing.Point(4, 29);
            this.filmTab.Name = "filmTab";
            this.filmTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            // 
            // spellängeNumUpDw
            // 
            this.spellängeNumUpDw.Location = new System.Drawing.Point(136, 118);
            this.spellängeNumUpDw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spellängeNumUpDw.Name = "spellängeNumUpDw";
            this.spellängeNumUpDw.Size = new System.Drawing.Size(152, 26);
            this.spellängeNumUpDw.TabIndex = 12;
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
            // regissörLabel
            // 
            this.regissörLabel.AutoSize = true;
            this.regissörLabel.Location = new System.Drawing.Point(36, 83);
            this.regissörLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regissörLabel.Name = "regissörLabel";
            this.regissörLabel.Size = new System.Drawing.Size(76, 20);
            this.regissörLabel.TabIndex = 10;
            this.regissörLabel.Text = "Regissör:";
            // 
            // regissörTextBox
            // 
            this.regissörTextBox.Location = new System.Drawing.Point(136, 78);
            this.regissörTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regissörTextBox.Name = "regissörTextBox";
            this.regissörTextBox.Size = new System.Drawing.Size(150, 26);
            this.regissörTextBox.TabIndex = 8;
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
            // listaTextBox
            // 
            this.listaTextBox.Location = new System.Drawing.Point(402, 42);
            this.listaTextBox.Name = "listaTextBox";
            this.listaTextBox.Size = new System.Drawing.Size(386, 396);
            this.listaTextBox.TabIndex = 2;
            this.listaTextBox.Text = "";
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
            // Mediaregisterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.visaRadioGroup);
            this.Controls.Add(this.listaTextBox);
            this.Controls.Add(this.tabControl);
            this.Name = "Mediaregisterform";
            this.tabControl.ResumeLayout(false);
            this.bokTab.ResumeLayout(false);
            this.bokTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidorNumUpDw)).EndInit();
            this.filmTab.ResumeLayout(false);
            this.filmTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellängeNumUpDw)).EndInit();
            this.visaRadioGroup.ResumeLayout(false);
            this.visaRadioGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bokTab;
        private System.Windows.Forms.TabPage filmTab;
        private System.Windows.Forms.RichTextBox listaTextBox;
        private System.Windows.Forms.GroupBox visaRadioGroup;
        private System.Windows.Forms.RadioButton filmRadio;
        private System.Windows.Forms.RadioButton bokRadio;
        private System.Windows.Forms.RadioButton allaRadio;
        private System.Windows.Forms.TextBox bokTitelTextBox;
        private System.Windows.Forms.Label bokTitelLabel;
        private System.Windows.Forms.TextBox författareTextBox;
        private System.Windows.Forms.Label sidorLabel;
        private System.Windows.Forms.Label författareLabel;
        private System.Windows.Forms.Button bokBtn;
        private System.Windows.Forms.Label spellängdLabel;
        private System.Windows.Forms.Label regissörLabel;
        private System.Windows.Forms.TextBox regissörTextBox;
        private System.Windows.Forms.TextBox filmTitelTextBox;
        private System.Windows.Forms.Label filmTitelLabel;
        private System.Windows.Forms.NumericUpDown sidorNumUpDw;
        private System.Windows.Forms.Button filmBtn;
        private System.Windows.Forms.NumericUpDown spellängeNumUpDw;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}