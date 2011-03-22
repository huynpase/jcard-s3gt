using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    class DTO_Category
    {
        long cAT_ID;

        public long CAT_ID
        {
            get { return cAT_ID; }
            set { cAT_ID = value; }
        }

        string str_Name;
        public string Str_Name
        {
            get { return str_Name; }
            set { str_Name = value; }
        }

        string str_Desc;
        public string Str_Desc
        {
            get { return str_Desc; }
            set { str_Desc = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Category"/> class.
        /// </summary>
        public DTO_Category()
        {
            cAT_ID = 1;
            str_Name = "";
            str_Desc = "";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Category"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="desc">The desc.</param>
        public DTO_Category(string name, string desc)
        {
            str_Name = name;
            str_Desc = desc;
        }

    }
}
