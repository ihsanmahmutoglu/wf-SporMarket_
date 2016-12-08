using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_SporMarket
{
    class cIrsaliye
    {
        private int _irsaliyeID;
        private int _firmaID;
        private int _kullaniciNo;
        private DateTime _sevkTarihi;
        private DateTime _irsaliyeTarihi;
        private string _irsaliyeTuru;

        #region Properties
        public int IrsaliyeID
        {
            get
            {
                return _irsaliyeID;
            }

            set
            {
                _irsaliyeID = value;
            }
        }

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

        public DateTime SevkTarihi
        {
            get
            {
                return _sevkTarihi;
            }

            set
            {
                _sevkTarihi = value;
            }
        }

        public DateTime IrsaliyeTarihi
        {
            get
            {
                return _irsaliyeTarihi;
            }

            set
            {
                _irsaliyeTarihi = value;
            }
        }

        public string IrsaliyeTuru
        {
            get
            {
                return _irsaliyeTuru;
            }

            set
            {
                _irsaliyeTuru = value;
            }
        } 
        #endregion
    }
}
