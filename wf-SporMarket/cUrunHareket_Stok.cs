using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
