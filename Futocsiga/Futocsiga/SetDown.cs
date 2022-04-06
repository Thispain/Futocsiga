using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Futocsiga
{
    class SetDown
    {
        const int SetMax = 3;

        int[] Setup = new int[SetMax];

        int jatekosszam = 0;
        int jatekmod = 1;
        int _EvT = 2;

        public int Jatekosszam { get => Setup[jatekosszam]; set => Setup[jatekosszam] = value; }
        public int Jatekmod { get => Setup[jatekmod]; set => Setup[jatekmod] = value; }
        public int EvT { get => Setup[_EvT]; set => Setup[_EvT] = value; }

        public SetDown()
        {
            using (FileStream fs = new FileStream("SetToPlay.csw", FileMode.OpenOrCreate))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    for (int i = 0; !sw.EndOfStream; i++)
                    {
                        Setup[i] = int.Parse(sw.ReadLine());
                    }
                }
            }
        }
        
        //Players.csw

        public void Vegh()
        {
            using (FileStream fs = new FileStream("SetToPlay.csw", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < SetMax; i++)
                    {
                        sw.WriteLine(Setup[i]);
                    }
                }
            }
        }
        #region klap

        /*void Kezdeth()
        {
            
        } */

        #endregion
    }
}
