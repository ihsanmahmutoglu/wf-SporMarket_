using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SporMarket
{
    class cMusteri
    {
        private int _musteriID;
        private string _ad;
        private string _soyad;
        private string _telefon;
        private string _adres;
        private string _il;
        private string _ilce;
        private string _cinsiyet;

        #region Properties
        public int MusteriID
        {
            get
            {
                return _musteriID;
            }

            set
            {
                _musteriID = value;
            }
        }

        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }

        public string Il
        {
            get
            {
                return _il;
            }

            set
            {
                _il = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Ilce
        {
            get
            {
                return _ilce;
            }

            set
            {
                _ilce = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Cinsiyet
        {
            get
            {
                return _cinsiyet;
            }

            set
            {
                _cinsiyet = value;
            }
        }
        #endregion


        SqlConnection conn = new SqlConnection(cGenel.connStr);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public void MusterileriGetir(string cinsiyet, string ad, string soyad, string tel, string il, string ilce, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select Cinsiyet,Ad,Soyad,Telefon,Adres,il,ilce from Musteriler where Silindi=0 and Cinsiyet like @cinsiyet + '%' and Ad like @ad + '%' and Soyad like @soyad + '%' and Telefon like @tel + '%'  and il like @il + '%' and ilce like @ilce + '%' ", conn);
            comm.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = cinsiyet;
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;
            comm.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            comm.Parameters.Add("@il", SqlDbType.VarChar).Value = il;
            comm.Parameters.Add("@ilce", SqlDbType.VarChar).Value = ilce;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        i++;

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
        }
        public void MusterileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select Cinsiyet,Ad,Soyad,Telefon,Adres,il,ilce,MusteriID from Musteriler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        i++;

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
        }
        public DataSet MusterileriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select MusteriID,Cinsiyet,Ad,Soyad,Telefon,Adres,il,ilce from Musteriler where Silindi=0", conn);
            try
            {
                da.Fill(ds, "Musteriler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }
        public int KacinciMusteri(int ID)
        {
            int kacinci = 0;
            SqlCommand comm = new SqlCommand("select count(*) from Musteriler where Silindi=0 and MusteriID < @MusteriID", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                kacinci = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return kacinci;
        }
        public bool MusteriKontrol(string ad, string soyad)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select count(*) from Musteriler where Silindi=0 and Ad=@ad and Soyad=@soyad ", conn);
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                int sayisi = Convert.ToInt32(comm.ExecuteScalar());
                if (sayisi > 0)
                {
                    sonuc = true;
                }


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool MusteriKontrol(string ad, string soyad, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select count(*) from Musteriler where Silindi=0 and Ad = @ad and Soyad = @soyad and MusteriID != @ID ", conn);
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                int sayisi = Convert.ToInt32(comm.ExecuteScalar());
                if (sayisi > 0)
                {
                    sonuc = true;
                }


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool MusteriTanimla(cMusteri cm)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Musteriler(Cinsiyet,Ad,Soyad,Telefon,Adres,il,ilce) values(@Cinsiyet,@ad,@soyad,@Telefon,@Adres,@il,@ilce)", conn);
            comm.Parameters.Add("@Cinsiyet", SqlDbType.VarChar).Value = cm._cinsiyet;
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = cm._ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = cm._soyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = cm._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = cm._adres;
            comm.Parameters.Add("@il", SqlDbType.VarChar).Value = cm._il;
            comm.Parameters.Add("@ilce", SqlDbType.VarChar).Value = cm._ilce;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool MusteriGuncelle(cMusteri cm)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Musteriler set  Cinsiyet=@Cinsiyet,Ad=@ad,Soyad=@soyad,Telefon=@Telefon,Adres=@Adres,il=@il,ilce=@ilce where MusteriID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = cm._musteriID;
            comm.Parameters.Add("@Cinsiyet", SqlDbType.VarChar).Value = cm.Cinsiyet;
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = cm._ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = cm._soyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = cm._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = cm._adres;
            comm.Parameters.Add("@il", SqlDbType.VarChar).Value = cm._il;
            comm.Parameters.Add("@ilce", SqlDbType.VarChar).Value = cm._ilce;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool MusteriSil(int ID)
        {
            bool sonuc = false;

            SqlCommand comm = new SqlCommand("Update Musteriler set Silindi=1 where MusteriID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
    }
}
