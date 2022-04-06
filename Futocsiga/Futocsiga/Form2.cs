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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Setup p = new Setup();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            La_Pyss.Text = Bt_Py1.Text + " gombjai: " + Bt_Py1.Tag;         
            Bt_Rajt.Visible = true;
            La_Py1.Text = Bt_Py1.Text + " készen áll!";
            La_Py1.Visible = true;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            int b = Bt_Restart.TabIndex;

            Keys key = e.KeyCode;
            if (key == Keys.A)
            {
                PyB_Py1_Csiga.Left += b;
            }

            if ((PyB_Py1_Csiga.Left > PB_Cel.Left))
            {
                Bt_Restart.Visible = true;
                Bt_Py1.Visible = false;
                Bt_Exit.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Bt_Py1.TabIndex == 100)
            {
                La_Pyss.Text = "Rajt";
                Bt_Py1.TabIndex = 99;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            La_Pyss.Text = "3.....2.....1";
            Bt_Restart.TabIndex = 1;
            La_Py1.Tag = La_Py1.TabIndex;
            label3.Tag = label3.TabIndex;
            Bt_Rajt.Visible = false;
            Bt_Py1.TabIndex = 100;
            Bt_Py1.Visible = false;
            La_Support.Visible = true;
            Bt_Restart.TabIndex = 1;
            Bt_Rajt.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 34;
            Bt_Restart.TabIndex = 0;
            PyB_Py1_Csiga.Left = a;

            Bt_Restart.Visible = false;
            Bt_Py1.Visible = true;
            Bt_Exit.Visible = true;
            La_Py1.Visible = false;
            label3.Visible = false;
            La_Support.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Kezdokepernyo D = new Kezdokepernyo();
            D.Visible = true;
        }

        private void pictureBox3_Move(object sender, EventArgs e)
        {
            if (PyB_Py1_Csiga.Left > PB_Cel.Left)
            {
                MessageBox.Show((sender as PictureBox).Tag + "", "Nyertél", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
