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
    public partial class Destylarnia : Form
    {
        Pliki pliki = new Pliki();
        String rowToFile;
        public Destylarnia()
        {
            InitializeComponent();
        }
        public Destylarnia(Wynik wynik)
        {
            InitializeComponent();
            label2.Text += wynik.beer;
            label3.Text += wynik.wine;
            label4.Text += wynik.vodka;
            label5.Text += wynik.resultPromile.ToString();
            label6.Text += wynik.timeDetox.ToString();
            label7.Text += wynik.resultMessage;

            rowToFile = System.DateTime.Now + pliki.separator +
                wynik.beer + pliki.separator +
                wynik.wine + pliki.separator +
                wynik.vodka + pliki.separator +
                wynik.resultPromile + pliki.separator +
                wynik.timeDetox + pliki.separator +
                wynik.resultMessage + pliki.separator;

            String dir = "Zdjecia\\" + wynik.resultNo.ToString() + ".jpg";
            pictureBox1.Load(dir);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.progressBar1.Value = wynik.resultPromile > 6 ? 6 : Convert.ToInt32(wynik.resultPromile);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            pliki.SaveRowToFile(rowToFile);

        }

    }
}
