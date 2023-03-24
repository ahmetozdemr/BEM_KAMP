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

namespace İlkForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button5.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button11.Text;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button12.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = string.Empty;
            }
            label1.Text = label1.Text + button13.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string[] txt = label1.Text.Split('+');

            double sayi1 = double.Parse(txt[0]);
            double sayi2 = double.Parse(txt[1]);

            double toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();

        }
    }



    struct Not
    {
        public int No { get; set; }
    }
}
