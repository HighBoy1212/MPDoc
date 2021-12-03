using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveExtract
{
    class PageInfo
    {
        private int iLength;
        private int iOffset;
        private int iPage;

        public int Offset
        {
            get
            {
                return iOffset;
            }
            set
            {
                iOffset = value;
            }
        }

        public int Length
        {
            get
            {
                return iLength;
            }
            set
            {
                iLength = value;
            }
        }

        public int Page
        {
            get
            {
                return iPage;
            }
            set
            {
                iPage = value;
            }
        }
    }
}
