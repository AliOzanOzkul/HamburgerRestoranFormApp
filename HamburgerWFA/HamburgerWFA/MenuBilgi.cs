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
    public partial class MenuBilgi : Form
    {
        public MenuBilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == default || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Eksik Değer Girdiniz!!!");
            }
            else
            {
                Restorant.MenuListesiGuncelle(textBox1.Text, numericUpDown1.Value);
                MessageBox.Show("Ürün Listeye Eklendi");
            }
            
            
        }
    }
}
