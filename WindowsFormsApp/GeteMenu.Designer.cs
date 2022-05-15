
namespace WindowsFormsApp
{
    partial class GeteMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeteMenu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AntalKMnumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.EkstraStopNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.VogntypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StorebæltCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ØresundCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UdregnButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MeetGreetCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntalKMnumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkstraStopNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.MeetGreetCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.ResultTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.UdregnButton);
            this.splitContainer1.Panel1.Controls.Add(this.ØresundCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.StorebæltCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.VogntypeComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.EkstraStopNumUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.AntalKMnumUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1407, 763);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(934, 763);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://google.com/maps", System.UriKind.Absolute);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AntalKMnumUpDown
            // 
            this.AntalKMnumUpDown.Location = new System.Drawing.Point(180, 160);
            this.AntalKMnumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AntalKMnumUpDown.Name = "AntalKMnumUpDown";
            this.AntalKMnumUpDown.Size = new System.Drawing.Size(120, 22);
            this.AntalKMnumUpDown.TabIndex = 1;
            this.AntalKMnumUpDown.ValueChanged += new System.EventHandler(this.AntalKMnumUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distance i alt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ekstra stop";
            // 
            // EkstraStopNumUpDown
            // 
            this.EkstraStopNumUpDown.Location = new System.Drawing.Point(180, 200);
            this.EkstraStopNumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EkstraStopNumUpDown.Name = "EkstraStopNumUpDown";
            this.EkstraStopNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.EkstraStopNumUpDown.TabIndex = 3;
            this.EkstraStopNumUpDown.ValueChanged += new System.EventHandler(this.EkstraStopNumUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vogn type";
            // 
            // VogntypeComboBox
            // 
            this.VogntypeComboBox.AllowDrop = true;
            this.VogntypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VogntypeComboBox.FormattingEnabled = true;
            this.VogntypeComboBox.Items.AddRange(new object[] {
            "Sedan",
            "Minivan"});
            this.VogntypeComboBox.Location = new System.Drawing.Point(180, 240);
            this.VogntypeComboBox.Name = "VogntypeComboBox";
            this.VogntypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.VogntypeComboBox.TabIndex = 7;
            this.VogntypeComboBox.SelectedIndexChanged += new System.EventHandler(this.VogntypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Meet and greet";
            // 
            // StorebæltCheckBox
            // 
            this.StorebæltCheckBox.AutoSize = true;
            this.StorebæltCheckBox.Location = new System.Drawing.Point(180, 349);
            this.StorebæltCheckBox.Name = "StorebæltCheckBox";
            this.StorebæltCheckBox.Size = new System.Drawing.Size(18, 17);
            this.StorebæltCheckBox.TabIndex = 11;
            this.StorebæltCheckBox.UseVisualStyleBackColor = true;
            this.StorebæltCheckBox.CheckedChanged += new System.EventHandler(this.StorebæltCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Storebæltsbro";
            // 
            // ØresundCheckBox
            // 
            this.ØresundCheckBox.AutoSize = true;
            this.ØresundCheckBox.Location = new System.Drawing.Point(180, 382);
            this.ØresundCheckBox.Name = "ØresundCheckBox";
            this.ØresundCheckBox.Size = new System.Drawing.Size(18, 17);
            this.ØresundCheckBox.TabIndex = 13;
            this.ØresundCheckBox.UseVisualStyleBackColor = true;
            this.ØresundCheckBox.CheckedChanged += new System.EventHandler(this.ØresundCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Øresundsbro";
            // 
            // UdregnButton
            // 
            this.UdregnButton.Location = new System.Drawing.Point(159, 449);
            this.UdregnButton.Name = "UdregnButton";
            this.UdregnButton.Size = new System.Drawing.Size(160, 51);
            this.UdregnButton.TabIndex = 14;
            this.UdregnButton.Text = "UDREGN";
            this.UdregnButton.UseVisualStyleBackColor = true;
            this.UdregnButton.Click += new System.EventHandler(this.UdregnButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(107, 558);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(255, 67);
            this.ResultTextBox.TabIndex = 15;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(257, 663);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 132);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // MeetGreetCheckBox
            // 
            this.MeetGreetCheckBox.AutoSize = true;
            this.MeetGreetCheckBox.Location = new System.Drawing.Point(180, 312);
            this.MeetGreetCheckBox.Name = "MeetGreetCheckBox";
            this.MeetGreetCheckBox.Size = new System.Drawing.Size(18, 17);
            this.MeetGreetCheckBox.TabIndex = 17;
            this.MeetGreetCheckBox.UseVisualStyleBackColor = true;
            this.MeetGreetCheckBox.CheckedChanged += new System.EventHandler(this.MeetGreetCheckBox_CheckedChanged);
            // 
            // GeteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 763);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GeteMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GET-E Prisberegner";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntalKMnumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkstraStopNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown AntalKMnumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VogntypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EkstraStopNumUpDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox ØresundCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox StorebæltCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UdregnButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox MeetGreetCheckBox;
    }
}