namespace WindowsFormsApp
{
    partial class LægevagtMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LægevagtMenu));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UdregnButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.KontoNummerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MINnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MINnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "08:00-16:00 (Lørdag-Søndag)",
            "16:00-23:00 (Søndag-Torsdag)",
            "16:00-23:00 (Fredag-Lørdag)",
            "17:00-23:00 (Søndag-Torsdag)",
            "17:00-23:00 (Fredag-Lørdag)",
            "23:00-08:00 (Søndag-Torsdag)",
            "23:00-08:00 (Fredag-Lørdag)"});
            this.comboBox1.Location = new System.Drawing.Point(186, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UdregnButton
            // 
            this.UdregnButton.Location = new System.Drawing.Point(230, 181);
            this.UdregnButton.Name = "UdregnButton";
            this.UdregnButton.Size = new System.Drawing.Size(75, 23);
            this.UdregnButton.TabIndex = 18;
            this.UdregnButton.Text = "Udregn";
            this.UdregnButton.UseVisualStyleBackColor = true;
            this.UdregnButton.Click += new System.EventHandler(this.UdregnButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 77);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Konto nr.:";
            // 
            // KontoNummerTextBox
            // 
            this.KontoNummerTextBox.Location = new System.Drawing.Point(448, 74);
            this.KontoNummerTextBox.Name = "KontoNummerTextBox";
            this.KontoNummerTextBox.ReadOnly = true;
            this.KontoNummerTextBox.Size = new System.Drawing.Size(79, 20);
            this.KontoNummerTextBox.TabIndex = 16;
            this.KontoNummerTextBox.Text = "Vælg Vagt";
            this.KontoNummerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KontoNummerTextBox.TextChanged += new System.EventHandler(this.KontoNummerTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 213);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pris i alt:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(207, 210);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(120, 20);
            this.TotalTextBox.TabIndex = 14;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.TotalTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 102);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Antal Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vagt:";
            // 
            // MINnumericUpDown
            // 
            this.MINnumericUpDown.Location = new System.Drawing.Point(186, 100);
            this.MINnumericUpDown.Name = "MINnumericUpDown";
            this.MINnumericUpDown.Size = new System.Drawing.Size(163, 20);
            this.MINnumericUpDown.TabIndex = 11;
            this.MINnumericUpDown.ValueChanged += new System.EventHandler(this.MINnumericUpDown_ValueChanged);
            // 
            // LægevagtMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 289);
            this.Controls.Add(this.UdregnButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KontoNummerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MINnumericUpDown);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LægevagtMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lægevagt Udregner";
            ((System.ComponentModel.ISupportInitialize)(this.MINnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UdregnButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KontoNummerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MINnumericUpDown;
    }
}