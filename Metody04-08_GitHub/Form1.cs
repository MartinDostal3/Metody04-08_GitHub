﻿using System;
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
    }
}
