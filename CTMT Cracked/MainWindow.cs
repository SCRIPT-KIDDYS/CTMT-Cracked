#region Using
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
#endregion

namespace CTMT_Cracked
{
    public partial class MainWindow : Form
    {
        #region Static Items
        public string savelocation;
        private string tempf;
        private SoundPlayer whine;
        private SoundPlayer puntch;
        private SoundPlayer wolf;
        #endregion

        #region Constructors
        public MainWindow()
        {
            InitializeComponent();
            whine = new SoundPlayer(Properties.Resources.Whine);
            puntch = new SoundPlayer(Properties.Resources.Punch);
            wolf = new SoundPlayer(Properties.Resources.Wolf);
        }
        #endregion

        #region Move Form Function

        #region Move On MouseDown DLL Imports
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region MouseDown
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #endregion

        #region On Form Load
        private void Form2_Load(object sender, EventArgs e)
        {
            home.Show();
            homecrack.Hide();
            label1.Parent = home;
            label1.BackColor = Color.Transparent;
            pictureBox2.Parent = home;
            pictureBox2.BackColor = Color.Transparent;
        }
        #endregion

        #region CloseProgram
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < 600)
            {
                label1.Left = label1.Left + 2;
            }
            else
            {
                label1.Left = -label1.Width;
            }
        }
        #endregion

        #region timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Left < -100)
            {
                label1.Left = label1.Left + 600;
            }
            else
            {
                label1.Left -= 2;
            }

        }
        #endregion

        #region Dialog Window
        public void dialoganswer()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                puntch.Play();
                homecrack.Show();
                home.Hide();
                label1.Parent = homecrack;
                label1.BackColor = Color.Transparent;
                whine.Play();
                backgroundWorker1.RunWorkerAsync();
            }
        }
        #endregion

        #region HTTP Request
        public void Httpstuffiguess(string fukmee)
        {

            String downloadthing = "http://cyberterminators.co/details.xml";

            XmlDocument doc1 = new XmlDocument();
            doc1.Load(downloadthing);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("/megaT/HackList");
            foreach (XmlNode node in nodes)
                tempf = node.InnerText.ToLower();

            foreach (string name in tempf.Split(','))
            {
                    string nameogameo = name.TrimStart('\n');
                    string iguessthiswillwork = nameogameo.Replace(" ", "%20");
                    WebClient client = new WebClient();
                    String downloadedString = client.DownloadString("http://www.cyberterminators.co/ctmt-v2/getDetails.php?gameName=" + iguessthiswillwork);
                    CTDecrypt.DecryptStuff(downloadedString, nameogameo, fukmee);
            }
            

        }
        #endregion

        #region Message Box
        public void Dostufflilhomie()
        {
            DialogResult result = MessageBox.Show("This will spit out a bunch of .txt files." + Environment.NewLine + "So put it in a folder not on ur desktop silly ;)", "WaRnInG!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                dialoganswer();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Really? You clicked cancel? \nDon't you wanna steal some codes tho?");
            }
        }
        #endregion

        #region BG Worker

        #region DO WORK
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Httpstuffiguess(folderBrowserDialog1.SelectedPath);
        }
        #endregion

        #region WORK DONE
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Shit done yo!");
        }
        #endregion

        #endregion

        #region Activate Code
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dostufflilhomie();
        }
        #endregion
    }
}
