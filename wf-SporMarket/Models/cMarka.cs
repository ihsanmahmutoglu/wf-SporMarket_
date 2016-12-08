using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SporMarket.Models
{
    class cMarka
    {
        private int _markaID;
        private string _markaAd;
        private int _markaNo;

        #region Properties
        public string MarkaAd
        {
            get
            {
                return _markaAd;
            }

            set
            {
                _markaAd = value;
            }
        }

        public int MarkaNo
        {
            get
            {
                return _markaNo;
            }

            set
            {
                _markaNo = value;
            }
        }

        public int MarkaID
        {
            get
            {
                return _markaID;
            }

            set
            {
                _markaID = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public void MarkalariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select MarkaID, MarkaAd from Markalar where silindi=0 ", conn);
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

        public ArrayList MarkalariGetir()
        {
            ArrayList alist = new ArrayList();
            SqlCommand comm = new SqlCommand("Select MarkaID,MarkaAd from Markalar where silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
             
                    while (dr.Read())
                    {
                        cMarka m = new cMarka();
                        m._markaID =Convert.ToInt32( dr[0]);
                        m._markaAd  = (dr[1].ToString());
                        alist.Add(m);
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
        public bool MarkaKontrol(string MarkaAd)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from Markalar where  MarkaAd=@MarkaAd", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = MarkaAd;
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
            conn.Close();
            return sonuc;
        }

        public bool MarkaEkle(string MarkaAd)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Markalar(MarkaAd) values(@MarkaAd)", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = MarkaAd;
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

        public bool MarkalariGuncelle(string Ad, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Markalar set  MarkaAd=@MarkaAd  where MarkaID=@MarkaID", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = ID;
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

        public  bool MarkaSil(int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Markalar set Silindi=1 where MarkaID=@MarkaID ", conn);
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = ID;
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

        public bool MarkaVarmi(string ad, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from Markalar where Silindi = 0 and MarkaAd=@MarkaAd and MarkaID!=@MarkaID", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = ad;
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = ID;
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

        public override string ToString()
        {
            return _markaAd;
        }

    }
}

        
