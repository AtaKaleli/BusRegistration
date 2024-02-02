using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilgiler.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " " + " / Tarih: " + dateTimePicker1.Text + " " + " / Saat: " + maskedTextBox1.Text);
            Bilgiler.Items.Add("Ad Soyad: " + textBox1.Text + " " + " / TCKN: " + maskedTextBox2.Text + " " + " / Numara: " + maskedTextBox3.Text);
            MessageBox.Show("Bilgileriniz Kaydedildi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
