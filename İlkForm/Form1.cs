using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

   

        private void BtnMerha(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            textBox1.Focus();


            if (this.BackColor == Color.AliceBlue)
            {
                this.BackColor = Color.Tan;
            }
            else
            {
                this.BackColor = Color.AliceBlue;
            }

            if (Start.Text == "Degisti")
            {
                Start.Text = "Aynı";
            }
            else
            {
                Start.Text = "Degisti";
            }
        }
        private void label(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text==" ")
            {
         
            }
        }
    }
}