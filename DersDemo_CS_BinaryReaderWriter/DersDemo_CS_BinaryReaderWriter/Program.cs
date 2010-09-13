using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DersDemo_CS_BinaryReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteFile();
            ReadFile();
        }

        public static List<TelefonRehberi> rehber =
            new List<TelefonRehberi>();

        static Program()
        {
            rehber.Add(
                new TelefonRehberi(
                    0, "Kemal", "Sunal", 5053366991));

            rehber.Add(
                new TelefonRehberi(
                    1, "Adile", "Naşit", 5056699111));

            rehber.Add(
                new TelefonRehberi(
                    2, "Kenan", "Kartal", 5059911559));

            rehber.Add(
                new TelefonRehberi(
                    3, "Müjdat", "Gezen", 5051155991));
        }

        public static void WriteFile()
        {
            using (FileStream fs = new FileStream(
                "c:\\ara\\Rehber.dat",
                FileMode.Create,
                FileAccess.Write,
                FileShare.None))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                foreach (TelefonRehberi item in rehber)
                {
                    bw.Write(item.No);
                    bw.Write(item.Ad);
                    bw.Write(item.Soyad);
                    bw.Write(item.TelefonNo);
                }
            }
        }

        public static void ReadFile()
        {
            using (FileStream fs = new FileStream(
                "c:\\ara\\rehber.dat", FileMode.Open,
                FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (fs.Length > fs.Position)
                {
                    TelefonRehberi tr = new TelefonRehberi();
                    tr.No = br.ReadInt32();
                    tr.Ad = br.ReadString();
                    tr.Soyad = br.ReadString();
                    tr.TelefonNo = br.ReadInt64();

                    Console.WriteLine(
                        "{0:D2} {1,-15} {2,-15} {3:D11}",
                        tr.No,
                        tr.Ad,
                        tr.Soyad,
                        tr.TelefonNo);

                }
            }
        }
    }

    public class TelefonRehberi
    {
        public int No;
        public string Ad;
        public string Soyad;
        public long TelefonNo;

        /// <summary>
        /// Initializes a new instance of the <see cref="TelefonRehberi"/> class.
        /// </summary>
        public TelefonRehberi()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelefonRehberi"/> class.
        /// </summary>
        /// <param name="no">The no.</param>
        /// <param name="ad">The ad.</param>
        /// <param name="soyad">The soyad.</param>
        /// <param name="telefonNo">The telefon no.</param>
        public TelefonRehberi(int no, string ad,
            string soyad, long telefonNo)
        {
            No = no;
            Ad = ad;
            Soyad = soyad;
            TelefonNo = telefonNo;
        }
    }
}
