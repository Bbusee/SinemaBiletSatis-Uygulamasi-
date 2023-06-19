using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatışUygulaması
{
    public partial class Biletler : Form
    {
        public Biletler()
        {
            InitializeComponent();
        }
        public string Bilet_FilmAdi
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public string Bilet_Seans
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        public string Bilet_Fiyat
        {
            get => textBox3.Text;
            set => textBox3.Text = value;
        }

        private void Tamam(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void İptal(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
