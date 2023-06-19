using BusinessLogicLayer;
using System.Security.Cryptography;
using static BusinessLogicLayer.Entity;

namespace SinemaBiletSatışUygulaması
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        void HataGöster()
        {
            if (!string.IsNullOrEmpty(BL.error))
                MessageBox.Show("Hata Ayrıntıları: \n" + BL.error, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MusteriEkle(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler()
            {
                Text = "Musteri Ekle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var res = BL.MusteriEkle(frm.Musteri_Adi, frm.Musteri_Soyadi, frm.Musteri_Telefon, frm.Musteri_Email);
                if (res == false)
                    HataGöster();
                else
                    MusteriyiListeyeEkle(BL.Musteriler[BL.Musteriler.Count - 1]);
            }

        }

        private void MusteriDüzenle(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            var musteri = listView1.SelectedItems[0];

            var m = musteri.Tag as Musteri;

            Musteriler frm = new Musteriler()
            {
                Text = "Musterileri Düzenle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,

                Musteri_Adi = m.Musteri_Adi,
                Musteri_Soyadi = m.Musteri_Soyadi,
                Musteri_Email = m.Musteri_Email,
                Musteri_Telefon = m.Musteri_Telefon
            };

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var res = BL.MusteriDüzenle(m.Musteri_ID, frm.Musteri_Adi, frm.Musteri_Soyadi, frm.Musteri_Email, frm.Musteri_Telefon);

            if (res == false)
                HataGöster();
            else
            {
                musteri.SubItems[0].Text = frm.Musteri_Adi;
                musteri.SubItems[1].Text = frm.Musteri_Soyadi;
                musteri.SubItems[2].Text = frm.Musteri_Email;
                musteri.SubItems[3].Text = frm.Musteri_Telefon;
            }
        }

        private void MusteriSil(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            var sonuc = MessageBox.Show("Seçilen Müşteri Silinsin Mi?", "Silmeyi Onayla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc != DialogResult.Yes)
                return;

            var musteri = listView1.SelectedItems[0];
            var m = musteri.Tag as Musteri;

            var res = BL.MusteriSil(m.Musteri_ID);
            if (res == false)
                HataGöster();
            else
                listView1.Items.Remove(musteri);
        }

        void MusteriyiListeyeEkle(Musteri m)
        {
            ListViewItem musteri = new ListViewItem(new string[]

                {
                    m.Musteri_Adi,
                    m.Musteri_Soyadi,
                    m.Musteri_Telefon,
                    m.Musteri_Email
                });

            musteri.Tag = m;

            listView1.Items.Add(musteri);
        }

        void MusteriyiListele()
        {
            foreach (var m in BL.Musteriler)
            {
                MusteriyiListeyeEkle(m);
            }
        }

        private void MusterileriListele(object sender, EventArgs e)
        {
            {
                BL.MusteriListele();

                MusteriyiListele();
            };
        }

        private void BiletEkle(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
                return;

            var musteri = listView1.SelectedItems[0].Tag as Musteri;

            Biletler frm = new Biletler()
            {
                Text = "Bilet Ekle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var res = BL.BiletEkle(musteri.Musteri_ID, frm.Bilet_FilmAdi, frm.Bilet_Seans, frm.Bilet_Fiyat);
                if (res == false)
                    HataGöster();
                else
                    BiletiListeyeEkle(musteri.Biletler[musteri.Biletler.Count - 1]);
            }
        }

        private void BiletDüzenle(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            var bilet = listView2.SelectedItems[0];

            var b = bilet.Tag as Bilet;

            Biletler frm = new Biletler()
            {
                Text = "Bilet Düzenle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,

                Bilet_FilmAdi = b.Bilet_Filmadi,
                Bilet_Seans = b.Bilet_Seans,
                Bilet_Fiyat = b.Bilet_Fiyat
            };

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var res = BL.BiletDüzenle(b.Bilet_MID, b.Bilet_ID, frm.Bilet_FilmAdi, frm.Bilet_Seans, frm.Bilet_Fiyat);

            if (res == false)
                HataGöster();
            else
            {
                bilet.SubItems[0].Text = frm.Bilet_FilmAdi;
                bilet.SubItems[1].Text = frm.Bilet_Seans;
                bilet.SubItems[2].Text = frm.Bilet_Fiyat;
            }
        }

        private void BiletSil(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            var sonuc = MessageBox.Show("Seçilen Bilet Silinsin Mi?", "Silmeyi Onayla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc != DialogResult.Yes)
                return;

            var bilet = listView2.SelectedItems[0];
            var b = bilet.Tag as Bilet;

            var res = BL.BiletSil(b.Bilet_MID, b.Bilet_ID);
            if (res == false)
                HataGöster();
            else
                listView2.Items.Remove(bilet);
        }

        void BiletiListeyeEkle(Bilet b)
        {

            ListViewItem bilet = new ListViewItem(new string[]
                {

                b.Bilet_Filmadi,
                b.Bilet_Seans,
                b.Bilet_Fiyat

                });

            bilet.Tag = b;

            listView2.Items.Add(bilet);

        }

        void BiletiListele(Musteri m)
        {
            listView2.Items.Clear();
            foreach (var e in m.Biletler)
                BiletiListeyeEkle(e);
        }

        private void BiletleriListele(object sender, EventArgs e)
        {

            listView2.Items.Clear();
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var musteri = listView1.SelectedItems[0].Tag as Musteri;

            var res = BL.MusterininBiletiniListele(musteri.Musteri_ID);

            if (res == false)
                HataGöster();
            else
            {
                BiletiListele(musteri);
            }
        }
    }
}