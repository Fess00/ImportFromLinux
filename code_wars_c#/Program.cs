using System.Net.Http;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace code_wars_c_
{
    class Program
    {
        public static string Rot13(string message)
        {
            var alphabet = new Dictionary<int, string>()
            {
                {1, "a"}, {2, "b"}, {3, "c"}, {4, "d"}, {5, "e"}, {6, "f"}, {7, "g"},
                {8, "h"}, {9, "i"}, {10, "j"}, {11, "k"}, {12, "l"}, {13, "m"}, {14, "n"},
                {15, "o"}, {16, "p"}, {17, "q"}, {18, "r"}, {19, "s"}, {20, "t"},
                {21, "u"}, {22, "v"}, {23, "w"}, {24, "x"}, {25, "y"}, {26, "z"}
            };
            string alph = "abcdefghijklmnopqrstuvwxyz";
            int index = 0;
            int indexRot = 0;
            char[] messageArray = message.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                index = alph.IndexOf(message[i].ToString().ToLower(), 0, alph.Length);
                if (index == -1)
                {
                    continue;
                }
                index += 1;
                indexRot = index - 13;
                if(indexRot <= 0)
                {
                    indexRot = 26 + indexRot;
                }
                messageArray[i] = message[i].ToString() == message[i].ToString().ToUpper() 
                ? Convert.ToChar(alphabet[indexRot].ToString().ToUpper()) 
                : Convert.ToChar(alphabet[indexRot]);
            }
            message = "";

            for (int i = 0; i < messageArray.Length; i++)
            {
                message += messageArray[i].ToString();
            }

            return message;
        }

        public static bool is_valid_IP(string ipAddres)
        {
            Regex reg = new Regex("[^0-9.]");
            MatchCollection match = reg.Matches(ipAddres);
            if (match.Count > 0)
                return false;

            int count = 0;
            foreach (char point in ipAddres)
            {
                if (point == '.')
                {
                    ++count;
                }
            }

            if (count > 3 || count < 3)
            {
                return false;
            }

            string tmp = "";
            int check = 0;

            foreach (char iter in ipAddres)
            {
                if (tmp.Length > 1)
                {
                    if (tmp[0] == '0')
                        return false;
                }

                if (iter == '.')
                {
                    if (tmp == "")
                        return false;
                    if (tmp.Length > 1)
                    {
                        if (tmp[0] == '0')
                            return false;
                    }
                    check = Int32.Parse(tmp);
                    if (check > 255 || check < 0)
                    {
                        return false;
                    }
                    tmp = "";
                } 
                else 
                {
                    tmp += Char.ToString(iter);
                }
            }

            if (tmp == "")
                return false;
            check = Int32.Parse(tmp);
            if (tmp.Length > 1)
                {
                    if (tmp[0] == '0')
                        return false;
                }
            if (check > 255 || check < 0)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(is_valid_IP("0.0.0.03"));
        }
    }
}
