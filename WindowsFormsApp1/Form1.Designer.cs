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
            this.CBJeff = new System.Windows.Forms.CheckBox();
            this.BTNsubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBname)).BeginInit();
            this.GBkillers.SuspendLayout();
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
            this.GBkillers.Controls.Add(this.BTNsubmit);
            this.GBkillers.Controls.Add(this.CBJeff);
            this.GBkillers.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBkillers.Location = new System.Drawing.Point(498, 12);
            this.GBkillers.Name = "GBkillers";
            this.GBkillers.Size = new System.Drawing.Size(175, 294);
            this.GBkillers.TabIndex = 3;
            this.GBkillers.TabStop = false;
            this.GBkillers.Text = "Favorite Killers?";
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
            // BTNsubmit
            // 
            this.BTNsubmit.Location = new System.Drawing.Point(94, 265);
            this.BTNsubmit.Name = "BTNsubmit";
            this.BTNsubmit.Size = new System.Drawing.Size(75, 23);
            this.BTNsubmit.TabIndex = 1;
            this.BTNsubmit.Text = "Submit";
            this.BTNsubmit.UseVisualStyleBackColor = true;
            // 
            // indexHorror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1389, 706);
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
    }
}

