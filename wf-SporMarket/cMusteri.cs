using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SporMarket
{
    class cMusteri
    {
        private int _musteriID;
        private string _ad;
        private string _soyad;
        private string _telefon;
        private string _adres;
        private string _il;
        private string _ilce;

        #region Properties
        public int MusteriID
        {
            get
            {
                return _musteriID;
            }

            set
            {
                _musteriID = value;
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
                _ad = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower();
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
        #endregion
    }
}
