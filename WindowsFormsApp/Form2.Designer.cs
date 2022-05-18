namespace WindowsFormsApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBoxTurType = new System.Windows.Forms.ComboBox();
            this.closebutton = new System.Windows.Forms.Button();
            this.udregnButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ØresundcheckBox = new System.Windows.Forms.CheckBox();
            this.StorebæltcheckBox = new System.Windows.Forms.CheckBox();
            this.LufthavncheckBox = new System.Windows.Forms.CheckBox();
            this.CykelcheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MINnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KMnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VognTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TidspunktcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MINnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxTurType);
            this.splitContainer1.Panel1.Controls.Add(this.closebutton);
            this.splitContainer1.Panel1.Controls.Add(this.udregnButton);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ØresundcheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.StorebæltcheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.LufthavncheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.CykelcheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.MINnumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.KMnumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.VognTypecomboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.TidspunktcomboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 620);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBoxTurType
            // 
            this.comboBoxTurType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurType.FormattingEnabled = true;
            this.comboBoxTurType.Items.AddRange(new object[] {
            "Radiotur",
            "Gadetur"});
            this.comboBoxTurType.Location = new System.Drawing.Point(98, 164);
            this.comboBoxTurType.Name = "comboBoxTurType";
            this.comboBoxTurType.Size = new System.Drawing.Size(119, 21);
            this.comboBoxTurType.TabIndex = 35;
            this.comboBoxTurType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTurType_SelectedIndexChanged);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(3, 594);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(64, 23);
            this.closebutton.TabIndex = 34;
            this.closebutton.Text = "LUK";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // udregnButton
            // 
            this.udregnButton.Location = new System.Drawing.Point(114, 498);
            this.udregnButton.Name = "udregnButton";
            this.udregnButton.Size = new System.Drawing.Size(75, 23);
            this.udregnButton.TabIndex = 33;
            this.udregnButton.Text = "UDREGN";
            this.udregnButton.UseVisualStyleBackColor = true;
            this.udregnButton.Click += new System.EventHandler(this.udregnButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(126, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Resultat";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 475);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 17);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ØresundcheckBox
            // 
            this.ØresundcheckBox.AutoSize = true;
            this.ØresundcheckBox.Location = new System.Drawing.Point(202, 427);
            this.ØresundcheckBox.Name = "ØresundcheckBox";
            this.ØresundcheckBox.Size = new System.Drawing.Size(15, 14);
            this.ØresundcheckBox.TabIndex = 30;
            this.ØresundcheckBox.UseVisualStyleBackColor = true;
            this.ØresundcheckBox.CheckedChanged += new System.EventHandler(this.ØresundcheckBox_CheckedChanged);
            // 
            // StorebæltcheckBox
            // 
            this.StorebæltcheckBox.AutoSize = true;
            this.StorebæltcheckBox.Location = new System.Drawing.Point(202, 395);
            this.StorebæltcheckBox.Name = "StorebæltcheckBox";
            this.StorebæltcheckBox.Size = new System.Drawing.Size(15, 14);
            this.StorebæltcheckBox.TabIndex = 29;
            this.StorebæltcheckBox.UseVisualStyleBackColor = true;
            this.StorebæltcheckBox.CheckedChanged += new System.EventHandler(this.StorebæltcheckBox_CheckedChanged);
            // 
            // LufthavncheckBox
            // 
            this.LufthavncheckBox.AutoSize = true;
            this.LufthavncheckBox.Location = new System.Drawing.Point(202, 358);
            this.LufthavncheckBox.Name = "LufthavncheckBox";
            this.LufthavncheckBox.Size = new System.Drawing.Size(15, 14);
            this.LufthavncheckBox.TabIndex = 28;
            this.LufthavncheckBox.UseVisualStyleBackColor = true;
            this.LufthavncheckBox.CheckedChanged += new System.EventHandler(this.LufthavncheckBox_CheckedChanged);
            // 
            // CykelcheckBox
            // 
            this.CykelcheckBox.AutoSize = true;
            this.CykelcheckBox.Location = new System.Drawing.Point(202, 319);
            this.CykelcheckBox.Name = "CykelcheckBox";
            this.CykelcheckBox.Size = new System.Drawing.Size(15, 14);
            this.CykelcheckBox.TabIndex = 27;
            this.CykelcheckBox.UseVisualStyleBackColor = true;
            this.CykelcheckBox.CheckedChanged += new System.EventHandler(this.CykelcheckBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Lillebælt bro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(137, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tillæg";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Storebælt bro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Lufthavnstillæg (AAL til CPH)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cykel / Opbæring og hjælp";
            // 
            // MINnumericUpDown
            // 
            this.MINnumericUpDown.Location = new System.Drawing.Point(98, 91);
            this.MINnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MINnumericUpDown.Name = "MINnumericUpDown";
            this.MINnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MINnumericUpDown.TabIndex = 17;
            this.MINnumericUpDown.ValueChanged += new System.EventHandler(this.MINnumericUpDown_ValueChanged);
            // 
            // KMnumericUpDown
            // 
            this.KMnumericUpDown.DecimalPlaces = 2;
            this.KMnumericUpDown.Location = new System.Drawing.Point(98, 56);
            this.KMnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.KMnumericUpDown.Name = "KMnumericUpDown";
            this.KMnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.KMnumericUpDown.TabIndex = 16;
            this.KMnumericUpDown.ValueChanged += new System.EventHandler(this.KMnumericUpDown_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(138, 556);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 61);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "General";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vogn Type";
            // 
            // VognTypecomboBox
            // 
            this.VognTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VognTypecomboBox.FormattingEnabled = true;
            this.VognTypecomboBox.Items.AddRange(new object[] {
            "Personbil",
            "Storvogn"});
            this.VognTypecomboBox.Location = new System.Drawing.Point(98, 240);
            this.VognTypecomboBox.Name = "VognTypecomboBox";
            this.VognTypecomboBox.Size = new System.Drawing.Size(119, 21);
            this.VognTypecomboBox.TabIndex = 12;
            this.VognTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.VognTypecomboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tidspunkt";
            // 
            // TidspunktcomboBox
            // 
            this.TidspunktcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TidspunktcomboBox.FormattingEnabled = true;
            this.TidspunktcomboBox.Items.AddRange(new object[] {
            "Dag",
            "Nat"});
            this.TidspunktcomboBox.Location = new System.Drawing.Point(98, 202);
            this.TidspunktcomboBox.Name = "TidspunktcomboBox";
            this.TidspunktcomboBox.Size = new System.Drawing.Size(119, 21);
            this.TidspunktcomboBox.TabIndex = 10;
            this.TidspunktcomboBox.SelectedIndexChanged += new System.EventHandler(this.TidspunktcomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(137, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Typer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tur Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antal Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antal KM";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(747, 620);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://google.com/maps?q=", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1055, 620);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pris Beregner";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MINnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox VognTypecomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TidspunktcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown MINnumericUpDown;
        private System.Windows.Forms.NumericUpDown KMnumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ØresundcheckBox;
        private System.Windows.Forms.CheckBox StorebæltcheckBox;
        private System.Windows.Forms.CheckBox LufthavncheckBox;
        private System.Windows.Forms.CheckBox CykelcheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button udregnButton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.ComboBox comboBoxTurType;
    }
}