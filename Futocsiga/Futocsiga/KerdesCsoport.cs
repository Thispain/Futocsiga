using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Futocsiga
{
    class KerdesCsoport
    {
        string temaNev;

        string[] kerdesek;
        string[] valaszok;
        double[] ertekelesek;

        int probalkozas;
        Random rnd = new Random();

        public KerdesCsoport(string FileName)
        {
            if (File.Exists(FileName))
            {
                using (StreamReader sr = new StreamReader(FileName, Encoding.UTF8))
                {
                    for (int i = 0;  !sr.EndOfStream; i++)
                    {
                        string[] Temp = sr.ReadLine().Split('-');
                    }
                }
            }
        }

        public string RandomKerdes()
        {
            return kerdesek[rnd.Next(0, kerdesek.Length-1)];
        }

        public bool Valasz(string fff)
        {
            return true;
        }
    }
}
