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
    public partial class Fuel : Form
    {
        public Fuel()
        {
            InitializeComponent();
        }

        KerdesCsoport k;
        Csiga cs;

        private void Bt_Kesz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (k.Valasz(Tb_Valasz.Text))
            {
                //New question

                Kr_Kerdes.Text = k.RandomKerdes();
                La_Helyes.BackColor = Color.Green;
            }
            else
            {
                La_Helyes.BackColor = Color.FromArgb(255, 64, 64);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            La_Helyes.BackColor = Color.Gray;
            T_Effect.Stop();
        }

        private void Tb_Valasz_Enter(object sender, EventArgs e)
        {
            T_Effect.Start();
        }

        private void Tb_Valasz_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(null, EventArgs.Empty);
        }

        private void Fuel_Load(object sender, EventArgs e)
        {
          //  Kr_Kerdes.Text = k.RandomKerdes();
            Csiga.Update += Updating;
        }

        private void Updating(object sender, EventArgs e)
        { 
        
        }
    }
}
