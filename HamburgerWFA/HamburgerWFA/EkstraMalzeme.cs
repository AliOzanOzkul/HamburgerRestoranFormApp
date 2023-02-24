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
    public partial class EkstraMalzeme : Form
    {
        public EkstraMalzeme()
        {
            InitializeComponent();
        }
        public List<Siparis> siparis2;
        SiparisOlustur sp = new SiparisOlustur();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == default || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!!!");
            }
            else
            {
                Restorant.EkstraMalzemeGuncelle(textBox1.Text, numericUpDown1.Value);
                sp.Guncelle();
                MessageBox.Show("Liste Güncellenmiştir...");
            }

            

            


        }

    }
}

