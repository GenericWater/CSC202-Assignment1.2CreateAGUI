namespace WindowsFormsApp1
{
    partial class indexHorror
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexHorror));
            this.TBname = new System.Windows.Forms.TextBox();
            this.BTNname = new System.Windows.Forms.Button();
            this.PBname = new System.Windows.Forms.PictureBox();
            this.GBkillers = new System.Windows.Forms.GroupBox();
            this.BTNsubmit = new System.Windows.Forms.Button();
            this.CBJeff = new System.Windows.Forms.CheckBox();
            this.CBTed = new System.Windows.Forms.CheckBox();
            this.CBJack = new System.Windows.Forms.CheckBox();
            this.CBJohn = new System.Windows.Forms.CheckBox();
            this.CBRichard = new System.Windows.Forms.CheckBox();
            this.CBRobert = new System.Windows.Forms.CheckBox();
            this.CBHolmes = new System.Windows.Forms.CheckBox();
            this.CBBelle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PBscare = new System.Windows.Forms.ProgressBar();
            this.BTNscare = new System.Windows.Forms.Button();
            this.PicBoxScare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBname)).BeginInit();
            this.GBkillers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxScare)).BeginInit();
            this.SuspendLayout();
            // 
            // TBname
            // 
            this.TBname.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBname.Location = new System.Drawing.Point(76, 88);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(215, 24);
            this.TBname.TabIndex = 0;
            this.TBname.Text = "Enter Name Here";
            this.TBname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNname
            // 
            this.BTNname.BackColor = System.Drawing.Color.Firebrick;
            this.BTNname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNname.ForeColor = System.Drawing.Color.Chartreuse;
            this.BTNname.Location = new System.Drawing.Point(125, 127);
            this.BTNname.Name = "BTNname";
            this.BTNname.Size = new System.Drawing.Size(118, 54);
            this.BTNname.TabIndex = 1;
            this.BTNname.Text = "Click when ready!";
            this.BTNname.UseVisualStyleBackColor = false;
            this.BTNname.Click += new System.EventHandler(this.BTNname_Click);
            // 
            // PBname
            // 
            this.PBname.BackColor = System.Drawing.Color.LightSlateGray;
            this.PBname.Location = new System.Drawing.Point(12, 218);
            this.PBname.Name = "PBname";
            this.PBname.Size = new System.Drawing.Size(335, 317);
            this.PBname.TabIndex = 2;
            this.PBname.TabStop = false;
            this.PBname.Visible = false;
            // 
            // GBkillers
            // 
            this.GBkillers.BackColor = System.Drawing.Color.LightSlateGray;
            this.GBkillers.Controls.Add(this.CBBelle);
            this.GBkillers.Controls.Add(this.CBHolmes);
            this.GBkillers.Controls.Add(this.CBRobert);
            this.GBkillers.Controls.Add(this.CBRichard);
            this.GBkillers.Controls.Add(this.CBJohn);
            this.GBkillers.Controls.Add(this.CBJack);
            this.GBkillers.Controls.Add(this.CBTed);
            this.GBkillers.Controls.Add(this.BTNsubmit);
            this.GBkillers.Controls.Add(this.CBJeff);
            this.GBkillers.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBkillers.Location = new System.Drawing.Point(507, 362);
            this.GBkillers.Name = "GBkillers";
            this.GBkillers.Size = new System.Drawing.Size(175, 294);
            this.GBkillers.TabIndex = 3;
            this.GBkillers.TabStop = false;
            this.GBkillers.Text = "Favorite Killers?";
            // 
            // BTNsubmit
            // 
            this.BTNsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNsubmit.Location = new System.Drawing.Point(86, 264);
            this.BTNsubmit.Name = "BTNsubmit";
            this.BTNsubmit.Size = new System.Drawing.Size(83, 24);
            this.BTNsubmit.TabIndex = 1;
            this.BTNsubmit.Text = "Submit";
            this.BTNsubmit.UseVisualStyleBackColor = true;
            this.BTNsubmit.Click += new System.EventHandler(this.BTNsubmit_Click);
            // 
            // CBJeff
            // 
            this.CBJeff.AutoSize = true;
            this.CBJeff.Location = new System.Drawing.Point(6, 33);
            this.CBJeff.Name = "CBJeff";
            this.CBJeff.Size = new System.Drawing.Size(128, 22);
            this.CBJeff.TabIndex = 0;
            this.CBJeff.Text = "Jeffrey Dahmer";
            this.CBJeff.UseVisualStyleBackColor = true;
            // 
            // CBTed
            // 
            this.CBTed.AutoSize = true;
            this.CBTed.Location = new System.Drawing.Point(6, 62);
            this.CBTed.Name = "CBTed";
            this.CBTed.Size = new System.Drawing.Size(99, 22);
            this.CBTed.TabIndex = 2;
            this.CBTed.Text = "Ted Bundy";
            this.CBTed.UseVisualStyleBackColor = true;
            // 
            // CBJack
            // 
            this.CBJack.AutoSize = true;
            this.CBJack.Location = new System.Drawing.Point(6, 91);
            this.CBJack.Name = "CBJack";
            this.CBJack.Size = new System.Drawing.Size(129, 22);
            this.CBJack.TabIndex = 3;
            this.CBJack.Text = "Jack the Ripper";
            this.CBJack.UseVisualStyleBackColor = true;
            // 
            // CBJohn
            // 
            this.CBJohn.AutoSize = true;
            this.CBJohn.Location = new System.Drawing.Point(6, 120);
            this.CBJohn.Name = "CBJohn";
            this.CBJohn.Size = new System.Drawing.Size(144, 22);
            this.CBJohn.TabIndex = 4;
            this.CBJohn.Text = "John Wayne Gacy";
            this.CBJohn.UseVisualStyleBackColor = true;
            // 
            // CBRichard
            // 
            this.CBRichard.AutoSize = true;
            this.CBRichard.Location = new System.Drawing.Point(6, 149);
            this.CBRichard.Name = "CBRichard";
            this.CBRichard.Size = new System.Drawing.Size(138, 22);
            this.CBRichard.TabIndex = 5;
            this.CBRichard.Text = "Richard Ramirez";
            this.CBRichard.UseVisualStyleBackColor = true;
            // 
            // CBRobert
            // 
            this.CBRobert.AutoSize = true;
            this.CBRobert.Location = new System.Drawing.Point(6, 178);
            this.CBRobert.Name = "CBRobert";
            this.CBRobert.Size = new System.Drawing.Size(125, 22);
            this.CBRobert.TabIndex = 6;
            this.CBRobert.Text = "Robert Hansen";
            this.CBRobert.UseVisualStyleBackColor = true;
            // 
            // CBHolmes
            // 
            this.CBHolmes.AutoSize = true;
            this.CBHolmes.Location = new System.Drawing.Point(6, 207);
            this.CBHolmes.Name = "CBHolmes";
            this.CBHolmes.Size = new System.Drawing.Size(115, 22);
            this.CBHolmes.TabIndex = 7;
            this.CBHolmes.Text = "H.H. Holmes";
            this.CBHolmes.UseVisualStyleBackColor = true;
            // 
            // CBBelle
            // 
            this.CBBelle.AutoSize = true;
            this.CBBelle.Location = new System.Drawing.Point(6, 236);
            this.CBBelle.Name = "CBBelle";
            this.CBBelle.Size = new System.Drawing.Size(120, 22);
            this.CBBelle.TabIndex = 8;
            this.CBBelle.Text = "Belle Gunness";
            this.CBBelle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(939, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ready to be scared?";
            // 
            // PBscare
            // 
            this.PBscare.BackColor = System.Drawing.Color.Maroon;
            this.PBscare.Location = new System.Drawing.Point(902, 256);
            this.PBscare.Name = "PBscare";
            this.PBscare.Size = new System.Drawing.Size(231, 23);
            this.PBscare.TabIndex = 5;
            this.PBscare.UseWaitCursor = true;
            // 
            // BTNscare
            // 
            this.BTNscare.BackColor = System.Drawing.Color.Silver;
            this.BTNscare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNscare.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNscare.Location = new System.Drawing.Point(982, 294);
            this.BTNscare.Name = "BTNscare";
            this.BTNscare.Size = new System.Drawing.Size(88, 35);
            this.BTNscare.TabIndex = 6;
            this.BTNscare.Text = "Click me!";
            this.BTNscare.UseVisualStyleBackColor = false;
            this.BTNscare.Click += new System.EventHandler(this.BTNscare_Click);
            // 
            // PicBoxScare
            // 
            this.PicBoxScare.Location = new System.Drawing.Point(1032, 346);
            this.PicBoxScare.Name = "PicBoxScare";
            this.PicBoxScare.Size = new System.Drawing.Size(220, 200);
            this.PicBoxScare.TabIndex = 7;
            this.PicBoxScare.TabStop = false;
            this.PicBoxScare.Visible = false;
            // 
            // indexHorror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1389, 706);
            this.Controls.Add(this.PicBoxScare);
            this.Controls.Add(this.BTNscare);
            this.Controls.Add(this.PBscare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GBkillers);
            this.Controls.Add(this.PBname);
            this.Controls.Add(this.BTNname);
            this.Controls.Add(this.TBname);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "indexHorror";
            this.Text = "Answer if you dare...";
            this.Load += new System.EventHandler(this.indexHorror_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBname)).EndInit();
            this.GBkillers.ResumeLayout(false);
            this.GBkillers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxScare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Button BTNname;
        private System.Windows.Forms.PictureBox PBname;
        private System.Windows.Forms.GroupBox GBkillers;
        private System.Windows.Forms.CheckBox CBJeff;
        private System.Windows.Forms.Button BTNsubmit;
        private System.Windows.Forms.CheckBox CBBelle;
        private System.Windows.Forms.CheckBox CBHolmes;
        private System.Windows.Forms.CheckBox CBRobert;
        private System.Windows.Forms.CheckBox CBRichard;
        private System.Windows.Forms.CheckBox CBJohn;
        private System.Windows.Forms.CheckBox CBJack;
        private System.Windows.Forms.CheckBox CBTed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PBscare;
        private System.Windows.Forms.Button BTNscare;
        private System.Windows.Forms.PictureBox PicBoxScare;
    }
}

