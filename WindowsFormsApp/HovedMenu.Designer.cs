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
            this.GetEPrisberegner = new System.Windows.Forms.Button();
            this.LægevagtPrisberegner = new System.Windows.Forms.Button();
            this.HbPrisberegner = new System.Windows.Forms.Button();
            this.LukNed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GETePortalKnap = new System.Windows.Forms.Button();
            this.LægevagtPortalKnap = new System.Windows.Forms.Button();
            this.SharepointPortalKnap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TaxiLogo
            // 
            this.TaxiLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaxiLogo.BackgroundImage")));
            this.TaxiLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TaxiLogo.Location = new System.Drawing.Point(180, 3);
            this.TaxiLogo.Name = "TaxiLogo";
            this.TaxiLogo.Size = new System.Drawing.Size(672, 229);
            this.TaxiLogo.TabIndex = 0;
            this.TaxiLogo.TabStop = false;
            // 
            // NormalPrisberegner
            // 
            this.NormalPrisberegner.AutoSize = true;
            this.NormalPrisberegner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormalPrisberegner.Location = new System.Drawing.Point(357, 284);
            this.NormalPrisberegner.Name = "NormalPrisberegner";
            this.NormalPrisberegner.Size = new System.Drawing.Size(144, 67);
            this.NormalPrisberegner.TabIndex = 1;
            this.NormalPrisberegner.Text = "Normal Prisberegner";
            this.NormalPrisberegner.UseVisualStyleBackColor = true;
            this.NormalPrisberegner.Click += new System.EventHandler(this.NormalPrisberegner_Click);
            // 
            // GetEPrisberegner
            // 
            this.GetEPrisberegner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetEPrisberegner.Location = new System.Drawing.Point(184, 284);
            this.GetEPrisberegner.Name = "GetEPrisberegner";
            this.GetEPrisberegner.Size = new System.Drawing.Size(144, 67);
            this.GetEPrisberegner.TabIndex = 2;
            this.GetEPrisberegner.Text = "Get-E Prisberegner";
            this.GetEPrisberegner.UseVisualStyleBackColor = true;
            this.GetEPrisberegner.Click += new System.EventHandler(this.GetEPrisberegner_Click);
            // 
            // LægevagtPrisberegner
            // 
            this.LægevagtPrisberegner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LægevagtPrisberegner.Location = new System.Drawing.Point(700, 284);
            this.LægevagtPrisberegner.Name = "LægevagtPrisberegner";
            this.LægevagtPrisberegner.Size = new System.Drawing.Size(144, 67);
            this.LægevagtPrisberegner.TabIndex = 3;
            this.LægevagtPrisberegner.Text = "Lægevagt Prisberegner";
            this.LægevagtPrisberegner.UseVisualStyleBackColor = true;
            this.LægevagtPrisberegner.Click += new System.EventHandler(this.LægevagtPrisberegner_Click);
            // 
            // HbPrisberegner
            // 
            this.HbPrisberegner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HbPrisberegner.Location = new System.Drawing.Point(527, 284);
            this.HbPrisberegner.Name = "HbPrisberegner";
            this.HbPrisberegner.Size = new System.Drawing.Size(144, 67);
            this.HbPrisberegner.TabIndex = 4;
            this.HbPrisberegner.Text = "HB Prisberegner";
            this.HbPrisberegner.UseVisualStyleBackColor = true;
            this.HbPrisberegner.Click += new System.EventHandler(this.HbPrisberegner_Click);
            // 
            // LukNed
            // 
            this.LukNed.Location = new System.Drawing.Point(968, 585);
            this.LukNed.Name = "LukNed";
            this.LukNed.Size = new System.Drawing.Size(75, 23);
            this.LukNed.TabIndex = 5;
            this.LukNed.Text = "LUK NED";
            this.LukNed.UseVisualStyleBackColor = true;
            this.LukNed.Click += new System.EventHandler(this.LukNed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(400, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRISBEREGNINGER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "EKSTRA HJÆLP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GETePortalKnap
            // 
            this.GETePortalKnap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GETePortalKnap.Location = new System.Drawing.Point(307, 414);
            this.GETePortalKnap.Name = "GETePortalKnap";
            this.GETePortalKnap.Size = new System.Drawing.Size(101, 41);
            this.GETePortalKnap.TabIndex = 8;
            this.GETePortalKnap.Text = "GET-E";
            this.GETePortalKnap.UseVisualStyleBackColor = true;
            this.GETePortalKnap.Click += new System.EventHandler(this.GETePortalKnap_Click);
            // 
            // LægevagtPortalKnap
            // 
            this.LægevagtPortalKnap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LægevagtPortalKnap.Location = new System.Drawing.Point(433, 414);
            this.LægevagtPortalKnap.Name = "LægevagtPortalKnap";
            this.LægevagtPortalKnap.Size = new System.Drawing.Size(101, 41);
            this.LægevagtPortalKnap.TabIndex = 9;
            this.LægevagtPortalKnap.Text = "DELTAPLAN";
            this.LægevagtPortalKnap.UseVisualStyleBackColor = true;
            this.LægevagtPortalKnap.Click += new System.EventHandler(this.LægevagtPortalKnap_Click);
            // 
            // SharepointPortalKnap
            // 
            this.SharepointPortalKnap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SharepointPortalKnap.Location = new System.Drawing.Point(559, 414);
            this.SharepointPortalKnap.Name = "SharepointPortalKnap";
            this.SharepointPortalKnap.Size = new System.Drawing.Size(101, 41);
            this.SharepointPortalKnap.TabIndex = 10;
            this.SharepointPortalKnap.Text = "FLY TJEK";
            this.SharepointPortalKnap.UseVisualStyleBackColor = true;
            this.SharepointPortalKnap.Click += new System.EventHandler(this.SharepointPortalKnap_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(844, 496);
            this.Controls.Add(this.SharepointPortalKnap);
            this.Controls.Add(this.LægevagtPortalKnap);
            this.Controls.Add(this.GETePortalKnap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LukNed);
            this.Controls.Add(this.HbPrisberegner);
            this.Controls.Add(this.LægevagtPrisberegner);
            this.Controls.Add(this.GetEPrisberegner);
            this.Controls.Add(this.NormalPrisberegner);
            this.Controls.Add(this.TaxiLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi4x27 Portal";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MainMenu_Layout);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TaxiLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TaxiLogo;
        private System.Windows.Forms.Button NormalPrisberegner;
        private System.Windows.Forms.Button GetEPrisberegner;
        private System.Windows.Forms.Button LægevagtPrisberegner;
        private System.Windows.Forms.Button HbPrisberegner;
        private System.Windows.Forms.Button LukNed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GETePortalKnap;
        private System.Windows.Forms.Button LægevagtPortalKnap;
        private System.Windows.Forms.Button SharepointPortalKnap;
    }
}

