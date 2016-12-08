using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SporMarket
{
    class cUrunHareket_Satis
    {
        private int _hareketID;
        private int _faturaNo;
        private int _urunNo;
        private double _birimFiyat;
        private int _adet;

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

        public int FaturaNo
        {
            get
            {
                return _faturaNo;
            }

            set
            {
                _faturaNo = value;
            }
        }

        public int UrunNo
        {
            get
            {
                return _urunNo;
            }

            set
            {
                _urunNo = value;
            }
        }

        public double BirimFiyat
        {
            get
            {
                return _birimFiyat;
            }

            set
            {
                _birimFiyat = value;
            }
        }

        public int Adet
        {
            get
            {
                return _adet;
            }

            set
            {
                _adet = value;
            }
        } 
        #endregion
    }
}
