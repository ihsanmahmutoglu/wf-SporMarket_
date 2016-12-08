using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SporMarket
{
    class cFatura
    {
        private int _faturaID;
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
        #endregion
    }
}
