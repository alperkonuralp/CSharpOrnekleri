using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DersDemo_CS_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Merhaba," + "Dünya " +
                "Bu bir " + "Denemedir"; // 7 ayrı nesne olur

            string s2 = string.Concat("Merhaba,", "Dünya ",
                "Bu bir ", "Denemedir"); // 5 ayrı nesne olur

            string s3 = string.Format("{0}{1}{2}{3}",
               "Merhaba,", "Dünya ",
                "Bu bir ", "DenemediR"); // 6 ayrı nesne olur.

            StringBuilder sb =
                new StringBuilder("Merhaba,");

            sb.Append("Dünya ");
            sb.Append("Bu bir ");
            sb.Append("Denemedir");

            string s4 = sb.ToString();

            Console.WriteLine(s1);
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s1.ToUpper(new CultureInfo("en-us")));

            string s5 = "       Yazi     ";
            Console.WriteLine("|{0}|", s5);
            Console.WriteLine("|{0}|", s5.Trim());
            Console.WriteLine("|{0}|", s5.TrimStart());
            Console.WriteLine("|{0}|", s5.TrimEnd());

            string[] iller = { "İzmir", "İstanbul", "Ankara" };

            Console.WriteLine("{0}, {1}, {2}", iller);
            Console.WriteLine(string.Join(", ", iller));

            Console.WriteLine("<option>{0}</option>",
                string.Join("</option>\n<option>", iller));

            Console.WriteLine(s1.Length);

            Console.WriteLine(s1.IndexOf("ir"));
            Console.WriteLine(s1.LastIndexOf("ir"));
            Console.WriteLine(s1.IndexOf("ir", 20));
            Console.WriteLine(s1.IndexOfAny(new char[2] { 'i', 'r' }));

            string s6 = (string)s1.Clone();

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));

            Console.WriteLine();

            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1.Equals(s3));


            Console.WriteLine();

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s1, s3));
            Console.WriteLine(string.Compare(s1, s3, true));
        }
    }
}
