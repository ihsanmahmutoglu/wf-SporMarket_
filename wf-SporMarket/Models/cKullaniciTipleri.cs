using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_SporMarket.Models
{
    class cKullaniciTipleri
    {
        private int _ktipNo;
        private string _turAd;

        #region properties
        public int KtipNo
        {
            get
            {
                return _ktipNo;
            }

            set
            {
                _ktipNo = value;
            }
        }

        public string TurAd
        {
            get
            {
                return _turAd;
            }

            set
            {
                _turAd = value;
            }
        }


        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public  void KullaniciTurleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * From KullaniciTipleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    cKullaniciTipleri  kt = new cKullaniciTipleri();
                    kt ._ktipNo = Convert.ToInt32(dr[0]);
                    kt._turAd = Convert.ToString(dr[1]);
                    liste.Items.Add(kt);
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public override string ToString()
        {
            return _turAd;
        }
    }
}
