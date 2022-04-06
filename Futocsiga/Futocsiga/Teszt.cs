using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futocsiga
{
    public partial class Teszt : Form
    {
        Csiga cs;
        int kezd;
        int end;
        double hossz;
        int iRajt = 4;
        int vTavolsag;
        string[] RajtT = new string[4];

        Timer TRajt = new Timer();

        public Teszt()
        {
            RajtT[0] = "Rajt!";
            RajtT[1] = "Kész!";
            RajtT[2] = "Vigyázz!";
            RajtT[3] = "Felkészülni!";

            InitializeComponent();
            cs = new Csiga();
            Csiga.Update += Updating;
            end = Pb_Palya.Left + Pb_Palya.Width - 4;
            hossz = Pb_Palya.Width - 2 - 4 - Pb_Csiga.Width;
            Pb_Csiga.Left = kezd;
            TRajt.Tick += TRajting;
            TRajt.Interval = 1000;
            Csiga.eCel += eCeeling;
            vTavolsag = Convert.ToInt32(nUD_Tav.Value);

            Pb_Palya.Controls.Add(Pb_Csiga);
            Pb_Palya.Controls.Add(Pb_Rajt);
            Pb_Palya.Controls.Add(Pb_Cel);


            Pb_Csiga.Location = new Point(2, 21);
            Pb_Rajt.Location = new Point(10, 7);
            Pb_Cel.Location = new Point(Pb_Palya.Width - 32, 9);
            KeyPreview = true;

          //  this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

           // Pb_Csiga.SendToBack();
        }

        private void Updating(object sender, EventArgs e)
        {
            Pb_Csiga.Left = cs.uPosition(Pb_Rajt, Pb_Cel, Pb_Palya);/* this.Pb_Palya.Width - 18))/ cs.Position +(Pb_Palya.Left + 9);*/  //Csiga Helyzete
            // Mutatók
            ProgB_Energiaszint.Value = Convert.ToInt32(Math.Floor(cs.Energia));
            La_Position.Text = $"{cs.Position}/{vTavolsag}";

        }

        private void Teszt_KeyUp(object sender, KeyEventArgs e)
        {
            cs.Elore(e.KeyCode);
            La_TOnOff.BackColor = cs.TurboSwitch(e.KeyCode)? Color.Green : Color.Red;
            cs.Feltoltodes(e.KeyCode);
        }

        private void Teszt_Load(object sender, EventArgs e)
        {
            Updating(cs, EventArgs.Empty);
        }

        private void Bt_Rajt_Click(object sender, EventArgs e)
        {
            cs.Restart();
            Bt_Rajt.Visible = LaT_Tav.Visible = nUD_Tav.Visible = false;
            if (!cs.Inrace)
            {
                TRajt.Start();
                T_StopWatch.Start();
            }
        }

        private void TRajting(object sender, EventArgs e)
        {
            iRajt--;
            if (iRajt == -1)
            {
                iRajt = 4;
                La_Szamlal.Text = "Verseny";
                TRajt.Stop();
                return;
            }
            La_Szamlal.Text = RajtT[iRajt];

            if (iRajt == 0)
            {
                cs.Rajt(vTavolsag);
            }
        }

        private void eCeeling(object sender, EventArgs e)
        {
            Bt_Rajt.Visible = LaT_Tav.Visible = nUD_Tav.Visible = !cs.Inrace ? true : false;
            if (cs.Inrace) cs.RaceTime1.Start();
            else cs.RaceTime1.Stop();
        }

        private void T_StopWatch_Tick(object sender, EventArgs e)
        {
            La_Time.Text = cs.RaceTime1.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void nUD_Tav_ValueChanged(object sender, EventArgs e)
        {
            vTavolsag = Convert.ToInt32(nUD_Tav.Value);
            Updating(cs, EventArgs.Empty);
        }
    }
}
