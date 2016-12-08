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
    class cFatura
    {
        private int _faturaID;
        private string _faturaKodu;
        private int _musteriNo;
        private int _kullaniciNo;
        private DateTime _tarih;
        private string _faturaTipi;
        private string _islemTipi;
        private double _kdvsizTopTutar;
        private double _kdvliTopTutar;

        #region Properties
        public int FaturaID
        {
            get
            {
                return _faturaID;
            }

            set
            {
                _faturaID = value;
            }
        }



        public int MusteriNo
        {
            get
            {
                return _musteriNo;
            }

            set
            {
                _musteriNo = value;
            }
        }

        public int KullaniciNo
        {
            get
            {
                return _kullaniciNo;
            }

            set
            {
                _kullaniciNo = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public string FaturaTipi
        {
            get
            {
                return _faturaTipi;
            }

            set
            {
                _faturaTipi = value;
            }
        }

        public string IslemTipi
        {
            get
            {
                return _islemTipi;
            }

            set
            {
                _islemTipi = value;
            }
        }

        public double KdvsizTopTutar
        {
            get
            {
                return _kdvsizTopTutar;
            }

            set
            {
                _kdvsizTopTutar = value;
            }
        }

        public double KdvliTopTutar
        {
            get
            {
                return _kdvliTopTutar;
            }

            set
            {
                _kdvliTopTutar = value;
            }
        }

        public string FaturaKodu
        {
            get
            {
                return _faturaKodu;
            }

            set
            {
                _faturaKodu = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void FaturalariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select Ad, FaturaKodu, FaturaTipi, IslemTipi, Tarih,FaturaID, MusteriID,KDvliTopTutar from  Musteriler m  inner join  Faturalar f on m.MusteriID = f.MusteriNo  where f.Silindi = 0 ", conn);
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
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
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

        public void FaturalariGetirBySorgulama(string AdaGore, string KodaGore, string FaturaTipi, string IslemTipi, ListView liste, string Tarih1, string Tarih2)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select Ad, FaturaKodu, FaturaTipi, IslemTipi, Tarih, FaturaID, MusteriID,KdvliTopTutar from  Faturalar f  inner join Musteriler m  on m.MusteriID = f.MusteriNo  where f.Silindi = 0 and Ad like @AdaGore and FaturaKodu like @KodaGore and FaturaTipi like @FaturaTipeGore and IslemTipi like  @IslemTipeGore  and Convert(Date, Tarih, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by Tarih desc ", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore + "%";
            comm.Parameters.Add("@KodaGore", SqlDbType.VarChar).Value = KodaGore + "%";
            comm.Parameters.Add("@FaturaTipeGore", SqlDbType.VarChar).Value = FaturaTipi + "%";
            comm.Parameters.Add("@IslemTipeGore", SqlDbType.VarChar).Value = IslemTipi + "%";
            comm.Parameters.Add("@Tarih1", SqlDbType.VarChar).Value = Tarih1;
            comm.Parameters.Add("@Tarih2", SqlDbType.VarChar).Value = Tarih2;
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
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
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
        public void FaturalariGetirFromFaturaDetay(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select u.HareketID, UrunNo, UrunKodu, UrunAd, BirimFiyat, Adet, KDVsizTutar, KDVliTutar, KDVliTopTutar from UrunHareket_Satis u inner join Faturalar f on u.FaturaNo = f.FaturaID where u.Silindi = 0 ", conn);
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
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
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
        public int FaturaEkle(cFatura f)
        {
            int FaturaID = 0;
            SqlCommand comm = new SqlCommand("Insert Into Faturalar (FaturaKodu, MusteriNo,KullaniciNo,Tarih,FaturaTipi,IslemTipi,KDVliTopTutar) values (@FaturaKodu, @MusteriNo,@KullaniciNo,@Tarih,@FaturaTipi,@IslemTipi,@KDVliTopTutar); Select scope_identity()", conn);
            comm.Parameters.Add("@FaturaKodu", SqlDbType.VarChar).Value = f.FaturaKodu;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = f.MusteriNo;
            comm.Parameters.Add("@KullaniciNo", SqlDbType.Int).Value = f._kullaniciNo;
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = f.Tarih;
            comm.Parameters.Add("@FaturaTipi", SqlDbType.VarChar).Value = f.FaturaTipi;
            comm.Parameters.Add("@IslemTipi", SqlDbType.VarChar).Value = f.IslemTipi;
            comm.Parameters.Add("@KDVliTopTutar", SqlDbType.Money).Value = f.KdvliTopTutar;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                FaturaID = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return FaturaID;


        }
        public DataTable FaturaBilgileriniGetir(int ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,FaturaKodu,FaturaTipi from Faturalar inner join Musteriler on Faturalar.MusteriNo=Musteriler.MusteriID where faturaID=@ID and Faturalar.silindi=0 ", conn);
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }finally { conn.Close(); }

            return dt;
        }

    }
}

