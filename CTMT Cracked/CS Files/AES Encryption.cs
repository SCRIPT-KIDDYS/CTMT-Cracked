using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class AES_Encryption
{
    public static string Decrypt(string cipherText, string Password)
    {
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Password, new byte[] 
            {
                0x48,
                0x39,
                0x01,
                0x19,
                0x28,
                0x4D,
                0xE2,
                0x94,
                0xD2,
                0x33,
                0x84,
                0x69,
                0x0A
            });

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
}

