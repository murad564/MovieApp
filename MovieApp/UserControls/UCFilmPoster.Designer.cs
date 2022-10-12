namespace MoviesApp.UserControls
{
    partial class UCFilmPoster
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_poster = new System.Windows.Forms.Panel();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pbox_poster = new System.Windows.Forms.PictureBox();
            this.pnl_poster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_poster
            // 
            this.pnl_poster.Controls.Add(this.lbl_year);
            this.pnl_poster.Controls.Add(this.lbl_title);
            this.pnl_poster.Controls.Add(this.pbox_poster);
            this.pnl_poster.Location = new System.Drawing.Point(3, 3);
            this.pnl_poster.Name = "pnl_poster";
            this.pnl_poster.Size = new System.Drawing.Size(273, 371);
            this.pnl_poster.TabIndex = 2;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(14, 324);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(38, 15);
            this.lbl_year.TabIndex = 1;
            this.lbl_year.Text = "label1";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(14, 339);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(52, 21);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "label1";
            // 
            // pbox_poster
            // 
            this.pbox_poster.Location = new System.Drawing.Point(3, 3);
            this.pbox_poster.Name = "pbox_poster";
            this.pbox_poster.Size = new System.Drawing.Size(270, 365);
            this.pbox_poster.TabIndex = 2;
            this.pbox_poster.TabStop = false;
            this.pbox_poster.Click += new System.EventHandler(this.pbox_poster_Click);
            // 
            // UCFilmPoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_poster);
            this.Name = "UCFilmPoster";
            this.Size = new System.Drawing.Size(279, 377);
            this.pnl_poster.ResumeLayout(false);
            this.pnl_poster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnl_poster;
        private Label lbl_year;
        private Label lbl_title;
        public PictureBox pbox_poster;
    }
}