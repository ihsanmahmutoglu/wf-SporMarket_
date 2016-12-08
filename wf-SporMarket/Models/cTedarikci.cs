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
    class cTedarikci
    {
        private int _firmaID;
        private string _unvan;
        private string _yetkili;
        private string _telefon;
        private string _adres;
        private string _il;
        private string _ilce;
        private string _vergiNo;
        private string _vergidairesi;

        #region Properties
        public int FirmaID
        {
            get
            {
                return _firmaID;
            }

            set
            {
                _firmaID = value;
            }
        }

        public string Unvan
        {
            get
            {
                return _unvan;
            }

            set
            {
                _unvan = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Yetkili
        {
            get
            {
                return _yetkili;
            }

            set
            {
                _yetkili = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
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

        public string VergiNo
        {
            get
            {
                return _vergiNo;
            }

            set
            {
                _vergiNo = value;
            }
        }

        public string Vergidairesi
        {
            get
            {
                return _vergidairesi;
            }

            set
            {
                _vergidairesi = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public void TedarikcileriGetir(string Unvan, string Yetkili, string tel, string il, string ilce, string vergino, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FirmaID,Unvan,Yetkili,Telefon,Adres,il,ilce,VergiNo,VergiDairesi from Tedarikciler where Silindi=0 and Unvan like @Unvan + '%' and Yetkili like @Yetkili + '%' and Telefon like @tel + '%' and il like @il + '%' and ilce like @ilce + '%' and VergiNo like @vergino + '%' ", conn);
            comm.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = Unvan;
            comm.Parameters.Add("@Yetkili", SqlDbType.VarChar).Value = Yetkili;
            comm.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            comm.Parameters.Add("@il", SqlDbType.VarChar).Value = il;
            comm.Parameters.Add("@ilce", SqlDbType.VarChar).Value = ilce;
            comm.Parameters.Add("@vergino", SqlDbType.VarChar).Value = vergino;
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
        public void TedarikcileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FirmaID,Unvan,Yetkili,Telefon,Adres,il,ilce,VergiNo,VergiDairesi from Tedarikciler where Silindi=0 ", conn);
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
                        liste.Items[i].SubItems.Add(dr[8].ToString());
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
        public DataSet TedarikcileriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Unvan,Yetkili,Telefon,Adres,il,ilce,VergiNo,VergiDairesi from Tedarikciler where Silindi=0 ", conn);
            try
            {
                da.Fill(ds, "Tedarikciler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }
        public int KacinciTedarikci(int ID)
        {
            int kacinci = 0;
            SqlCommand comm = new SqlCommand("select count(*) from Tedarikciler where Silindi=0 and FirmaID < @FirmaID", conn);
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = ID;
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
        public bool TedarikciKontrol(string unvan)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select count(*) from Tedarikciler where Silindi=0 and Unvan=@unvan", conn);
            comm.Parameters.Add("@unvan", SqlDbType.VarChar).Value = unvan;
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
        public bool TedarikciKontrol(string unvan, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select count(*) from Tedarikciler where Silindi=0 and Unvan=@unvan and FirmaID!=@ID", conn);
            comm.Parameters.Add("@unvan", SqlDbType.VarChar).Value = unvan;
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
        public bool TedarikciTanimla(cTedarikci td)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Tedarikciler(Unvan,Yetkili,Telefon,Adres,il,ilce,VergiNo,VergiDairesi) values(@Unvan,@Yetkili,@Telefon,@Adres,@il,@ilce,@VergiNo,@VergiDairesi)", conn);
            comm.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = td._unvan;
            comm.Parameters.Add("@Yetkili", SqlDbType.VarChar).Value = td._yetkili;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = td._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = td._adres;
            comm.Parameters.Add("@il", SqlDbType.VarChar).Value = td._il;
            comm.Parameters.Add("@ilce", SqlDbType.VarChar).Value = td._ilce;
            comm.Parameters.Add("@VergiNo", SqlDbType.VarChar).Value = td._vergiNo;
            comm.Parameters.Add("@VergiDairesi", SqlDbType.VarChar).Value = td._vergidairesi;
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
        public bool TedarikciGuncelle(cTedarikci td)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Tedarikciler set Unvan=@Unvan,Yetkili=@Yetkili,Telefon=@Telefon,Adres=@Adres,il=@il,ilce=@ilce,VergiNo=@VergiNo,VergiDairesi=@VergiDairesi where FirmaID=@FirmaID", conn);
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = td._firmaID;
            comm.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = td._unvan;
            comm.Parameters.Add("@Yetkili", SqlDbType.VarChar).Value = td._yetkili;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = td._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = td._adres;
            comm.Parameters.Add("@il", SqlDbType.VarChar).Value = td._il;
            comm.Parameters.Add("@ilce", SqlDbType.VarChar).Value = td._ilce;
            comm.Parameters.Add("@VergiNo", SqlDbType.VarChar).Value = td._vergiNo;
            comm.Parameters.Add("@VergiDairesi", SqlDbType.VarChar).Value = td._vergidairesi;
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
        public bool TedarikciSil(int ID)
        {
            bool sonuc = false;

            SqlCommand comm = new SqlCommand("Update Tedarikciler set Silindi=1 where FirmaID=@ID", conn);
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
