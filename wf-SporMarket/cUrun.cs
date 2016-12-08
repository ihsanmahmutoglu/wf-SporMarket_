using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SporMarket
{
    class cUrun
    {
        private int _urunID;
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
        #endregion
    }
}
