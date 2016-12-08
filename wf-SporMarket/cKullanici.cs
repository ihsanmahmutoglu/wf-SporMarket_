using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SporMarket
{
    class cKullanici
    {
        private int _kullaniciID;
        private string _kullaniciTipi;
        private string _ad;
        private string _soyad;
        private string _sifre;

        #region Properties
        public int KullaniciID
        {
            get
            {
                return _kullaniciID;
            }

            set
            {
                _kullaniciID = value;
            }
        }

        public string KullaniciTipi
        {
            get
            {
                return _kullaniciTipi;
            }

            set
            {
                _kullaniciTipi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }
        } 
        #endregion
    }
}
