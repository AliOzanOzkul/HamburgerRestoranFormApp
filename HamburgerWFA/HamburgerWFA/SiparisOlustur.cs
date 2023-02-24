using HamburgerWFA.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HamburgerWFA
{
    public partial class SiparisOlustur : Form
    {
        public static List<string> tablo = new List<string>(); 
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        public List<Siparis> siparis1;
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static List<CheckBox> boxlar = new List<CheckBox>();
       
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            
            foreach (string item in Restorant.MenuList)
            {
                comboBox1.Items.Add(item);
                
            }
            Guncelle();

        }

        public void Guncelle()
        {

            boxlar.Clear();
            int x = -117; //132 artı
            int y = 190; //37 artı
            int sayac = 1;
            for (int i = 0; i < Restorant.SosAdi.Count; i++)
            {

                boxlar.Add(new CheckBox());
                if (sayac <= 2)
                {
                    x = x + 132;
                    boxlar[i].Location = new Point(x, y);
                    boxlar[i].Text = Restorant.SosAdi[i];
                    boxlar[i].Font = new Font(boxlar[i].Font.FontFamily, 10f);
                    boxlar[i].Font = new Font(boxlar[i].Font, FontStyle.Bold);
                    Controls.Add(boxlar[i]);
                    sayac++;
                    if (sayac == 3)
                    {
                        x = 15;
                    }
                }
                else
                {
                    y = y + 37;
                    boxlar[i].Location = new Point(x, y);
                    boxlar[i].Text = Restorant.SosAdi[i];
                    boxlar[i].Font = new Font(boxlar[i].Font.FontFamily, 10f);
                    boxlar[i].Font = new Font(boxlar[i].Font, FontStyle.Bold);
                    this.Controls.Add(boxlar[i]);
                    sayac = 2;
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SiparisEkle();
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik Bilgi Girdiniz Lütfen Kontrol Ediniz!!!");
            }
            


        }
        decimal toplamTutar;
        int sosFiyati;
        string sosAdi;
        string menuBilgi;
        private void SiparisEkle()
        {
            int indeks = 0;
            Siparis h1 = new Siparis();
            h1.HamburgerAdiSet(comboBox1.Text);
            if (radioButton1.Checked)
            {
                indeks = 0;
            }
            else if (radioButton2.Checked)
            {
                indeks = 1;
            }
            else if (radioButton3.Checked)
            {
                indeks = 2;
            }
            
            h1.HamburgerBoyutSet(indeks);
            h1.HamburgerAdetSet(Convert.ToInt32(numericUpDown1.Value));
            Restorant.SatilanUrunAdeti += h1.HamburgerAdet;
            h1.HamburgerFiyat = Restorant.HamburgerFiyat[comboBox1.SelectedIndex];

            
            for (int i = 0; i < boxlar.Count; i++)
            {
                if (boxlar[i].Checked)
                {
                    h1.SosToplamFiyati=h1.SosToplamFiyat(i);
                    sosFiyati = Convert.ToInt32(h1.SosToplamFiyati);
                }
            }
            
            foreach (CheckBox item in boxlar)
            {
                if (item.Checked)
                {
                    sosAdi += item.Text + " ";
                }
            }

            toplamTutar += (h1.HamburgerFiyat + h1.SosToplamFiyati + h1.BoyFiyati)*h1.HamburgerAdet;
            label5.Text = toplamTutar.ToString();

            menuBilgi = h1.Adi + " X " + h1.HamburgerAdet.ToString() + " Adet " + h1.Boyut + " (" + sosAdi + " )";
            
            
            ListViewItem lvi = new ListViewItem();
            lvi.Text = h1.Adi;
            lvi.SubItems.Add(h1.Boyut);
            lvi.SubItems.Add(h1.HamburgerAdet.ToString());
            

            lvi.SubItems.Add(((h1.HamburgerFiyat+h1.BoyFiyati + h1.SosToplamFiyati)*h1.HamburgerAdet).ToString());

            listView1.Items.Add(lvi);
            



        }
   



        private void button2_Click(object sender, EventArgs e)
        {
            


            DialogResult dr = MessageBox.Show($"Toplam Sipariş Tutarı ₺{toplamTutar} Satın Almayı Tamamlamak İster Misiniz?",
                      $"Toplam Sipariş Tutarı ₺{toplamTutar} Satın Almayı Tamamlamak İster Misiniz? Bilgisi", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    
                    Restorant.CiroDegeri += Convert.ToInt32(toplamTutar);
                    Restorant.ToplamSatisSayisi += 1;
                    Restorant.SatilanEkstraMalzeme = sosFiyati;
                    tablo.Add(menuBilgi);
                    sosAdi = default;
                    toplamTutar = 0;
                    label5.Text = "0";
                    listView1.Items.Clear();

                    break;
                case DialogResult.No:
                    listView1.Items.Clear();
                    MessageBox.Show("İptal Edildi!");
                    break;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string item in Restorant.MenuList)
            {
                comboBox1.Items.Add(item);

            }
        }

        private void SiparisOlustur_Activated(object sender, EventArgs e)
        {

        }
    }
}
