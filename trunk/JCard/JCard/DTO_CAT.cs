using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    class DTO_Category
    {
        long lCAT_ID;

        public long LCAT_ID
        {
            get { return lCAT_ID; }
            set { lCAT_ID = value; }
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

        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Category"/> class.
        /// </summary>
        public DTO_Category()
        {
            lCAT_ID = 1;
            strName = "";
            strDesc = "";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Category"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="desc">The desc.</param>
        public DTO_Category(string name, string desc)
        {
            strName = name;
            strDesc = desc;
        }

    }
}
