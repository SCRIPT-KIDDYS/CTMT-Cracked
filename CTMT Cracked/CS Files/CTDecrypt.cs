using System;
using System.IO;
using System.Linq;
using System.Text;

class CTDecrypt
    {
    
    public static string SavedLocation;

    public static int CaesarIntt;

    public static void DecryptStuff(string Fluffy, string GameName, string AESPassword, int CaesarInt, string SaveLocation)
    {
        SavedLocation = SaveLocation;
        CaesarIntt = CaesarInt;
        if (Fluffy.Length < 7) { SaveFiles("He didnt upload codes for this game", GameName); }
        else
        {
            string DecryptString = AES_Encryption.Decrypt(Fluffy, AESPassword);
            if (DecryptString.StartsWith("Y"))
            {
                string ReformatString = "N" + DecryptString.Substring(DecryptString.IndexOf('@') + 2);
                string Date = ReformatString.Split('N', '@')[1];
                string Decoded = ReformatString.Replace("@@", ",");
                StringFormat(Decoded, Date, GameName);
            }
            else
            {
                string ReformatString = DecryptString.Substring(1);
                string Date = ReformatString.Split('N', '@')[0];
                string Decoded = DecryptString.Replace("@@", ",");
                StringFormat(Decoded, Date, GameName);
            }
        }
    }

    public static void StringFormat(string Decoded, string Date, string GameName)
    {
        string Final = "";
        string CharKeyDecodes = Caesar_Cipher.CharKey(Decoded, CaesarIntt);
        string[] StringArray = new string[] { "" };
        StringArray = CharKeyDecodes.Split(',');
        StringArray = StringArray.Skip(1).ToArray();
        string[] StringArrayResults = StringArray.Select(y => string.Concat(y.Reverse())).ToArray();
        string GameNameAndDate = GameName + " - " + Date + Environment.NewLine + Environment.NewLine;

        foreach (var Item in StringArrayResults)
        {
            byte[] Data = Convert.FromBase64String(Item);
            Final += Encoding.UTF8.GetString(Data) + Environment.NewLine;
        }
        SaveFiles(GameNameAndDate + Final, GameName);
    }

    public static void SaveFiles(string FinalInfo, string GameName)
    {
        StreamWriter File = new StreamWriter(SavedLocation + @"\" + GameName + ".txt");
        File.WriteLine(FinalInfo);
        File.Close();
    }
}

