using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SporMarket
{
    class cTedarikci
    {
        private int _firmaID;
        private string _unvan;
        private string _yetkili;
        private string _telefon;
        private string _adres;
        private string _il;
        private string _ilce;
        private string _vergiNo;
        private string _vergidairesi;

        #region Properties
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

        public string Unvan
        {
            get
            {
                return _unvan;
            }

            set
            {
                _unvan = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Yetkili
        {
            get
            {
                return _yetkili;
            }

            set
            {
                _yetkili = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
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

        public string VergiNo
        {
            get
            {
                return _vergiNo;
            }

            set
            {
                _vergiNo = value;
            }
        }

        public string Vergidairesi
        {
            get
            {
                return _vergidairesi;
            }

            set
            {
                _vergidairesi = value;
            }
        } 
        #endregion
    }
}
