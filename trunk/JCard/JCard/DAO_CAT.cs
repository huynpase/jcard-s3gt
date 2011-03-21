using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace JCard
{
    class DAO_CAT
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors
        public DAO_CAT(string str_dts)
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
            ArrayList result = new ArrayList();

            DataProvider provider = new DataProvider(str_datasource);

            String sql = "Select * from S3GT_CAT";
            IDataReader reader = provider.excuteQuery(sql);

            while (reader.Read())
            {
                DTO_CAT cat = new DTO_CAT();
                cat.IntID = int.Parse(reader[""].ToString());
                cat.StrName = reader[""].ToString();
                cat.StrDesc = reader[""].ToString();

                result.Add(cat);
            }
            reader.Close();

            return result;
        }
        #endregion
    }
}
