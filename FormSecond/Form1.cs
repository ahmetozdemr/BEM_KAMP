using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSecond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdErkek.Text = "Erkek";
            rdKadin.Text = "kadın";
            btnGoster.Enabled = false;
        }

        private void rdKadin_CheckedChanged(object sender, EventArgs e)
        {

        }
        string cinsiyet, egitim, Dil;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != string.Empty)
            {
                btnGoster.Enabled = false;
            }
            else
            {
                btnGoster.Enabled = true;
            }

            if (rdKadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            else if (true)
            {
                btnGoster.Enabled = false;
            }

            if (checkTurkce.Checked)
            {
                Dil += "Türkçe";
            }
            if (checkIngilizce.Checked)
            {
                Dil += " ,İngilizce";
            }
            if (checkAlmanca.Checked)
            {
                Dil += " ,Almanca";
            }

            if (rdIlkokul.Checked)
            {
                egitim = "İlkokul";
            }
            else if (rdOrtaokul.Checked)
            {
                egitim = "Ortaokul";
            }
            else if (rdLise.Checked)
            {
                egitim = "Lise";
            }
            else if (rdUniversite.Checked)
            {
                egitim = "Üniversite";
            }
            else
            {
                btnGoster.Enabled = false;
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            btnGoster.Enabled = ButonAktif();
        }

        bool ButonAktif()
        {
            if ((rdKadin.Checked || rdErkek.Checked) &&
                (rdIlkokul.Checked || rdOrtaokul.Checked || rdLise.Checked || rdUniversite.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
