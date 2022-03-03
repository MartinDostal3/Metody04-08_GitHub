using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            double mocnina = CelaCisla.mocnina(a, n);
            MessageBox.Show("mocnina dvou cisel je: " + mocnina);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox3.Text);
            int faktorial = CelaCisla.faktorial(n);
            MessageBox.Show("faktorial je: " + faktorial);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox4.Text);
            int soucetLich = CelaCisla.CifLichSoucet(n);
            MessageBox.Show("soucet lich cifer je: " + soucetLich);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox5.Text);
            if (CelaCisla.jePrvocislo(n)) MessageBox.Show("je prvocislo");
            else MessageBox.Show("neni prvocislo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CelaCisla celcis = new CelaCisla();
            int x = int.Parse(textBox6.Text);

            int pocetDelitelu = celcis.PocetDeliteluSud(x);
            MessageBox.Show("pocet sud delitelu je: " + pocetDelitelu);
        }
    }
}
