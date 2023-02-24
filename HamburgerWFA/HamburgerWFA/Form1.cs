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
    public partial class Form1 : Form
    {
        SiparisOlustur form2 = new SiparisOlustur();
        MenuBilgi menuForm = new MenuBilgi();
        EkstraMalzeme menuForm2 = new EkstraMalzeme();
        Ciro ciro = new Ciro();
        List<Siparis> siparis12 = new List<Siparis>();
        public Form1()
        {
            InitializeComponent();
            form2.MdiParent = this;
            menuForm.MdiParent = this;
            
            
            
        }
        
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {




            //foreach (Form mdiChild in this.MdiChildren)
            //{
            //    if (mdiChild.Text == form2.Text)
            //    {
            //        mdiChild.BringToFront();
            //        return;
            //    }

            //}
            //form2.MdiParent = this;
            form2.siparis1 = siparis12;
            form2.Refresh();
            
            form2.Show();
            menuForm2.Hide();

            form2.Activate();
            
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

           




            //foreach (Form mdiChild in this.MdiChildren)
            //{
            //    if (mdiChild.Text == menuForm.Text)
            //    {
            //        mdiChild.BringToFront();
            //        return;
            //    }

            //}

            //menuForm.MdiParent = this;
            
            menuForm.Refresh();
            menuForm.Show();
            menuForm.Activate();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //EkstraMalzeme menuForm = new EkstraMalzeme();

            //foreach (Form mdiChild in this.MdiChildren)
            //{
            //    if (mdiChild.Text == menuForm.Text)
            //    {

            //        mdiChild.BringToFront();

            //        return;
            //    }

            //}
            menuForm2.siparis2 = siparis12;
            menuForm2.MdiParent = this;
            menuForm2.Show();
            menuForm2.Activate();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ciro.MdiParent = this;
            ciro.Show();
            ciro.Activate();
        }
    }
}
