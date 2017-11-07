using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CTMT_Cracked
{
    public partial class MainWindow : Form
    {
        public string savelocation;
        private SoundPlayer Whine = new SoundPlayer(Properties.Resources.Whine);
        private SoundPlayer Punch = new SoundPlayer(Properties.Resources.Punch);

        // Change If The Password / Int Change
        string AESPassword = "ICamYEloBquEntR";
        int CaesarInt = 18;

        public MainWindow()
        {
            InitializeComponent();
            Bottom_Text.Parent = HomeScreen;
            EnableCrackButton.Parent = HomeScreen;
        }

        // Move Form on Mouse Down
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void DialogResults()
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Punch.Play();
                HomeScreenCracked.Show();
                Bottom_Text.Parent = HomeScreenCracked;
                Whine.Play();
                DecryptCodes_BW.RunWorkerAsync();
            }
        }

        public void HTTPRequests(string SaveLocation)
        {
            string[] GameList = { "8 Ball Pool", "Angry Birds Friends", "Army Force Firestorm", "Baby Blocks", "Backyard Monsters", "Bakery Blitz", "Battle Of Gods 3D", "Begone", "Begone Warland 2", "Best Friends", "Big Business Deluxe", "Bingo Bash", "Bingo Blitz", "Blood Oil Gold", "Bloodstrike", "Bubble CoCo", "Buggle", "CSI Hidden Images", "Cafeland", "Cake Story", "Castle Clash", "Clash Of War", "Clicker Heroes", "Clockmaker", "Cloudstone", "Contract Wars", "Cookie Jam Blast", "Cookie Jam", "Cooking Tale", "Cower Defense", "Criminal Case", "Criminal Case Pacific Bay", "Criminal Case Save The World", "Crusaders of Lost Idols", "Cutie Monsters Battle Arena", "Dead Route", "Deer Hunter 2017", "Detective Stories", "Diamond Dash", "Diamond Digger Saga", "Diner Life", "Disco Ducks", "Dragon Lords", "Dungeon Blitz", "Earn 2 Die Exodus", "Family House", "Farmville 2", "Fashland", "First Blood", "Fishing World", "Forces Conquer Online", "Funky Bay", "Galaxy Control 3D", "Gardenscapes", "Global Strike", "Gunslingers", "Headshot", "Heroes Of Paragon", "Hockey Stars", "Hunger Cops", "Hunters League", "Into The Dead", "Jelly Splash", "Kingdom Glory", "Kingsroad", "Kitchen Scramble", "Knights Clash Of Heroes", "Magetale", "Mahjong Trails", "Marketland", "Might and Mayhem", "Monkey Tower", "Monster Busters", "Monster Busters Hexa Blast", "Monster Busters Ice Slide", "Monster Busters Link Flash", "My Kitchen", "Ninja Saga", "One Piece Tower Defense", "Oz Broken Empire", "Paint Monsters", "Plazma Burst 2", "Pool Live Pro", "Prize Fiesta", "Project Warfare", "Ragdoll Achievement 2", "Red Crucible Firestorm", "Red Crucible Reloaded", "Rule The kingdom", "Sandstorm Pirate Wars", "Sea Fishing", "Shadow Fight", "Snooker Live Pro", "Snooker World", "Soccer Stars", "Stage Dive Legends", "Star Battleships", "Star Wars Commander", "Stick Run", "Storm Of Wars", "StreetRace Rivals", "StreetRace Rivals 2", "Sugar Smash Book Of Life", "Super Party Sports Football", "Sweet Road", "TDP4 Team Battle", "Tap Adventure Time Travel", "Tetris Battle", "The Fishing Club 3D", "The Last One", "The Tribez", "Titans", "Toy Blast", "Toy Defense", "Toy Defense 2", "Tribez And Castlez", "Trop World Casino", "Vikings Gone Wild", "Warhammer 40000 Freeblade", "Word Connect", "Words Of Wonder", "Zombie Blitz", "Zootopia Crime Files" };
            WebClient Client = new WebClient();
            foreach (string Name in GameList)
            {
                string GameName = Name;
                string HTTPFormat = GameName.Replace(" ", "%20");
                String DownloadedString = Client.DownloadString("http://www.cyberterminators.co/ctmt-v2/getDetails.php?gameName=" + HTTPFormat);
                CTDecrypt.DecryptStuff(DownloadedString, GameName, AESPassword, CaesarInt, SaveLocation);
            }
            Client.Dispose();
        }

        public void MessageBoxDialog()
        {
            DialogResult result = MessageBox.Show("This will spit out a bunch of .txt files." + Environment.NewLine + "So put it in a folder not on ur desktop silly ;)", "WaRnInG!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DialogResults();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Really? You clicked cancel? \nDon't you wanna steal some codes tho?");
            }
        }

        private void TextScroll_Timer_Tick(object sender, EventArgs e)
        {
            if (Bottom_Text.Left < 600)
            {
                Bottom_Text.Left = Bottom_Text.Left + 2;
            }
            else
            {
                Bottom_Text.Left = -Bottom_Text.Width;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnableCrackButton_Click(object sender, EventArgs e)
        {
            MessageBoxDialog();
        }

        private void DecryptCodes_BW_DoWork(object sender, DoWorkEventArgs e)
        {
            HTTPRequests(FolderBrowserDialog.SelectedPath);
        }

        private void DecryptCodes_BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Shit done yo!");
        }
    }
}
