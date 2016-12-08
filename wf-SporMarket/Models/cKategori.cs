using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SporMarket
{
    class cKategori
    {
        private int _kategoriNo;
        private string _kategoriAd;
        private string _aciklama;

        #region Properties
        public int KategoriNo
        {
            get
            {
                return _kategoriNo;
            }

            set
            {
                _kategoriNo = value;
            }
        }

        public string KategoriAd
        {
            get
            {
                return _kategoriAd;
            }

            set
            {
                _kategoriAd = value;
            }
        }



        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        }


        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public void KategorileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select KategoriAd, Aciklama, KategoriNo from Kategoriler where Silindi = 0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
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

        public bool KategoriKontrol(string KategoriAd)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from Kategoriler where Silindi = 0 and KategoriAd=@KategoriAd", conn);
            comm.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = KategoriAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    sonuc = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return sonuc;
        }

        public bool KategoriEkle(cKategori ck)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Kategoriler(KategoriAd, Aciklama) values( @KategoriAd, @Aciklama)", conn);
            comm.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = ck._kategoriAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ck._aciklama;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return sonuc;
        }

        public bool KategoriKontrolByGuncelle(string KategoriAd, int KategoriNo)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from Kategoriler where Silindi = 0 and KategoriAd=@KategoriAd and KategoriNo!=@KategoriNo", conn);
            comm.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = KategoriAd;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = KategoriNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    sonuc = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return sonuc;
        }

        public bool KategoriSil(int KategoriNo)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Kategoriler set Silindi=1 where KategoriNo=@KategoriNo ", conn);
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = KategoriNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();

            return sonuc;
        }

        public bool KategorileriGuncelle(string Ad, string Aciklama, int KategoriNo)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Kategoriler set  KategoriAd=@KategoriAd, Aciklama=@Aciklama where KategoriNo=@KategoriNo", conn);
            comm.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = Aciklama;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = KategoriNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return sonuc;
        }
        public ArrayList KategorileriGetir()
        {
            ArrayList alist = new ArrayList();
            SqlCommand comm = new SqlCommand("Select KAtegoriNo,KategoriAd from Kategoriler where silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        cKategori c = new cKategori();
                        c._kategoriNo = Convert.ToInt32(dr[0]);
                        c._kategoriAd = (dr[1].ToString());
                        alist.Add(c);
                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return alist;
        }
        public override string ToString()
        {
            return _kategoriAd;
        }


    }
}
