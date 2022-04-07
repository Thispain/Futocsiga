using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;


namespace Futocsiga
{
    class Csiga
    {
        static public event EventHandler Update;
        static public event EventHandler eCel;
        double energia;
        public string s_Message { get; private set; }
        Stopwatch RaceTime = new Stopwatch();

        int position;
        int kezdes, veg = 50 ;

        bool inrace;

        PictureBox versenyzo, rajt, palya, cel;

        Timer time = new Timer();

        public double Energia { get => energia; private set { energia = value; Update?.Invoke(this, EventArgs.Empty); } }
        public int Position
        {
            get => position; set
            {
                position = value; Update?.Invoke(this, EventArgs.Empty);
                if (Position >= veg) Cel();
                if (Energia <= 0) Crash();
            }
        }

        public bool Inrace { get => inrace; private set => inrace = value; }
        public TimeSpan RaceTime1 { get => RaceTime.Elapsed; }

        public Csiga()
        {
            #region Szar
            /* Random rnd = new Random();
             var cs = new PictureBox
             {
                 Name = "Pb_Csiga_" + rnd.Next(10000, 10000),
                 Size = new Size(37, 37),
                // Image = Image.FromFile(@"\Images\Csiga.png"),
                 //BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                 Location = new System.Drawing.Point(213, 294),
                 BackColor = Color.Blue
             };
             fs.Controls.Add(cs);*/
            #endregion
            Inrace = false;

            Energia = 1000;

            //kezdes = rajt.Left;
            //veg = cel.Left == rajt.Left ? cel.Left+cel.Width : cel.Left;

                        
            Position = 0;
            time.Interval = 1;
            time.Tick += Turbo;
        }

        public void Restart()
        {
            Position = 0;
            Energia = 1000;
        }

        public void Rajt(int tavolsag)
        {
            Restart();
            veg = tavolsag;
            Inrace = true;
            s_Message = "Versenyben vagy!";
            eCel?.Invoke(this, EventArgs.Empty);
            RaceTime.Restart();
        }

        void Cel()
        {
            Inrace = false;
            s_Message = "Győztíl!";
            eCel?.Invoke(this, EventArgs.Empty);
            RaceTime.Stop();
            SystemSounds.Exclamation.Play();
            // MessageBox.Show("Győztíl!", "LastForm!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        public void Elore(Keys key)
        {
            if (key == Keys.K && Inrace && Energia > 0)
            {
                Position += 1;
              //  Energia -= 0.5;
            }
        }

        #region OutDated

        void Crash()
        {
            Inrace = false;
            RaceTime.Stop();
            s_Message = "Vesztettíl!";
            eCel?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Gratulálok. Elérted az elérhetetlent.\n Vesztettél.");
        }

        public bool TurboSwitch(Keys a)
        {
            if (a == Keys.Space)
            {
                if (!time.Enabled && Inrace)
                {
                    if (energia > 40) time.Start();
                }
                else
                {
                    time.Stop();
                }
            }

            return time.Enabled;
        }

        void Turbo(object sender, EventArgs e)
        {
            if (Energia > 5 && Inrace)
            {
                Position += 2;
              //  Energia -= 0/*2.5*/;
            }
            else
            {
                (sender as Timer).Stop();
            }
        }

        public void Feltoltodes(Keys key)
        {
            if (key == Keys.Up)
            {
                Fuel f = new Fuel();
                f.ShowDialog();
            }
        }

        public int MinMaxWell(ProgressBar a, int x)
        {
            if (x < 0) x = Math.Max(x, a.Minimum - a.Value);
            else x = Math.Min(x, a.Maximum - a.Value);
            return x;
        }
        #endregion

        double hossz;
        double kezd;
        double er;
        public int uPosition(PictureBox rajt, PictureBox cel, PictureBox palya)
        {
            hossz = cel.Left - rajt.Left;
            kezd = rajt.Left;
            er = (Convert.ToDouble(hossz / veg) * this.Position);
            return Convert.ToInt32(Math.Floor(er));
        }
    }
}
