using HamburgerWFA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerWFA
{
    public partial class Ciro : Form
    {
        public Ciro()
        {
            InitializeComponent();
        }

        private void Ciro_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        public void Guncelle()
        {
            
            label1.Text = "₺"+Restorant.CiroDegeri.ToString();
            label2.Text = Restorant.ToplamSatisSayisi.ToString();
            label3.Text = Restorant.SatilanUrunAdeti.ToString();
            label4.Text = "₺"+Restorant.SatilanEkstraMalzeme.ToString();
            for (int i = 0; i < SiparisOlustur.tablo.Count; i++)
            {
                listBox1.Items.Add(SiparisOlustur.tablo[i]);

            }
            
        }
    }
}
