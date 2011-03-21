using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    class DTO_CAT
    {
        int intID;
        public int IntID        
        {
            get { return intID; }
            set { intID = value; }
        }

        string strName;
        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }

        string strDesc;
        public string StrDesc        
        {
            get { return strDesc; }
            set { strDesc = value; }
        }
    }
}
