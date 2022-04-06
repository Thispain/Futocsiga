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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kezdokepernyo D = new Kezdokepernyo();
            this.Close();
            D.Visible = true;
        }

        //Billentyűk
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            int b = Bu_Reset.TabIndex;
            Keys key = e.KeyCode;
            if (key == Keys.A)
            {
                Form4_Csiga1.Left += b;
            }

            if (key == Keys.G)
            {
                Form4_Csiga2.Left += b;
            }

            if (key == Keys.L)
            {
                Form4_Csiga3.Left += b;
            }

            if (key == Keys.D1)
            {
                Form4_Csiga4.Left += b;
            }

            int A = Form4_Csiga1.Left;
            int B = Form4_Csiga2.Left;
            int C = Form4_Csiga3.Left;
            int D = Form4_Csiga4.Left;
            int E = pictureBox2.Left;

            if ((A>=E) || (B>=E) || (C>=E) || (D>=E) )
            {
                Bu_Reset.Visible = true;
                Bu_Exit.Visible = false;
            }
        }

        //Újraindítás
        private void button4_Click_1(object sender, EventArgs e)
        {
            int a = 34;
            Form4_Csiga1.Left = a;
            Form4_Csiga2.Left = a;
            Form4_Csiga3.Left = a;
            Form4_Csiga4.Left = a;
            Bu_Game1.Visible = true;
            Bu_Game2.Visible = true;
            Bu_Game3.Visible = true;
            Bu_Game4.Visible = true;
            Bu_Stark.Visible = true;
            Bu_Reset.Visible = false;
            La_Game1_Commentar.Visible = false;
            La_Game2_Commentar.Visible = false;
            La_Game3_Commentar.Visible = false;
            La_Game4_Commentar.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            la_Quiestiens.Visible = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            La_Game1_Commentar.Text = (sender as Button).Tag + ". játékos készen áll";
            La_Game1_Commentar.Visible = true;
            La_Game1_Commentar.Tag = "1";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            La_Game2_Commentar.Text = (sender as Button).Tag + ". játékos készen áll";
            La_Game2_Commentar.Visible = true;
            La_Game2_Commentar.Tag = "1";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            La_Game3_Commentar.Text = (sender as Button).Tag + ". játékos készen áll";
            La_Game3_Commentar.Visible = true;
            La_Game3_Commentar.Tag = "1";
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            La_Game4_Commentar.Text = (sender as Button).Tag + ". játékos készen áll";
            La_Game4_Commentar.Visible = true;
            La_Game4_Commentar.Tag = "1";
        }

        //Egér kattintás
        private void button1_Click(object sender, EventArgs e)
        {
            La_Commentar.Text = (sender as Button).Text + " gombjai: " + (sender as Button).Tag;
            if (((La_Game1_Commentar.Tag) == (La_Game2_Commentar.Tag)) &
                ((La_Game1_Commentar.Tag) == (La_Game3_Commentar.Tag)) &
                ((La_Game1_Commentar.Tag) == (La_Game4_Commentar.Tag)) &
                ((La_Game2_Commentar.Tag) == (La_Game3_Commentar.Tag)) &
                ((La_Game2_Commentar.Tag) == (La_Game4_Commentar.Tag)) &
                ((La_Game3_Commentar.Tag) == (La_Game4_Commentar.Tag)))
            {
                Bu_Rajt.Visible = true;
            }   
        }

        //Súgó
        private void la_Quiestiens_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }

        //Rajt
        private void button8_Click(object sender, EventArgs e)
        {
            La_Commentar.Text = "3.........2.......1";
            La_Game1_Commentar.Tag = "5";
            La_Game2_Commentar.Tag = "7";
            La_Game3_Commentar.Tag = "2";
            La_Game4_Commentar.Tag = "4";
            Bu_Rajt.Visible = false;
            Bu_Game1.Visible = false;
            Bu_Game2.Visible = false;
            Bu_Game3.Visible = false;
            Bu_Game4.Visible = false;
            Bu_Stark.Visible = false;
            la_Quiestiens.Visible = true;
            Bu_Rajt.TabIndex = 100;
        }

        //Időzítő
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Bu_Rajt.TabIndex == 100)
            {
                La_Commentar.Text = "Rajt";
                Bu_Rajt.TabIndex = 99;
                Bu_Reset.TabIndex = 1;
            }
        }    
    }
}
