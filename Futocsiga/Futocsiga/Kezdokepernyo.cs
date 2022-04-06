using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Futocsiga
{
    public partial class Kezdokepernyo : Form
    {
        public Kezdokepernyo()
        {
            InitializeComponent();
        }

        private void BT_Play_Click(object sender, EventArgs e)
        {
            Teszt ts = new Teszt();
            ts.ShowDialog();
            //Adatbekeres
            //this.Close();
        }

        private void BT_Kilepes_Click(object sender, EventArgs e) //Kilépés
        {
            Application.Exit();
        }

        private void Kezdokepernyo_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Játékosok száma
        {
            La_SingleOrMulty.Text = nUP_JatekosSzam.Value == 1 ? "Egyjátékosmód" : "Többjátékosmód";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Bt_Setup_Click(object sender, EventArgs e) //Beállítások
        {
            Setup st = new Setup();
            st.ShowDialog();
        }

        private void Bt_Push_Click(object sender, EventArgs e) //Adathalmaz kiválasztása
        {
            SelectData sd = new SelectData();
            sd.ShowDialog();
        }

        private void Bt_NewData_Click(object sender, EventArgs e) //Új adathalmaz létrehozása
        {
            NewData nw = new NewData();
            nw.ShowDialog();
        }

        private void Kezdokepernyo_Load(object sender, EventArgs e)
        {

        }
    }
}
