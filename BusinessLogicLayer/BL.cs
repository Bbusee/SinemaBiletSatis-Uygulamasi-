using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogicLayer.Entity;

namespace BusinessLogicLayer
{
    public static class BL
    {
        public static List<Musteri> Musteriler = new List<Musteri>();

        public static string error = "";

        public static bool MusteriEkle(string musteri_adi, string musteri_soyadi, string musteri_telefon, string musteri_email)
        {
            Musteri m = new Musteri()
            {
                Musteri_ID = Guid.NewGuid().ToString(),
                Musteri_Adi = musteri_adi,
                Musteri_Soyadi = musteri_soyadi,
                Musteri_Telefon = musteri_telefon,
                Musteri_Email = musteri_email
            };

            int res = DL.MusteriEkle(m.Musteri_ID, m.Musteri_Adi, m.Musteri_Soyadi, m.Musteri_Telefon, m.Musteri_Email, out error);
            if (res > 0)
            {
                Musteriler.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool BiletEkle(string bilet_mid, string bilet_filmadi, string bilet_seans, string bilet_fiyat)
        {
            Musteri m = Musteriler.Find(o => o.Musteri_ID == bilet_mid);
            Bilet b = new Bilet()
            {
                Bilet_ID = Guid.NewGuid().ToString(),
                Bilet_MID = bilet_mid,
                Bilet_Filmadi = bilet_filmadi,
                Bilet_Seans = bilet_seans,
                Bilet_Fiyat = bilet_fiyat
            };

            int res = DL.BiletEkle(b.Bilet_ID, bilet_mid, bilet_filmadi, bilet_seans, bilet_fiyat, out error);
            if (res > 0)
            {
                m.Biletler.Add(b);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MusteriDüzenle(string musteri_id, string musteri_adi, string musteri_soyadi, string musteri_telefon, string musteri_email)
        {
            Musteri m = Musteriler.Find(o => o.Musteri_ID == musteri_id);
            if (m != null)
            {
                int res = DL.MusteriDüzenle(m.Musteri_ID, musteri_adi, musteri_soyadi, musteri_telefon, musteri_email, out error);
                if (res > 0)
                {
                    m.Musteri_Adi = musteri_adi;
                    m.Musteri_Soyadi = musteri_soyadi;
                    m.Musteri_Telefon = musteri_telefon;
                    m.Musteri_Email = musteri_email;

                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        public static bool BiletDüzenle(string bilet_mid, string bilet_id, string bilet_filmadi, string bilet_seans, string bilet_fiyat)
        {
            Musteri m = Musteriler.Find(o => o.Musteri_ID == bilet_mid);
            int res = DL.BiletDüzenle(bilet_id, bilet_filmadi, bilet_seans, bilet_fiyat, out error);
            if (res > 0)
            {

                Bilet b = m.Biletler.Find(o => o.Bilet_ID == bilet_id);
                b.Bilet_Filmadi = bilet_filmadi;
                b.Bilet_Seans = bilet_seans;
                b.Bilet_Fiyat = bilet_fiyat;

                return true;

            }
            else return false;
        }

        public static bool MusteriSil(string musteri_id)
        {
            int res = DL.MusteriSil(musteri_id, out error);
            if (res > 0)
            {
                Musteri m = Musteriler.Find(o => o.Musteri_ID == musteri_id);
                Musteriler.Remove(m);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool BiletSil(string bilet_mid, string bilet_id)
        {
            Musteri m = Musteriler.Find(o => o.Musteri_ID == bilet_mid);
            int res = DL.BiletSil(bilet_id, out error);
            if (res > 0)
            {
                Bilet b = m.Biletler.Find(o => o.Bilet_ID == bilet_id);
                m.Biletler.Remove(b);

                return true;
            }
            else return false;

        }

        public static bool MusteriListele()
        {
            var list = DL.MusteriListele(out string error);
            if (list == null)
                return false;

            Musteriler = new List<Musteri>();
            foreach (var e in list)
            {
                Musteriler.Add(new Musteri()
                {
                    Musteri_ID = e.musteri_id,
                    Musteri_Adi = e.musteri_adi,
                    Musteri_Soyadi = e.musteri_soyadi,
                    Musteri_Telefon = e.musteri_telefon,
                    Musteri_Email = e.musteri_email,
                });

            }
            return true;
        }

        public static bool MusterininBiletiniListele(string bilet_mid)
        {
            var list = DL.MusteriBiletiniListele(bilet_mid, out error);
            if (list == null)
                return false;

            var musteri = Musteriler.Find(o => o.Musteri_ID == bilet_mid);
            musteri.Biletler = new List<Bilet>();

            foreach (var e in list)
            {
                musteri.Biletler.Add(new Bilet()
                {
                    Bilet_ID = e.bilet_id,
                    Bilet_MID = bilet_mid,
                    Bilet_Filmadi = e.bilet_filmadi,
                    Bilet_Seans = e.bilet_seans,
                    Bilet_Fiyat = e.bilet_fiyat,
                });

            }
            return true;
        }

    }
}
