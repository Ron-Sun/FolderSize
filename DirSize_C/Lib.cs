
namespace DirSize_C
{
    class Lib
    {
        // Zero based... 
        public string Left(string s, int pos)
        {
            return s.Substring(0, pos);
        }

        public string Right(string s, int pos)
        {
            return s.Substring(s.Length - pos, pos);
        }

        public string Mid(string s, int pos, int len)
        {
             return s.Substring(pos, len);
        }

        public string MidReplace(string ins, string s, int pos)
        {
            string l = Left(s, pos);
            string r = Right(s, s.Length - pos);
            s = l + ins + r;

            return s;
        }
    }
}

//
//  Quick reminder.
//  char
// '\n' = vbLf      Linefeed
// '\r' = vbCr      Carrige return
// '\t' = vbTab     Tab
// '\e' = vbEsc     Esc
//
//  string
// "\n" = vbLf      Linefeed
// "\r" = vbCr      Carrige return
// "\t" = vbTab     Tab
// "\e" = vbEsc     Esc
//