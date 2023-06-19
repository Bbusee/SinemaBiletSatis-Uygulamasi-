#define MySQL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if (MySQL)

using MDbConnection = MySql.Data.MySqlClient.MySqlConnection;
using MDbConnectionStringBuilder = MySql.Data.MySqlClient.MySqlConnectionStringBuilder;
using MDbCommand = MySql.Data.MySqlClient.MySqlCommand;
using MDbDataReader = MySql.Data.MySqlClient.MySqlDataReader;

#elif (MSSQL)

#elif (ACCESS)

#endif

namespace DataAccessLayer
{
    public static class DL
    {
        static MDbConnection connection = new MDbConnection(
    new MDbConnectionStringBuilder()
    {
#if MySQL
        Server = "localhost",
        Database = "sinema",
        UserID = "root",
        Password = "",
#elif MSSQL
#elif ACCESS
#endif

    }
    .ConnectionString);

        public static int MusteriEkle(string musteri_id, string musteri_adi, string musteri_soyadi, string musteri_telefon, string musteri_email, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MusteriEkle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@mid", musteri_id);
                komut.Parameters.AddWithValue("@adi", musteri_adi);
                komut.Parameters.AddWithValue("@soyadi", musteri_soyadi);
                komut.Parameters.AddWithValue("@telefon", musteri_telefon);
                komut.Parameters.AddWithValue("@email", musteri_email);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int BiletEkle(string bilet_id, string bilet_mid, string bilet_filmadi, string bilet_seans, string bilet_fiyat, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("BiletEkle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@bid", bilet_id);
                komut.Parameters.AddWithValue("@bmid", bilet_mid);
                komut.Parameters.AddWithValue("@filmadi", bilet_filmadi);
                komut.Parameters.AddWithValue("@seans", bilet_seans);
                komut.Parameters.AddWithValue("@fiyat", bilet_fiyat);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int MusteriDüzenle(string musteri_id, string musteri_adi, string musteri_soyadi, string musteri_telefon, string musteri_email, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MusteriDüzenle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@mid", musteri_id);
                komut.Parameters.AddWithValue("@adi", musteri_adi);
                komut.Parameters.AddWithValue("@soyadi", musteri_soyadi);
                komut.Parameters.AddWithValue("@telefon", musteri_telefon);
                komut.Parameters.AddWithValue("@email", musteri_email);


                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int BiletDüzenle(string bilet_id, string bilet_filmadi, string bilet_seans, string bilet_fiyat, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("BiletDüzenle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@bid", bilet_id);
                komut.Parameters.AddWithValue("@filmadi", bilet_filmadi);
                komut.Parameters.AddWithValue("@seans", bilet_seans);
                komut.Parameters.AddWithValue("@fiyat", bilet_fiyat);


                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int MusteriSil(string musteri_id, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MusteriSil", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@mid", musteri_id);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int BiletSil(string bilet_id, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("BiletSil", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@bid", bilet_id);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static List<(string musteri_id, string musteri_adi, string musteri_soyadi, string musteri_telefon, string musteri_email)> MusteriListele(out string error)
        {
            List<(string, string, string, string, string)> list = new List<(string, string, string, string, string)>();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MusteriListele", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString()
                        ));
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static List<(string bilet_id, string bilet_filmadi, string bilet_seans, string bilet_fiyat)> MusteriBiletiniListele(string bilet_mid, out string error)
        {
            List<(string, string, string, string)> list = new List<(string, string, string, string)>();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MusteriBiletiniListele", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@bmid", bilet_mid);
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString()
                        ));
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
    }
}
