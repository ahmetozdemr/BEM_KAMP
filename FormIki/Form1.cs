using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnErkek_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.White;

            if (btnKadin.Checked)
            {
                label1.Text = "Erkek seçildi";
            }

        }

        private void btnKadin_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Bisque;

            if (btnErkek.Checked)
            {
                label1.Text = "Baaaayan seçildi";
            }
        }

        private void btnKadin_Click(object sender, EventArgs e)
        {

        }

        private void btnErkek_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string bilgi, egitimdurumu;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text;
            if (!btnErkek.Checked)
            {
                bilgi = "Erkek";
            }
            else
            {
                bilgi = "Kadın";
            }
            if (radioButton1.Checked)
            {
                egitimdurumu = "İlkokul";
            }
            else if (radioButton2.Checked)
            {
                egitimdurumu = "Ortaokul";
            }
            else if (radioButton3.Checked)
            {
                egitimdurumu = "Lise";
            }
            else
            {
                egitimdurumu = "Üniversite";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                button1.Enabled = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                button1.Enabled = true;
            }
        }
    }
}
