#region Using
using System;
using System.Media;
using System.Windows.Forms;
#endregion

namespace CTMT_Cracked
{
    public partial class SplashScreen : Form
    {
        #region Static Items
        private SoundPlayer WolfNoise = new SoundPlayer(Properties.Resources.Wolf);

        MainWindow MainWindow = new MainWindow();

        int count = 0;
        #endregion

        #region SplashSource
        public SplashScreen()
        {
            InitializeComponent();
            Loading_Timer.Start();
        }
        #endregion

        #region FormLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            WolfNoise.Play();
        }
        #endregion

        #region Loading Splash Timer
        private void Loading_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                LoadingCracked_Timer.Start();
                Loading_Timer.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.03;
            }
        }
        #endregion

        #region Loading Cracked Splash Timer
        private void LoadingCracked_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                LoadingCracked_Timer.Stop();
                MainWindow.Show();
            }
            else
            {
                Loading_Picture.Hide();
                LoadingCracked_Picture.Show();
                count--;
                Opacity = count * .03;
            }
        }
        #endregion
    }
}