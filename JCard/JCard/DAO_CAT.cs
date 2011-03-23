using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace JCard
{
    class DAO_Category
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="DAO_Category"/> class.
        /// </summary>
        /// <param name="str_dts">The STR_DTS.</param>
        public DAO_Category(string str_dts)
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
                DTO_Category cat = new DTO_Category();
                cat.LCAT_ID = int.Parse(reader["CAT_ID"].ToString());
                cat.StrName = reader["CAT_Name"].ToString();
                cat.StrDesc = reader["CAT_Desc"].ToString();

                result.Add(cat);
            }
            reader.Close();

            return result;
        }

        /// <summary>
        /// Adds the new category.
        /// </summary>
        /// <param name="dtoCat">The DTO_Category.</param>
        /// <param name="dbFile">The S3GT database file.</param>
        /// <returns></returns>
        public Boolean AddNewCategory(DTO_Category dtoCat)
        {
            OleDbConnection cn = null;
            OleDbCommand cmd = null;
            string strSQL = "";
            try
            {
                //Initial String SQL
                cn = DataProvider.ConnectData(str_datasource);
                strSQL = "INSERT INTO S3GT_CAT(CAT_Name,CAT_Desc)VALUES(?,?)" +
                "";
                //
                cmd = new OleDbCommand(strSQL, cn);
                //Add Type of Value
                cmd.Parameters.Add("@CAT_Name", OleDbType.WChar);
                cmd.Parameters.Add("@CAT_Desc", OleDbType.WChar);

                //Add Values
                cmd.Parameters["@CAT_Name"].Value = dtoCat.StrName;
                cmd.Parameters["@CAT_Desc"].Value = dtoCat.StrDesc;
                //Execute
                cmd.ExecuteNonQuery();
                //Close      
                cmd.Cancel();
                cn.Close();
                return true;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
