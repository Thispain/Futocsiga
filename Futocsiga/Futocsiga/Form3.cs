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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Kilépés gomb
        private void button5_Click(object sender, EventArgs e)
        {
            Kezdokepernyo D = new Kezdokepernyo();
            this.Close();
            D.Visible = true;
        }


        //Játékos nyomógombok
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            int b = button4.TabIndex;

            Keys key = e.KeyCode;
            if (key == Keys.A)
            {
                Form3_Csiga2.Left += b;
            }


            if (key == Keys.L)
            {
                Form3_Csiga1.Left += b;
            }
            if ((Form3_Csiga1.Left > pictureBox2.Left) || (Form3_Csiga2.Left > pictureBox2.Left))
            {
                button4.Visible = true;
                Form3_button1.Visible = false;
                button2.Visible = false;
                button4.TabIndex = 0;
            }
        }

        //Súgó
        private void label6_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label4.Text = Form3_button1.Tag + "";
            label5.Text = button2.Tag + "";
        }

        //1. Játékos 7/4
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1_label2.Text = Form3_button1.Text + " készen áll!";
            Form1_label2.Visible = true;
            Form1_label2.Tag = "1";
        }

        //2. Játékos 7/4
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = button2.Text + " készen áll!";
            label3.Visible = true;
            label3.Tag = "1";
        }

        //Játékos egér gombok 7/7
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (sender as Button).Text + " gombjai: " + (sender as Button).Tag;
            if (((Form1_label2.Tag) == (label3.Tag)))
            {
                button3.Visible = true;
            }
        }

        //Rajt időzítője 7/7
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button3.TabIndex == 100)
            {
                label1.Text = "Rajt";
                button3.TabIndex = 99;
                button4.TabIndex = 1;
            }
        }

        //Rajt gomb 7/6,5
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3.....2.....1";
            Form1_label2.Tag = Form1_label2.TabIndex;
            label3.Tag = label3.TabIndex;
            button3.TabIndex = 100;
            Form3_button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label6.Visible = true;
            //button7.Visible = false;
        }

        //Csiga kiíró 7/7 
        private void Csiga1_Move(object sender, EventArgs e)
        {
            int a = button5.TabIndex;
            if ((Form3_Csiga1.Left > (pictureBox2.Left)+a) || (Form3_Csiga2.Left > (pictureBox2.Left)+a))
            {
                if (MessageBox.Show((sender as PictureBox).Tag + "", "Nyertél", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    button5.TabIndex = 30;
                }
            }
        }

        //Újraindítás gomb
        private void button4_Click(object sender, EventArgs e)
        {
            int a = 34;
            button4.TabIndex = 0;
            Form3_Csiga1.Left = a;
            Form3_Csiga2.Left = a;

            button4.Visible = false;
            Form3_button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            // button7.Visible = true;
            Form1_label2.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}

/*Kilépés 7/6
 

//Játékos Nyomógombok 7/6


//1. Játékos 7/4
    

//2. Játékos 7/4


//3. Játékos 7/4


//Játékos egér gombok 7/7
   

//Rajt időzítője 7/7


//Rajt gomb 7/6,5


//Súgó 7/5
   

//Csiga kiíró 7/7 */
