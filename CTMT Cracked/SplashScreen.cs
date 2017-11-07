#region Using
using System;
using System.Media;
using System.Windows.Forms;
#endregion

namespace CTMT_Cracked
{
    public partial class SplashScreen : Form
    {
        private SoundPlayer Wolf = new SoundPlayer(Properties.Resources.Wolf);

        MainWindow MainWindow = new MainWindow();

        int count = 0;

        public SplashScreen()
        {
            InitializeComponent();
            Loading_Timer.Start();
            Wolf.Play();
        }

        private void Loading_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                Loading_Timer.Stop();
                LoadingCracked_Timer.Start();
                Loading_Picture.Hide();
                LoadingCracked_Picture.Show();
            }
            else
            {
                count++;
                Opacity = count * 0.03;
            }
        }

        private void LoadingCracked_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                LoadingCracked_Timer.Stop();
                Program.SplashScreenClosed = true;
                Close();
            }
            else
            {
                count--;
                Opacity = count * .03;
            }
        }
    }
}