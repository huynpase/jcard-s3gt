using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace J_Card_ImportData
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
        /// Adds the new category.
        /// </summary>
        /// <param name="dtoCat">The DTO_Category.</param>
        /// <param name="dbFile">The S3GT database file.</param>
        /// <returns></returns>
        public Boolean addNewCategory(DTO_Category dtoCat)
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
                cmd.Parameters["@CAT_Name"].Value = dtoCat.Str_Name;
                cmd.Parameters["@CAT_Desc"].Value = dtoCat.Str_Desc;
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

        /// <summary>
        /// Reads all categories.
        /// </summary>
        /// <param name="dbFile">The S3GT database file.</param>
        /// <returns></returns>
        public ArrayList readAllCategories()
        {
            ArrayList result = new ArrayList();
            string strSQL = "";
            try
            {
                DataProvider provider = new DataProvider(str_datasource);
                strSQL = "SELECT * FROM S3GT_CAT";
                IDataReader reader = provider.excuteQuery(strSQL);
                //Reading                
                while (reader.Read())
                {
                    DTO_Category tmp = new DTO_Category();
                    tmp.CAT_ID = long.Parse(reader["CAT_ID"].ToString());
                    tmp.Str_Name = reader["CAT_Name"].ToString();
                    tmp.Str_Desc = reader["CAT_Desc"].ToString();
                    result.Add(tmp);
                }
                //
                reader.Close();
                //
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        #endregion
    }
}
