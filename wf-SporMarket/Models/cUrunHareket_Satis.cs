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
    class cUrunHareket_Satis
    {
        private int _hareketID;
        private int _faturaNo;
        private int _urunNo;
        private double _birimFiyat;
        private int _adet;

        #region Properties
        public int HareketID
        {
            get
            {
                return _hareketID;
            }

            set
            {
                _hareketID = value;
            }
        }

        public int FaturaNo
        {
            get
            {
                return _faturaNo;
            }

            set
            {
                _faturaNo = value;
            }
        }

        public int UrunNo
        {
            get
            {
                return _urunNo;
            }

            set
            {
                _urunNo = value;
            }
        }



        public double BirimFiyat
        {
            get
            {
                return _birimFiyat;
            }

            set
            {
                _birimFiyat = value;
            }
        }

        public int Adet
        {
            get
            {
                return _adet;
            }

            set
            {
                _adet = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void KasaHareketleriniGetir(ListView liste, string Tarih1, string Tarih2)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select f.Tarih,FaturaNo,UrunNo,Ad,Soyad,BirimFiyat,Adet,KDVsizTutar,KDVliTutar,ToplamTutar from UrunHareket_Satis u inner join Faturalar f on u.FaturaNo=f.FaturaID inner join Musteriler m on f.MusteriNo=m.MusteriID where u.Silindi=0 and Convert(Date,Tarih, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by Tarih desc", conn);
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
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
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
        public void KasaHareketleriniGetirBySorgulama(ListView liste, string FaturaNo, string UrunNo, string Tarih1, string Tarih2)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select f.Tarih,FaturaNo,UrunNo,Ad,Soyad,BirimFiyat,Adet,KDVsizTutar,KDVliTutar,KDVliTopTutar from UrunHareket_Satis u inner join Faturalar f on u.FaturaNo=f.FaturaID inner join Musteriler m on f.MusteriNo=m.MusteriID where u.Silindi=0 and FaturaNo=@FaturaNo and UrunNo=@UrunNo and Convert(Date,Tarih, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by Tarih desc", conn);
            comm.Parameters.Add("@FaturaNo", SqlDbType.VarChar).Value = FaturaNo;
            comm.Parameters.Add("@UrunNo", SqlDbType.VarChar).Value = UrunNo;
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
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
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
        public DataTable KasaHareketleriniGetir(int faturaID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select HareketID,UrunKodu,UrunAdi,urunhareket_Satis.BirimFiyat,adet,KDVsizTutar,KDVliTutar from urunhareket_Satis inner join Urunler on urunhareket_satis.UrunNo=urunler.urunıd where urunhareket_Satis.silindi=0 and faturaNo=@faturaID ", conn);
            da.SelectCommand.Parameters.Add("@faturaID", SqlDbType.Int).Value = faturaID;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            return dt;

        }
        public bool KasaHareketEkle(cUrunHareket_Satis uhs)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert Into UrunHareket_Satis (FaturaNo,UrunNo,BirimFiyat,Adet) values (@FaturaNo,@UrunNo,@BirimFiyat,@Adet)", conn);
            comm.Parameters.Add("@FaturaNo", SqlDbType.Int).Value = uhs._faturaNo;
            comm.Parameters.Add("@UrunNo", SqlDbType.Int).Value = uhs._urunNo;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = uhs._birimFiyat;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = uhs._adet;
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
