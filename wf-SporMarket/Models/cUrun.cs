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
    class cUrun
    {
        private int _urunID;
        private string _urunAdi;
        private string _urunKodu;
        private int _markano;
        private int _kategorino;
        private int _numara;
        private double _birimfiyat;
        private int _miktar;
        private int _kritikseviye;

        #region Properties
        public int UrunID
        {
            get
            {
                return _urunID;
            }

            set
            {
                _urunID = value;
            }
        }

        public string UrunKodu
        {
            get
            {
                return _urunKodu;
            }

            set
            {
                _urunKodu = value;
            }
        }

        public int Markano
        {
            get
            {
                return _markano;
            }

            set
            {
                _markano = value;
            }
        }

        public int Kategorino
        {
            get
            {
                return _kategorino;
            }

            set
            {
                _kategorino = value;
            }
        }

        public int Numara
        {
            get
            {
                return _numara;
            }

            set
            {
                _numara = value;
            }
        }



        public double Birimfiyat
        {
            get
            {
                return _birimfiyat;
            }

            set
            {
                _birimfiyat = value;
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

        public int Kritikseviye
        {
            get
            {
                return _kritikseviye;
            }

            set
            {
                _kritikseviye = value;
            }
        }

        public string UrunAdi
        {
            get
            {
                return _urunAdi;
            }

            set
            {
                _urunAdi = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);



        public DataTable UrunleriGetirBySorgulama(string Kod, string Ad, string marka, string kategori, string numara)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select UrunID,UrunKodu, UrunAdi as Ürün, MarkaAd as Marka, KategoriAd as Kategori, Numara, BirimFiyat , Miktar, Kritikseviye from Urunler u inner join Kategoriler k on k.kategoriNo=u.KategoriNo inner join Markalar m on m.markaıd=u.markaNo where u.silindi=0 and UrunKodu like @Kod and UrunAdi like @Ad and MarkaAd like @marka and kategoriAd like @kategori and numara like @numara  ", conn);
            da.SelectCommand.Parameters.Add("@Kod", SqlDbType.VarChar).Value = Kod + "%";
            da.SelectCommand.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad + "%";
            da.SelectCommand.Parameters.Add("@marka", SqlDbType.VarChar).Value = marka + "%";
            da.SelectCommand.Parameters.Add("@kategori", SqlDbType.VarChar).Value = kategori + "%";
            da.SelectCommand.Parameters.Add("@numara", SqlDbType.VarChar).Value = numara + "%";
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
        public void UrunKoduGetir(ListBox liste, string kod)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select UrunID,UrunKodu,UrunAdi from Urunler where silindi=0 and UrunKodu like @Kod", conn);
            comm.Parameters.Add("@Kod", SqlDbType.VarChar).Value = kod + "%";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        cUrun u = new cUrun();
                        u._urunID = Convert.ToInt32(dr[0]);
                        u._urunKodu = Convert.ToString(dr[1]);
                        u._urunAdi = Convert.ToString(dr[2]);
                        liste.Items.Add(u);
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
        public override string ToString()
        {
            return UrunKodu;
        }

        public bool StokGuncelleFromStoku(int Id, int miktar)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update  Urunler set miktar+=@miktar where urunID=@urunID", conn);
            comm.Parameters.Add("@miktar", SqlDbType.Int).Value = miktar;
            comm.Parameters.Add("@urunID", SqlDbType.Int).Value = Id;
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
            conn.Close();
            return sonuc;
        }
        public cUrun UrunleriGetirFromSatis(int ID)
        {
            cUrun u = new cUrun();
            SqlCommand comm = new SqlCommand("Select UrunID, UrunKodu, UrunAdi, BirimFiyat from Urunler where UrunID=@ID and silindi=0", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();

                    u._urunID = Convert.ToInt32(dr[0]);
                    u._urunKodu = Convert.ToString(dr[1]);
                    u._urunAdi = Convert.ToString(dr[2]);
                    u._birimfiyat = Convert.ToDouble(dr[3]);

                }
                dr.Close();

            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            conn.Close();
            return u;
        }

        public void UrunleriGetir(ListView liste)
        {
            SqlCommand comm = new SqlCommand();
            liste.Items.Clear();
            comm.CommandText = "sp_UrunTabloGetir";
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
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
                    liste.Items[i].SubItems.Add(dr[10].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
        }

        public bool UrunKontrol(string UrunKodu, string UrunAd)
        {
            SqlCommand comm = new SqlCommand();
            bool sonuc = false;
            comm.CommandText = "sp_UrunKontrol";
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = UrunAd;
            comm.Parameters.Add("@Sonuc", SqlDbType.Bit);
            comm.Parameters["@Sonuc"].Direction = ParameterDirection.Output;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.Parameters["@Sonuc"].Value);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return sonuc;
        }

        public bool UrunEkle(string Kod, string Ad, int KategoriNo, int MarkaNo, int Numara, double BirimFiyat, int KritikSeviye)
        {
            bool Kayit = false;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "sp_UrunEkle";
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = Kod;
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@MarkaNo", SqlDbType.Int).Value = MarkaNo;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = KategoriNo;
            comm.Parameters.Add("@Numara", SqlDbType.Int).Value = Numara;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = BirimFiyat;
            comm.Parameters.Add("@kritikseviye", SqlDbType.Int).Value = KritikSeviye;
            comm.Parameters.Add("@Sonuc", SqlDbType.Bit);
            comm.Parameters["@Sonuc"].Direction = ParameterDirection.Output;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                Kayit = Convert.ToBoolean(comm.Parameters["@Sonuc"].Value);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return Kayit;
        }

        public bool Varmi(int ID, string Kod)
        {
            bool Kayit = false;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "sp_UrunVarmi";
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = Kod;
            comm.Parameters.Add("@Sonuc", SqlDbType.Bit);
            comm.Parameters["@Sonuc"].Direction = ParameterDirection.Output;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                Kayit = Convert.ToBoolean(comm.Parameters["@Sonuc"].Value);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return Kayit;
        }

        public bool UrunGuncelle(int ID, string Kod, string Ad, int KategoriNo, int MarkaNo, int Numara, double BirimFiyat, int KritikSeviye)
        {
            bool Kayit = false;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "sp_UrunGuncelle";
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = Kod;
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@MarkaNo", SqlDbType.Int).Value = MarkaNo;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = KategoriNo;
            comm.Parameters.Add("@Numara", SqlDbType.Int).Value = Numara;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = BirimFiyat;
            comm.Parameters.Add("@kritikseviye", SqlDbType.Int).Value = KritikSeviye;
            comm.Parameters.Add("@Sonuc", SqlDbType.Bit);
            comm.Parameters["@Sonuc"].Direction = ParameterDirection.Output;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                Kayit = Convert.ToBoolean(comm.Parameters["@Sonuc"].Value);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return Kayit;
        }

        public bool UrunSil(int UrunID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "sp_UrunSil";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            comm.Parameters.Add("@Sonuc", SqlDbType.Bit);
            comm.Parameters["@Sonuc"].Direction = ParameterDirection.Output;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(comm.Parameters["@Sonuc"].Value);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return sonuc;
        }

    }
}
