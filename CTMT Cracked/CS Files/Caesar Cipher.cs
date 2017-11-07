using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Caesar_Cipher
{
    public static string CharKey(string Line, int CipherIntt)
    {
        string output = null;
        foreach (char Letter in Line)
        {
            output += Cipher(CipherIntt, Letter);
        }
        return output;
    }

    static char Cipher(int Number, char Letter)
    {
        if (!char.IsLetter(Letter))
        {
            return Letter;
        }
        char Decode = char.IsUpper(Letter) ? 'A' : 'a';
        return (char)((((Letter + Number) - Decode) % 26) + Decode);
    }
}

