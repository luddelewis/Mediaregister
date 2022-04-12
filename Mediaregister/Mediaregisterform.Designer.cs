
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
            this.bokBtn = new System.Windows.Forms.Button();
            this.sidorLabel = new System.Windows.Forms.Label();
            this.författareLabel = new System.Windows.Forms.Label();
            this.författareTextBox = new System.Windows.Forms.TextBox();
            this.bokTitelTextBox = new System.Windows.Forms.TextBox();
            this.bokTitelLabel = new System.Windows.Forms.Label();
            this.filmTab = new System.Windows.Forms.TabPage();
            this.listaTextBox = new System.Windows.Forms.RichTextBox();
            this.visaRadioGroup = new System.Windows.Forms.GroupBox();
            this.filmRadio = new System.Windows.Forms.RadioButton();
            this.bokRadio = new System.Windows.Forms.RadioButton();
            this.allaRadio = new System.Windows.Forms.RadioButton();
            this.filmTitelTextBox = new System.Windows.Forms.TextBox();
            this.filmTitelLabel = new System.Windows.Forms.Label();
            this.regissörTextBox = new System.Windows.Forms.TextBox();
            this.regissörLabel = new System.Windows.Forms.Label();
            this.spellängdLabel = new System.Windows.Forms.Label();
            this.spellängeNumUpDw = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.filmBtn = new System.Windows.Forms.Button();
            this.sidorNumUpDw = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.bokTab.SuspendLayout();
            this.filmTab.SuspendLayout();
            this.visaRadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellängeNumUpDw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidorNumUpDw)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bokTab);
            this.tabControl.Controls.Add(this.filmTab);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(256, 279);
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
            this.bokTab.Location = new System.Drawing.Point(4, 22);
            this.bokTab.Margin = new System.Windows.Forms.Padding(2);
            this.bokTab.Name = "bokTab";
            this.bokTab.Padding = new System.Windows.Forms.Padding(2);
            this.bokTab.Size = new System.Drawing.Size(248, 253);
            this.bokTab.TabIndex = 0;
            this.bokTab.Text = "Lägg till bok";
            this.bokTab.UseVisualStyleBackColor = true;
            // 
            // bokBtn
            // 
            this.bokBtn.Location = new System.Drawing.Point(108, 198);
            this.bokBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bokBtn.Name = "bokBtn";
            this.bokBtn.Size = new System.Drawing.Size(82, 22);
            this.bokBtn.TabIndex = 6;
            this.bokBtn.Text = "Lägg till Bok";
            this.bokBtn.UseVisualStyleBackColor = true;
            // 
            // sidorLabel
            // 
            this.sidorLabel.AutoSize = true;
            this.sidorLabel.Location = new System.Drawing.Point(27, 84);
            this.sidorLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sidorLabel.Name = "sidorLabel";
            this.sidorLabel.Size = new System.Drawing.Size(34, 13);
            this.sidorLabel.TabIndex = 5;
            this.sidorLabel.Text = "Sidor:";
            // 
            // författareLabel
            // 
            this.författareLabel.AutoSize = true;
            this.författareLabel.Location = new System.Drawing.Point(27, 54);
            this.författareLabel.Margin = new System.Windows.Forms.Padding(3);
            this.författareLabel.Name = "författareLabel";
            this.författareLabel.Size = new System.Drawing.Size(55, 13);
            this.författareLabel.TabIndex = 4;
            this.författareLabel.Text = "Författare:";
            this.författareLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // författareTextBox
            // 
            this.författareTextBox.Location = new System.Drawing.Point(91, 51);
            this.författareTextBox.Name = "författareTextBox";
            this.författareTextBox.Size = new System.Drawing.Size(101, 20);
            this.författareTextBox.TabIndex = 2;
            // 
            // bokTitelTextBox
            // 
            this.bokTitelTextBox.Location = new System.Drawing.Point(91, 25);
            this.bokTitelTextBox.Name = "bokTitelTextBox";
            this.bokTitelTextBox.Size = new System.Drawing.Size(101, 20);
            this.bokTitelTextBox.TabIndex = 1;
            this.bokTitelTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bokTitelLabel
            // 
            this.bokTitelLabel.AutoSize = true;
            this.bokTitelLabel.Location = new System.Drawing.Point(27, 28);
            this.bokTitelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.bokTitelLabel.Name = "bokTitelLabel";
            this.bokTitelLabel.Size = new System.Drawing.Size(30, 13);
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
            this.filmTab.Location = new System.Drawing.Point(4, 22);
            this.filmTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filmTab.Name = "filmTab";
            this.filmTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filmTab.Size = new System.Drawing.Size(248, 253);
            this.filmTab.TabIndex = 1;
            this.filmTab.Text = "Lägg till film";
            this.filmTab.UseVisualStyleBackColor = true;
            // 
            // listaTextBox
            // 
            this.listaTextBox.Location = new System.Drawing.Point(268, 27);
            this.listaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaTextBox.Name = "listaTextBox";
            this.listaTextBox.Size = new System.Drawing.Size(259, 259);
            this.listaTextBox.TabIndex = 2;
            this.listaTextBox.Text = "";
            // 
            // visaRadioGroup
            // 
            this.visaRadioGroup.Controls.Add(this.filmRadio);
            this.visaRadioGroup.Controls.Add(this.bokRadio);
            this.visaRadioGroup.Controls.Add(this.allaRadio);
            this.visaRadioGroup.Location = new System.Drawing.Point(268, 289);
            this.visaRadioGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visaRadioGroup.Name = "visaRadioGroup";
            this.visaRadioGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visaRadioGroup.Size = new System.Drawing.Size(228, 49);
            this.visaRadioGroup.TabIndex = 3;
            this.visaRadioGroup.TabStop = false;
            this.visaRadioGroup.Text = "Visa";
            // 
            // filmRadio
            // 
            this.filmRadio.AutoSize = true;
            this.filmRadio.Location = new System.Drawing.Point(153, 16);
            this.filmRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filmRadio.Name = "filmRadio";
            this.filmRadio.Size = new System.Drawing.Size(52, 17);
            this.filmRadio.TabIndex = 2;
            this.filmRadio.Text = "Filmer";
            this.filmRadio.UseVisualStyleBackColor = true;
            // 
            // bokRadio
            // 
            this.bokRadio.AutoSize = true;
            this.bokRadio.Location = new System.Drawing.Point(78, 16);
            this.bokRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bokRadio.Name = "bokRadio";
            this.bokRadio.Size = new System.Drawing.Size(59, 17);
            this.bokRadio.TabIndex = 1;
            this.bokRadio.Text = "Böcker";
            this.bokRadio.UseVisualStyleBackColor = true;
            // 
            // allaRadio
            // 
            this.allaRadio.AutoSize = true;
            this.allaRadio.Checked = true;
            this.allaRadio.Location = new System.Drawing.Point(14, 16);
            this.allaRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allaRadio.Name = "allaRadio";
            this.allaRadio.Size = new System.Drawing.Size(42, 17);
            this.allaRadio.TabIndex = 0;
            this.allaRadio.TabStop = true;
            this.allaRadio.Text = "Alla";
            this.allaRadio.UseVisualStyleBackColor = true;
            // 
            // filmTitelTextBox
            // 
            this.filmTitelTextBox.Location = new System.Drawing.Point(91, 25);
            this.filmTitelTextBox.Name = "filmTitelTextBox";
            this.filmTitelTextBox.Size = new System.Drawing.Size(101, 20);
            this.filmTitelTextBox.TabIndex = 7;
            // 
            // filmTitelLabel
            // 
            this.filmTitelLabel.AutoSize = true;
            this.filmTitelLabel.Location = new System.Drawing.Point(24, 28);
            this.filmTitelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.filmTitelLabel.Name = "filmTitelLabel";
            this.filmTitelLabel.Size = new System.Drawing.Size(30, 13);
            this.filmTitelLabel.TabIndex = 6;
            this.filmTitelLabel.Text = "Titel:";
            // 
            // regissörTextBox
            // 
            this.regissörTextBox.Location = new System.Drawing.Point(91, 51);
            this.regissörTextBox.Name = "regissörTextBox";
            this.regissörTextBox.Size = new System.Drawing.Size(101, 20);
            this.regissörTextBox.TabIndex = 8;
            // 
            // regissörLabel
            // 
            this.regissörLabel.AutoSize = true;
            this.regissörLabel.Location = new System.Drawing.Point(24, 54);
            this.regissörLabel.Margin = new System.Windows.Forms.Padding(3);
            this.regissörLabel.Name = "regissörLabel";
            this.regissörLabel.Size = new System.Drawing.Size(51, 13);
            this.regissörLabel.TabIndex = 10;
            this.regissörLabel.Text = "Regissör:";
            // 
            // spellängdLabel
            // 
            this.spellängdLabel.AutoSize = true;
            this.spellängdLabel.Location = new System.Drawing.Point(24, 79);
            this.spellängdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.spellängdLabel.Name = "spellängdLabel";
            this.spellängdLabel.Size = new System.Drawing.Size(57, 13);
            this.spellängdLabel.TabIndex = 11;
            this.spellängdLabel.Text = "Spellängd:";
            // 
            // spellängeNumUpDw
            // 
            this.spellängeNumUpDw.Location = new System.Drawing.Point(91, 77);
            this.spellängeNumUpDw.Name = "spellängeNumUpDw";
            this.spellängeNumUpDw.Size = new System.Drawing.Size(101, 20);
            this.spellängeNumUpDw.TabIndex = 12;
            // 
            // filmBtn
            // 
            this.filmBtn.Location = new System.Drawing.Point(108, 198);
            this.filmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.filmBtn.Name = "filmBtn";
            this.filmBtn.Size = new System.Drawing.Size(82, 22);
            this.filmBtn.TabIndex = 13;
            this.filmBtn.Text = "Lägg till Film";
            this.filmBtn.UseVisualStyleBackColor = true;
            // 
            // sidorNumUpDw
            // 
            this.sidorNumUpDw.Location = new System.Drawing.Point(91, 77);
            this.sidorNumUpDw.Name = "sidorNumUpDw";
            this.sidorNumUpDw.Size = new System.Drawing.Size(101, 20);
            this.sidorNumUpDw.TabIndex = 7;
            // 
            // Mediaregisterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.visaRadioGroup);
            this.Controls.Add(this.listaTextBox);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mediaregisterform";
            this.Load += new System.EventHandler(this.Mediaregisterform_Load);
            this.tabControl.ResumeLayout(false);
            this.bokTab.ResumeLayout(false);
            this.bokTab.PerformLayout();
            this.filmTab.ResumeLayout(false);
            this.filmTab.PerformLayout();
            this.visaRadioGroup.ResumeLayout(false);
            this.visaRadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellängeNumUpDw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidorNumUpDw)).EndInit();
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