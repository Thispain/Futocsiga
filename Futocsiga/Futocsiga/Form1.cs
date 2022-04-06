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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        //private void button1_Click(object sender, EventArgs e) => Csiga1.Left += 1; //865  7/2



        //Kilépés 7/6
        private void button5_Click(object sender, EventArgs e)
        {//kilépés a játékmódból
            this.Close();
            Kezdokepernyo D = new Kezdokepernyo();
            D.Visible = true;
        }

        //Játékos Nyomógombok 7/6
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {//1-3 Játékos közös esemény
            int b = La_Reset.TabIndex;

            Keys key = e.KeyCode;
            //1.Játékos
            if (key == Keys.A)
            {
                Form1_Csiga1.Left += b;
            }
           

            //2. Játékos
            if (key == Keys.H)
            {
                Form1_Csiga2.Left += b;
            }
            //3. Játékos
            if (key == Keys.L)
            {
                Form1_Csiga3.Left += b;
            }
            //célbaért csigák vizsgálata
            if ((Form1_Csiga1.Left > Pb_Finish.Left) || (Form1_Csiga2.Left > Pb_Finish.Left)
                    || (Form1_Csiga3.Left > Pb_Finish.Left))
            {
                La_Reset.Visible = true;
                La_out.Visible = false;
                La_Reset.TabIndex = 0;
            }

        }

        //1. Játékos 7/4
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = La_Player_1.Text + " készen áll!";
            label2.Visible = true;
            label2.Tag = "1";
        }

        //2. Játékos 7/4
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = La_Player_2.Text + " készen áll!";
            label3.Visible = true;
            label3.Tag = "1";
        }

        //3. Játékos 7/4
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Text = La_Player_3.Text + " készen áll!";
            label4.Visible = true;
            label4.Tag = "1";
        }

        //Játékos nyomógomb kiíró/kommentár 7/7
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = (sender as Button).Text + " gombjai: " + (sender as Button).Tag;
            if (((label2.Tag) == (label3.Tag)) &
                ((label2.Tag) == (label4.Tag)) &
                ((label3.Tag) == (label4.Tag)))
            {
                La_Start.Visible = true;
            }
        }

        //Rajt időzítője 7/7
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (La_Player_3.TabIndex == 100)
            {
                label1.Text = "Rajt";
                La_Player_3.TabIndex = 99;
                La_Reset.TabIndex = 4;
            }
        }

        //Rajt gomb 7/6,5
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "3.....2.....1";
            label2.Tag = label2.TabIndex;
            label3.Tag = label3.TabIndex;
            label4.Tag = label4.TabIndex;
            La_Start.Visible = false;
            La_Player_3.TabIndex = 100;
            La_Player_1.Visible = false;
            La_Player_2.Visible = false;
            La_Player_3.Visible = false;
            button7.Visible = false;
        }

        //Súgó 7/5
        private void label8_Click(object sender, EventArgs e)
        {
            La_Game1.Visible = true;
            La_Game2.Visible = true;
            La_Game3.Visible = true;
        }

        //Csiga helyezés kiíró 7/1
        private void Csiga1_Move(object sender, EventArgs e)
        {
            int a = button7.TabIndex;
            if ((Form1_Csiga1.Left > (Pb_Finish.Left) + a) || (Form1_Csiga2.Left > (Pb_Finish.Left)+a)
                    || (Form1_Csiga3.Left > (Pb_Finish.Left)+a))
            {
                if (MessageBox.Show((sender as PictureBox).Tag + "", "Nyertél", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    button7.TabIndex = 30;//Megnöveli a értékét a messagebox megjelenésének megakadályozása érdekében
                }
            }
        }

        //Újraindítás gomb 7/7
        private void button4_Click(object sender, EventArgs e)
        {
            int a = 34;
            La_Reset.TabIndex = 0;
            Form1_Csiga1.Left = a;
            Form1_Csiga2.Left = a;
            Form1_Csiga3.Left = a;

            La_Reset.Visible = false;
            La_Player_1.Visible = true;
            La_Player_2.Visible = true;
            La_Player_3.Visible = true;
            La_out.Visible = true;
            button7.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            La_Game1.Visible = false;
            La_Game2.Visible = false;
            La_Game3.Visible = false;
            button7.TabIndex = 0;
        }

        //Kilépés a játékból
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "Biztos, hogy ki akarsz lépni a játékból?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void La_Player_1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            //Gombnyomásos indítás
            if (e.KeyChar == (char)Keys.A && e.KeyChar == (char)Keys.H && e.KeyChar == (char)Keys.L)
            {
                label1.Text = "3.....2.....1";
                label2.Tag = label2.TabIndex;
                label3.Tag = label3.TabIndex;
                label4.Tag = label4.TabIndex;
                La_Start.Visible = false;
                La_Player_3.TabIndex = 100;
                La_Player_1.Visible = false;
                La_Player_2.Visible = false;
                La_Player_3.Visible = false;
                button7.Visible = false;
            }
        }
    }
}
