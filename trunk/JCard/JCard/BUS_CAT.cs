using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace JCard
{
    class BUS_CAT
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors
        public BUS_CAT(string str_dts)
        {
            str_datasource = str_dts;
        }
        #endregion

        #region methods
        /// <summary>
        /// Get all category
        /// </summary>
        public ArrayList GetAllCats()
        {
            DAO_CAT daoCAT = new DAO_CAT(str_datasource);
            return daoCAT.GetAllCats();
        }
        #endregion
    }
}
