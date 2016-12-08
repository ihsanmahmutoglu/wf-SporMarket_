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
    class cUrunHareket_Stok
    {
        private int _hareketID;
        private int _irsaliyeNo;
        private int _urunId;
        private int _miktar;

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

        public int IrsaliyeNo
        {
            get
            {
                return _irsaliyeNo;
            }

            set
            {
                _irsaliyeNo = value;
            }
        }

        public int UrunId
        {
            get
            {
                return _urunId;
            }

            set
            {
                _urunId = value;
            }
        }

        public int Miktar
        {
            get
            {
                return _miktar;
            }

            set
            {
                _miktar = value;
            }
        }



        #endregion
        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public bool HareketEkle(cUrunHareket_Stok uh)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert Into UrunHareket_stok (IrsaliyeNo, UrunID,miktar) values (@IrsaliyeNo, @UrunID,@miktar)", conn);
            comm.Parameters.Add("@IrsaliyeNo", SqlDbType.Int).Value = uh._irsaliyeNo;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = uh._urunId;
            comm.Parameters.Add("@miktar", SqlDbType.Int).Value = uh._miktar;
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
        public void HareketleriGetir(ListView liste, int ID)
        {
            //            create proc sp_irsaliyeDetaylariGetir
            //@irsaliyeID int
            //            as
            //            Select HareketID,UrunKodu,UrunAdi,UrunHareket_stok.Miktar from Urunler inner join UrunHareket_stok  on Urunler.UrunID = UrunHareket_stok.UrunID  where UrunHareket_stok.Silindi = 0 and IrsaliyeNo = @irsaliyeID
            //            go

            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_irsaliyeDetaylariGetir";
            comm.Connection = conn;
            comm.Parameters.Add("@irsaliyeID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[i].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());

                        i++;
                    }

                }
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

        }


    }
}
