using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProjectForm
{
    public partial class Form1 : Form
    {
        public string[] yiyeceklerList;
        public string[] filmList;
        public int[] filmFiyatlist;
        public string[] koltukList;
        public int[] yiyecekFiyatList;

        public Dictionary<string, int> yiyecekList;
        public Form1()
        {
            InitializeComponent();

            yiyecekList = new Dictionary<string, int>() { { "Patlamış mısır", 50 }, { "Kola", 20 }, { "Abur Cubur", 15 }, { "Sandviç", 25 }, { "Hamburger", 55 } };

            yiyeceklerList = new string[] { "Patlamış mısır", "Kola", "Abur Cubur", "Sandviç", "Hamburger" };
            yiyecekFiyatList = new int[] { 10, 20, 15, 35, 55 };

            filmList = new string[] { "Harry Potter", "Avatar", "Gladyatör", "Prestij", "Babam ve Oğlum", "Yenilmezler", "G.O.R.A", "Arif 216" };
            filmFiyatlist = new int[] { 50, 80, 45, 70, 75, 65, 64, 70 };

            koltukList = new string[] { "Koltuk 1", "Koltuk 2", "Koltuk 3", "Koltuk 4", "Koltuk 5", "Koltuk 6", "Koltuk 7" };

            listFilms.Items.AddRange(filmList);
            listKoltuk.Items.AddRange(koltukList);
            checkedListYiyecek.Items.AddRange(yiyecekList.Keys.ToArray());

            for (int i = 0; i < filmFiyatlist.Length; i++)
            {
                labelFiyat.Text = labelFiyat.Text + filmFiyatlist[i] + " TL" + "\n";
            }

            for (int i = 0; i < yiyecekFiyatList.Length; i++)
            {
                labelYiyecekFiyat.Text = labelYiyecekFiyat.Text + yiyecekList.Values.ToArray()[i] + " TL" + "\n";
            }

        }

        private void listFilms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listKoltuk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListYiyecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkedListYiyecek.SelectedItems.ToString();
            // MessageBox.Show(checkedListYiyecek.Items[0].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBilgiGoster_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            BilgileriGoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelFiyat_Click(object sender, EventArgs e)
        {

        }
        public void BilgileriGoster()
        {

            int a = 0;
            for (int i = 0; i < checkedListYiyecek.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListYiyecek.CheckedItems[i].ToString());

              

            }
            a = a;

            labelBilgiGoster.Text =
                textAd.Text + " " +
                textSoyad.Text + "\n " +
                listFilms.SelectedItem.ToString() + "\n " +
                listKoltuk.SelectedItem.ToString() + "\n " +
                checkedListYiyecek.SelectedItem.ToString() + "\n " +
                "Toplam Tutar :" + (filmFiyatlist[listFilms.SelectedIndex] + checkedListYiyecek.+ yiyecekFiyatList[checkedListYiyecek.SelectedIndex]);


        }
    }
}
