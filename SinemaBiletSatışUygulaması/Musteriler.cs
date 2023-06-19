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

namespace SinemaBiletSatışUygulaması
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        public string Musteri_Adi
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public string Musteri_Soyadi
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        public string Musteri_Telefon
        {
            get => maskedTextBox1.Text;
            set => maskedTextBox1.Text = value;
        }
        public string Musteri_Email
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
