namespace WindowsFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.TaxiLogo = new System.Windows.Forms.PictureBox();
            this.NormalPrisberegner = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PrisberegnerButton = new System.Windows.Forms.Button();
            this.HBBeregnerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.LægevagtPortalKnap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaxiLogo
            // 
            this.TaxiLogo.BackColor = System.Drawing.Color.Transparent;
            this.TaxiLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaxiLogo.BackgroundImage")));
            this.TaxiLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TaxiLogo.Location = new System.Drawing.Point(611, -1);
            this.TaxiLogo.Name = "TaxiLogo";
            this.TaxiLogo.Size = new System.Drawing.Size(149, 94);
            this.TaxiLogo.TabIndex = 0;
            this.TaxiLogo.TabStop = false;
            // 
            // NormalPrisberegner
            // 
            this.NormalPrisberegner.AutoSize = true;
            this.NormalPrisberegner.BackColor = System.Drawing.Color.Transparent;
            this.NormalPrisberegner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormalPrisberegner.FlatAppearance.BorderSize = 0;
            this.NormalPrisberegner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalPrisberegner.ForeColor = System.Drawing.Color.White;
            this.NormalPrisberegner.Image = ((System.Drawing.Image)(resources.GetObject("NormalPrisberegner.Image")));
            this.NormalPrisberegner.Location = new System.Drawing.Point(0, 124);
            this.NormalPrisberegner.Name = "NormalPrisberegner";
            this.NormalPrisberegner.Size = new System.Drawing.Size(200, 102);
            this.NormalPrisberegner.TabIndex = 1;
            this.NormalPrisberegner.Text = "Normal Prisberegner";
            this.NormalPrisberegner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NormalPrisberegner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NormalPrisberegner.UseVisualStyleBackColor = false;
            this.NormalPrisberegner.Click += new System.EventHandler(this.NormalPrisberegner_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrisberegnerButton);
            this.panel1.Controls.Add(this.HBBeregnerButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.NormalPrisberegner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 620);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "© LuziCode";
            // 
            // PrisberegnerButton
            // 
            this.PrisberegnerButton.AutoSize = true;
            this.PrisberegnerButton.BackColor = System.Drawing.Color.Transparent;
            this.PrisberegnerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrisberegnerButton.FlatAppearance.BorderSize = 0;
            this.PrisberegnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrisberegnerButton.ForeColor = System.Drawing.Color.White;
            this.PrisberegnerButton.Image = ((System.Drawing.Image)(resources.GetObject("PrisberegnerButton.Image")));
            this.PrisberegnerButton.Location = new System.Drawing.Point(0, 448);
            this.PrisberegnerButton.Name = "PrisberegnerButton";
            this.PrisberegnerButton.Size = new System.Drawing.Size(205, 102);
            this.PrisberegnerButton.TabIndex = 4;
            this.PrisberegnerButton.Text = "Lægevagt Prisberegner";
            this.PrisberegnerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PrisberegnerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrisberegnerButton.UseVisualStyleBackColor = false;
            this.PrisberegnerButton.Click += new System.EventHandler(this.PrisberegnerButton_Click);
            // 
            // HBBeregnerButton
            // 
            this.HBBeregnerButton.AutoSize = true;
            this.HBBeregnerButton.BackColor = System.Drawing.Color.Transparent;
            this.HBBeregnerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HBBeregnerButton.FlatAppearance.BorderSize = 0;
            this.HBBeregnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HBBeregnerButton.ForeColor = System.Drawing.Color.White;
            this.HBBeregnerButton.Image = ((System.Drawing.Image)(resources.GetObject("HBBeregnerButton.Image")));
            this.HBBeregnerButton.Location = new System.Drawing.Point(0, 340);
            this.HBBeregnerButton.Name = "HBBeregnerButton";
            this.HBBeregnerButton.Size = new System.Drawing.Size(200, 112);
            this.HBBeregnerButton.TabIndex = 3;
            this.HBBeregnerButton.Text = "HB Prisberegner";
            this.HBBeregnerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HBBeregnerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HBBeregnerButton.UseVisualStyleBackColor = false;
            this.HBBeregnerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 102);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get-E Prisberegner";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(21)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 90);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 90);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.LægevagtPortalKnap);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 87);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel4.Location = new System.Drawing.Point(253, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 10);
            this.panel4.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(492, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 48);
            this.button4.TabIndex = 12;
            this.button4.Text = "Fly Tjek";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LægevagtPortalKnap
            // 
            this.LægevagtPortalKnap.AutoSize = true;
            this.LægevagtPortalKnap.BackColor = System.Drawing.Color.Transparent;
            this.LægevagtPortalKnap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LægevagtPortalKnap.FlatAppearance.BorderSize = 0;
            this.LægevagtPortalKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LægevagtPortalKnap.ForeColor = System.Drawing.Color.White;
            this.LægevagtPortalKnap.Location = new System.Drawing.Point(346, 27);
            this.LægevagtPortalKnap.Name = "LægevagtPortalKnap";
            this.LægevagtPortalKnap.Size = new System.Drawing.Size(122, 48);
            this.LægevagtPortalKnap.TabIndex = 11;
            this.LægevagtPortalKnap.Text = "Deltaplan";
            this.LægevagtPortalKnap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LægevagtPortalKnap.UseVisualStyleBackColor = false;
            this.LægevagtPortalKnap.Click += new System.EventHandler(this.LægevagtPortalKnap_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(205, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get-E";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.TaxiLogo);
            this.panel5.Location = new System.Drawing.Point(248, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(761, 447);
            this.panel5.TabIndex = 14;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 620);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi4x27 Portal";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MainMenu_Layout);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TaxiLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TaxiLogo;
        private System.Windows.Forms.Button NormalPrisberegner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PrisberegnerButton;
        private System.Windows.Forms.Button HBBeregnerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button LægevagtPortalKnap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
    }
}

