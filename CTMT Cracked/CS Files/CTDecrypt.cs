﻿#region USINGS
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
#endregion

class CTDecrypt
    {
    
    #region Static Info
    public static string fukme = "";
    #endregion

    #region AES Decrypt
    public static string Decrypt(string cipherText)
    {
        string EncryptionKey = "ICamYEloBquEntR";
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x48, 0x39, 0x01, 0x19, 0x28, 0x4D, 0xE2, 0x94, 0xD2, 0x33, 0x84, 0x69, 0x0A });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    try
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    catch { }
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }
    #endregion

    #region String Crap, Kinda bad coding sorry
    public static void stringthing(string lala, string date, string gamename)
    {
        string final = "";
        string poop = CharKey(lala);
        string strOne = poop;
        string[] strArrayOne = new string[] { "" };
        strArrayOne = strOne.Split(',');
        strArrayOne = strArrayOne.Skip(1).ToArray();
        string[] strResult = strArrayOne.Select(y => string.Concat(y.Reverse())).ToArray();
        string dateandstuff = gamename + " - " + date + Environment.NewLine;

        foreach (var items in strResult)
        {
            byte[] data = Convert.FromBase64String(items);
            final += Encoding.UTF8.GetString(data) + Environment.NewLine;
        }
        savemeplease(dateandstuff + final, gamename);
    }
    #endregion

    #region Save to file
    public static void savemeplease(string finalinfo, string gamename)
    {
        StreamWriter file = new System.IO.StreamWriter(@fukme + @"\" + gamename + ".txt");
        file.WriteLine(finalinfo);
        file.Close();
    }
    #endregion

    #region PreDecryption
    public static void DecryptStuff(string fluffy, string gamename, string fukmee)
    {
        fukme = fukmee;
        if (fluffy == "@@" || fluffy == "") { }
        else
        {
            string DecryptString = Decrypt(fluffy);
            if (DecryptString.StartsWith("Y"))
            {
                string letsrockandroll = "N" + DecryptString.Substring(DecryptString.IndexOf('@') + 2);
                string Date = letsrockandroll.Split('N', '@')[1];
                string Decoded = letsrockandroll.Replace("@@", ",");
                stringthing(Decoded, Date, gamename);
            }
            else
            {
                string letsrockandroll = DecryptString.Substring(1);
                string Date = letsrockandroll.Split('N', '@')[0];
                string Decoded = DecryptString.Replace("@@", ",");
                stringthing(Decoded, Date, gamename);
            }
        }
    }
    #endregion

    #region CharKey (Copy Paste)
    public static string CharKey(string line)
    {
        string result = "";
        string s = line;
        foreach (char c in s)
        {
            result += (LettersandStuff(18, c));
        }
        return result;
    }

    static char LettersandStuff(int int_0, char stringey)
    {
        char result;
        if (!char.IsLetter(stringey))
        {
            result = stringey;
        }
        else
        {
            char c = char.IsUpper(stringey) ? 'A' : 'a';
            result = (char)(((int)stringey + int_0 - (int)c) % 26 + (int)c);
        }
        return result;
    }
    #endregion
}

