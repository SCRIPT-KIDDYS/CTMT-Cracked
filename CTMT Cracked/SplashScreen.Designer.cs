namespace CTMT_Cracked
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.Loading_Timer = new System.Windows.Forms.Timer(this.components);
            this.LoadingCracked_Timer = new System.Windows.Forms.Timer(this.components);
            this.Loading_Picture = new System.Windows.Forms.PictureBox();
            this.LoadingCracked_Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingCracked_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Loading_Timer
            // 
            this.Loading_Timer.Tick += new System.EventHandler(this.Loading_Timer_Tick);
            // 
            // LoadingCracked_Timer
            // 
            this.LoadingCracked_Timer.Tick += new System.EventHandler(this.LoadingCracked_Timer_Tick);
            // 
            // Loading_Picture
            // 
            this.Loading_Picture.Image = global::CTMT_Cracked.Properties.Resources.Loading;
            this.Loading_Picture.Location = new System.Drawing.Point(0, 0);
            this.Loading_Picture.Name = "Loading_Picture";
            this.Loading_Picture.Size = new System.Drawing.Size(556, 236);
            this.Loading_Picture.TabIndex = 0;
            this.Loading_Picture.TabStop = false;
            // 
            // LoadingCracked_Picture
            // 
            this.LoadingCracked_Picture.Image = global::CTMT_Cracked.Properties.Resources.LoadingCracked;
            this.LoadingCracked_Picture.Location = new System.Drawing.Point(0, 0);
            this.LoadingCracked_Picture.Name = "LoadingCracked_Picture";
            this.LoadingCracked_Picture.Size = new System.Drawing.Size(556, 236);
            this.LoadingCracked_Picture.TabIndex = 1;
            this.LoadingCracked_Picture.TabStop = false;
            this.LoadingCracked_Picture.Visible = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 231);
            this.Controls.Add(this.LoadingCracked_Picture);
            this.Controls.Add(this.Loading_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingCracked_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Loading_Timer;
        private System.Windows.Forms.Timer LoadingCracked_Timer;
        private System.Windows.Forms.PictureBox Loading_Picture;
        private System.Windows.Forms.PictureBox LoadingCracked_Picture;
    }
}

