namespace WindowsFormsApp
{
    partial class hbPrisBeregner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hbPrisBeregner));
            this.AreacomboBox = new System.Windows.Forms.ComboBox();
            this.MINnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SinglePriceTextBox = new System.Windows.Forms.TextBox();
            this.UdregnButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MINnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AreacomboBox
            // 
            this.AreacomboBox.FormattingEnabled = true;
            this.AreacomboBox.Items.AddRange(new object[] {
            "København",
            "Århus",
            "Vejle",
            "Øvrig"});
            this.AreacomboBox.Location = new System.Drawing.Point(181, 86);
            this.AreacomboBox.Name = "AreacomboBox";
            this.AreacomboBox.Size = new System.Drawing.Size(121, 21);
            this.AreacomboBox.TabIndex = 0;
            this.AreacomboBox.SelectedIndexChanged += new System.EventHandler(this.AreacomboBox_SelectedIndexChanged);
            // 
            // MINnumericUpDown
            // 
            this.MINnumericUpDown.Location = new System.Drawing.Point(181, 130);
            this.MINnumericUpDown.Name = "MINnumericUpDown";
            this.MINnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MINnumericUpDown.TabIndex = 1;
            this.MINnumericUpDown.ValueChanged += new System.EventHandler(this.MINnumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Område:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 132);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Antal Min:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(181, 197);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(120, 20);
            this.TotalTextBox.TabIndex = 5;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.TotalTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 200);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pris i alt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 89);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pris pr. min. :";
            // 
            // SinglePriceTextBox
            // 
            this.SinglePriceTextBox.Location = new System.Drawing.Point(379, 87);
            this.SinglePriceTextBox.Name = "SinglePriceTextBox";
            this.SinglePriceTextBox.ReadOnly = true;
            this.SinglePriceTextBox.Size = new System.Drawing.Size(79, 20);
            this.SinglePriceTextBox.TabIndex = 7;
            this.SinglePriceTextBox.Text = "Vælg Område";
            this.SinglePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SinglePriceTextBox.TextChanged += new System.EventHandler(this.SinglePriceTextBox_TextChanged);
            // 
            // UdregnButton
            // 
            this.UdregnButton.Location = new System.Drawing.Point(204, 168);
            this.UdregnButton.Name = "UdregnButton";
            this.UdregnButton.Size = new System.Drawing.Size(75, 23);
            this.UdregnButton.TabIndex = 9;
            this.UdregnButton.Text = "Udregn";
            this.UdregnButton.UseVisualStyleBackColor = true;
            this.UdregnButton.Click += new System.EventHandler(this.UdregnButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, -62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 131);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // hbPrisBeregner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 267);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UdregnButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SinglePriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MINnumericUpDown);
            this.Controls.Add(this.AreacomboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hbPrisBeregner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HB Prisberegner";
            ((System.ComponentModel.ISupportInitialize)(this.MINnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AreacomboBox;
        private System.Windows.Forms.NumericUpDown MINnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SinglePriceTextBox;
        private System.Windows.Forms.Button UdregnButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}