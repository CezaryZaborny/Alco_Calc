using Piwo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piwo2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            String dir = "Zdjecia\\piwo" + ".jpg";
            pictureBox2.Load(dir);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Oblicz_Click(object sender, EventArgs e)
        {
            Wynik wynik = new Wynik(GenderB.Checked, 
                Convert.ToInt32(BodyMassB.Text),
                Convert.ToInt32(BeerB.Text),
                Convert.ToInt32(WineB.Text),
                Convert.ToInt32(VodkaB.Text));
            Destylarnia destylarnia = new Destylarnia(wynik);
            destylarnia.Show();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Walidacja(object sender, EventArgs e)
        {

        }

        private void Walidacja(object sender, CancelEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(((TextBox)sender).Text);
            }
            catch
            {
                ((TextBox)sender).Text = "0";
                MessageBox.Show("Wprowadz liczby, a nie cyfre!", "Blad");
                e.Cancel = true;
            }

        }

        private void GenderB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
