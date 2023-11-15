using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); 
            double sayi2 = Convert.ToDouble(textBox2.Text);

            double sonuc = sayi1 + sayi2;

            textBox3.Text = sonuc.ToString(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); 
            double sayi2 = Convert.ToDouble(textBox2.Text);

            double sonuc = sayi1 - sayi2;

            textBox3.Text = sonuc.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); 
            double sayi2 = Convert.ToDouble(textBox2.Text);

            double sonuc = sayi1 * sayi2;

            textBox3.Text = sonuc.ToString(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); 
            double sayi2 = Convert.ToDouble(textBox2.Text);

            if (sayi2 != 0)
            {
                double sonuc = sayi1 / sayi2;
                textBox3.Text = sonuc.ToString();
            }

            else
            {
                textBox3.Text = "Sıfır";
                MessageBox.Show("Tanımsızdır.");
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
