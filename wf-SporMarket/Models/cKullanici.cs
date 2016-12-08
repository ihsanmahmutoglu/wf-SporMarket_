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
    class cKullanici
    {
        private int _kullaniciID;
        private string _kullaniciAdi;
        private int _kullaniciTipi;
        private string _adi;
        private string _soyadi;
        private string _sifre;

        #region Properties
        public int KullaniciID
        {
            get
            {
                return _kullaniciID;
            }

            set
            {
                _kullaniciID = value;
            }
        }



        public int KullaniciTipi
        {
            get
            {
                return _kullaniciTipi;
            }

            set
            {
                _kullaniciTipi = value;
            }
        }


        public string Adi
        {
            get
            {
                return _adi;
            }

            set
            {
                _adi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }



        public string Soyadi
        {
            get
            {
                return _soyadi;
            }

            set
            {
                _soyadi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public string Sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }
        }

        public string KullaniciAdi
        {
            get
            {
                return _kullaniciAdi;
            }

            set
            {
                _kullaniciAdi = value;
            }
        }

        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public bool KullanıcıGirisOnay(string Kad, string sifre)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select count(*) from Kullanicilar where KullaniciAdi =@Ad and sifre=@sifre and silindi=0 ", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Kad;
            comm.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                if (Convert.ToInt32(comm.ExecuteScalar()) == 1)
                {
                    sonuc = true;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }



        public cKullanici  aktifkullaniciGetir(string Kad)
        {
            cKullanici k = new cKullanici();
            SqlCommand comm = new SqlCommand("Select KullaniciID,KullaniciAdi ,kullaniciTipi from Kullanicilar where KullaniciAdi =@Ad  and kullanicilar.silindi=0 ", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Kad;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                dr.Read();
                if (dr.HasRows )
                {
                    k._kullaniciID = Convert.ToInt32(dr[0]);
                    k._kullaniciAdi = dr[1].ToString();
                    k._kullaniciTipi = Convert.ToInt32 (dr[2]);
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return k;
        }
        public cKullanici KullaniciGetirByAdaGore(string Kad)
        {
            cKullanici k = new cKullanici();
            SqlCommand comm = new SqlCommand("Select Adi,Soyadi,Sifre,KullaniciID from Kullanicilar where KullaniciAdi =@Ad  and silindi=0 ", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Kad;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    k._adi = (dr[0].ToString());
                    k._soyadi = dr[1].ToString();
                    k._sifre = dr[2].ToString();
                    k._kullaniciID = Convert.ToInt32(dr[3]);

                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return k;

        }

       

        public bool KullaniciSifreDegistir(int ID, string sifre)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Kullanicilar set Sifre=@sifre where KullaniciID=@ID ", conn);
            comm.Parameters.Add("@sifre", SqlDbType.Int).Value = sifre;
            comm.Parameters.Add("@ID", SqlDbType.Char).Value = ID;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
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

       

        public void KullanicilariGetir(ListView liste) // Kullanıcıların Tamamını listviewe Getirmek için
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select KullaniciID,TurAd,KullaniciAdi,Adi,Soyadi,Sifre From Kullanicilar inner join KullaniciTipleri on Kullanicilar.KullaniciTipi=KullaniciTipleri.KTipNo where Kullanicilar.Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open(); try
            {
                SqlDataReader dr = comm.ExecuteReader();
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
                        i++;
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
        }


        public void KullanicilariGetirByAdaGore(ListView liste, string isim)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select KullaniciID,TurAd,KullaniciAdi,Adi,Soyadi,Sifre From Kullanicilar inner join KullaniciTipleri on Kullanicilar.KullaniciTipi=KullaniciTipleri.KTipNo where Kullanicilar.Silindi=0 and Adi like @Ad", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = isim +"%";
            if (conn.State == ConnectionState.Closed)
                conn.Open(); try
            {
                SqlDataReader dr = comm.ExecuteReader();
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
                        i++;
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
        }

        public bool KullaniciKontrol(string Ad, string Soyad)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("Select Adi from Kullanicilar where Adi=@Ad and Soyadi=@Soyad and silindi=0", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyad;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    varmi = true;
                }
                else { varmi = false; }
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return varmi;
        }
        public bool KullaniciKontrol(int ID,string Ad, string Soyad)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("Select Adi from Kullanicilar where Adi=@Ad and Soyadi=@Soyad and silindi=0 and KullaniciID!=@ID", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyad;
            comm.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    varmi = true;
                }
                else { varmi = false; }
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return varmi;
        }
        public bool KullaniciEkle(cKullanici k)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert Into Kullanicilar (KullaniciTipi,KullaniciAdi,Adi,Soyadi,Sifre) values(@KullaniciTipi,@KullaniciAdi,@Ad,@Soyad,@Sifre)", conn);
            comm.Parameters.Add("@KullaniciTipi", SqlDbType.Int).Value = k._kullaniciTipi;
            comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar ).Value = k._adi + k._soyadi;
            comm.Parameters.Add("@Ad", SqlDbType.VarChar ).Value = k._adi;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar ).Value = k._soyadi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar ).Value = k._sifre;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }finally {   conn.Close();}
            return sonuc;
        }
        public  bool KullaniciGuncelle(cKullanici k)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Kullanicilar set KullaniciTipi=@KullaniciTipi,KullaniciAdi=@KullaniciAdi,Adi=@KullaniciAdi,Soyadi=@Soyad,Sifre=@Sifre where KullaniciID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = k._kullaniciID;
            comm.Parameters.Add("@KullaniciTipi", SqlDbType.Int).Value = k._kullaniciTipi;
            comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = k._adi + k._soyadi;
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = k._adi;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = k._soyadi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = k._sifre;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
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

        public  bool KullaniciSil(int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Kullanicilar set Silindi=1 where KullaniciID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
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
