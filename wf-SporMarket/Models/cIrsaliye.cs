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
    class cIrsaliye
    {
        private int _irsaliyeID;
        private string _irsaliyeKodu;
        private int _firmaID;
        private int _kullaniciNo;
        private DateTime _irsaliyeTarihi;
        private string _irsaliyeTuru;

        #region Properties
        public int IrsaliyeID
        {
            get
            {
                return _irsaliyeID;
            }

            set
            {
                _irsaliyeID = value;
            }
        }

       

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

        public DateTime IrsaliyeTarihi
        {
            get
            {
                return _irsaliyeTarihi;
            }

            set
            {
                _irsaliyeTarihi = value;
            }
        }

        public string IrsaliyeTuru
        {
            get
            {
                return _irsaliyeTuru;
            }

            set
            {
                _irsaliyeTuru = value;
            }
        }

        public string IrsaliyeKodu
        {
            get
            {
                return _irsaliyeKodu;
            }

            set
            {
                _irsaliyeKodu = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void IrsaliyeleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select Unvan, IrsaliyeKodu, IrsaliyeTuru, IrsaliyeTarihi, IrsaliyeID, i.FirmaID from  Irsaliyeler i  inner join  Tedarikciler t on i.FirmaID = t.FirmaID  where i.Silindi = 0 ", conn);
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

        public void IrsaliyeleriGetirBySorgulama(string UnvanaGore, string KodaGore, string TureGore, ListView liste, DateTime Tarih1, DateTime Tarih2)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select Unvan, IrsaliyeKodu, IrsaliyeTuru, IrsaliyeTarihi, IrsaliyeID, i.FirmaID from  Irsaliyeler i  inner join  Tedarikciler t on i.FirmaID = t.FirmaID  where i.Silindi = 0 and Unvan like @UnvanaGore and IrsaliyeKodu like @KodaGore and IrsaliyeTuru  like  @TureGore and Convert(Date,IrsaliyeTarihi, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by IrsaliyeTarihi desc", conn);
            comm.Parameters.Add("@UnvanaGore", SqlDbType.VarChar).Value = UnvanaGore + "%";
            comm.Parameters.Add("@KodaGore", SqlDbType.VarChar).Value = KodaGore + "%";
            comm.Parameters.Add("@TureGore", SqlDbType.VarChar).Value = TureGore + "%";
            comm.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = Tarih1;
            comm.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = Tarih2;
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

        public int irsaliyeEkle(cIrsaliye irsaliye)
        {
            int irsaliyeID = 0;
            SqlCommand comm = new SqlCommand("Insert Into Irsaliyeler (IrsaliyeKodu,FirmaID,KullaniciNo,IrsaliyeTarihi,IrsaliyeTuru) values (@IrsaliyeKodu,@FirmaID,@KullaniciNo,@IrsaliyeTarihi,@IrsaliyeTuru); Select scope_identity()", conn);
            comm.Parameters.Add("@IrsaliyeKodu", SqlDbType.VarChar).Value = irsaliye._irsaliyeKodu;
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = irsaliye._firmaID;
            comm.Parameters.Add("@KullaniciNo", SqlDbType.Int).Value = irsaliye._kullaniciNo;
            comm.Parameters.Add("@IrsaliyeTarihi", SqlDbType.DateTime).Value = irsaliye.IrsaliyeTarihi;
            comm.Parameters.Add("@IrsaliyeTuru", SqlDbType.VarChar).Value = irsaliye.IrsaliyeTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                irsaliyeID = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return irsaliyeID;


        }
        public ArrayList IrsaliyeBilgileriniGetir(int irsaliyeID)
        {
            //stored prodecures
            // create proc sp_irsaliyeBilgileriGetir
            //@irsaliyeID int
            //as
            //Select Unvan,Yetkili,IrsaliyeKodu,IrsaliyeTuru,IrsaliyeTarihi from Irsaliyeler inner join Tedarikciler  on Tedarikciler.FirmaID = Irsaliyeler.FirmaID  where Irsaliyeler.Silindi = 0 and IrsaliyeID = @irsaliyeID
            //go
            ArrayList alist = new ArrayList();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_irsaliyeBilgileriGetir";
            comm.Parameters.Add("@irsaliyeID", SqlDbType.Int).Value = irsaliyeID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                dr.Read();
                cTedarikci t = new cTedarikci();
                t.Unvan = dr[0].ToString();
                t.Yetkili = dr[1].ToString();
                cIrsaliye ir = new cIrsaliye();
                ir._irsaliyeKodu = dr[2].ToString();
                ir._irsaliyeTuru = dr[3].ToString();
                ir._irsaliyeTarihi = Convert.ToDateTime(dr[4]);

                alist.Add(t);
                alist.Add(ir);

                dr.Close();
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();


            }
            return alist;

        }
    }
}
