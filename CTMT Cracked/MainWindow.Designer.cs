namespace CTMT_Cracked
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.HomeScreen = new System.Windows.Forms.PictureBox();
            this.HomeScreenCracked = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.TextScroll_Timer = new System.Windows.Forms.Timer(this.components);
            this.Bottom_Text = new System.Windows.Forms.Label();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.DecryptCodes_BW = new System.ComponentModel.BackgroundWorker();
            this.EnableCrackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreenCracked)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnableCrackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeScreen
            // 
            this.HomeScreen.Image = global::CTMT_Cracked.Properties.Resources.HomeScreen;
            this.HomeScreen.Location = new System.Drawing.Point(0, 32);
            this.HomeScreen.Name = "HomeScreen";
            this.HomeScreen.Size = new System.Drawing.Size(585, 213);
            this.HomeScreen.TabIndex = 2;
            this.HomeScreen.TabStop = false;
            // 
            // HomeScreenCracked
            // 
            this.HomeScreenCracked.BackColor = System.Drawing.Color.Transparent;
            this.HomeScreenCracked.Image = global::CTMT_Cracked.Properties.Resources.HomeScreenCracked;
            this.HomeScreenCracked.Location = new System.Drawing.Point(0, 32);
            this.HomeScreenCracked.Name = "HomeScreenCracked";
            this.HomeScreenCracked.Size = new System.Drawing.Size(585, 213);
            this.HomeScreenCracked.TabIndex = 3;
            this.HomeScreenCracked.TabStop = false;
            this.HomeScreenCracked.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 32);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(541, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 26);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TextScroll_Timer
            // 
            this.TextScroll_Timer.Enabled = true;
            this.TextScroll_Timer.Interval = 1;
            this.TextScroll_Timer.Tick += new System.EventHandler(this.TextScroll_Timer_Tick);
            // 
            // Bottom_Text
            // 
            this.Bottom_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bottom_Text.AutoSize = true;
            this.Bottom_Text.BackColor = System.Drawing.Color.Transparent;
            this.Bottom_Text.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bottom_Text.ForeColor = System.Drawing.Color.DarkRed;
            this.Bottom_Text.Location = new System.Drawing.Point(5, 194);
            this.Bottom_Text.Name = "Bottom_Text";
            this.Bottom_Text.Size = new System.Drawing.Size(190, 20);
            this.Bottom_Text.TabIndex = 5;
            this.Bottom_Text.Text = "Cracked By: SCRIPT KIDDIES";
            this.Bottom_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecryptCodes_BW
            // 
            this.DecryptCodes_BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DecryptCodes_BW_DoWork);
            this.DecryptCodes_BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DecryptCodes_BW_RunWorkerCompleted);
            // 
            // EnableCrackButton
            // 
            this.EnableCrackButton.BackColor = System.Drawing.Color.Transparent;
            this.EnableCrackButton.Location = new System.Drawing.Point(210, 118);
            this.EnableCrackButton.Name = "EnableCrackButton";
            this.EnableCrackButton.Size = new System.Drawing.Size(153, 114);
            this.EnableCrackButton.TabIndex = 6;
            this.EnableCrackButton.TabStop = false;
            this.EnableCrackButton.Click += new System.EventHandler(this.EnableCrackButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 244);
            this.Controls.Add(this.Bottom_Text);
            this.Controls.Add(this.EnableCrackButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HomeScreenCracked);
            this.Controls.Add(this.HomeScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreenCracked)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnableCrackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox HomeScreen;
        private System.Windows.Forms.PictureBox HomeScreenCracked;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Timer TextScroll_Timer;
        private System.Windows.Forms.Label Bottom_Text;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.ComponentModel.BackgroundWorker DecryptCodes_BW;
        private System.Windows.Forms.PictureBox EnableCrackButton;
    }
}