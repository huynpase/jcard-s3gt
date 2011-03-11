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
    class DAO_Grammar
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors
        public DAO_Grammar(string str_dts)
        {
            str_datasource = str_dts;
        }
        #endregion

        #region methods
        /// <summary>
        /// Get all grammar cards by input Level
        /// </summary>
        /// <param name="strLevel">Input Level</param>
        /// <returns>List of grammar cards</returns>
        public ArrayList GetGrammarCarByLevel(string strLevel)
        {
            ArrayList result = new ArrayList();

            DataProvider provider = new DataProvider(str_datasource);

            String sql = "Select * from S3GT_GRAM where Level='" + strLevel + "'";
            IDataReader reader = provider.excuteQuery(sql);

            string tempEx = "";

            while (reader.Read())
            {
                DTO_Grammar gramCard = new DTO_Grammar();
                gramCard.LGR_ID = long.Parse(reader["GR_ID"].ToString());
                gramCard.STR_Level = strLevel;
                gramCard.STR_Sample = reader["Sample"].ToString();
                gramCard.STR_Syntax = reader["Syntax"].ToString();
                gramCard.STR_Meaning_JP = reader["Meaning_JP"].ToString();
                gramCard.STR_Meaning_VN = reader["Meaning_VN"].ToString();

                for (int i = 0; i < Constants.MAX_GRAMMAR_EXAMPLE; i++)
                {
                    tempEx = reader["Example" + (i + 1).ToString()].ToString();
                    gramCard.ArrExample[i] = tempEx;
                }

                result.Add(gramCard);
            }
            reader.Close();

            return result;
        }

        /// <summary>
        /// Deletes all the grammar cards in S3GT database.
        /// </summary>
        /// <param name="strKyu">The String of kyu.</param>
        /// <param name="dbFile">The S3GT databse file path.</param>
        /// <returns></returns>
        public Boolean DeleteGrammarCards(int strKyu, string dbFile)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectData(dbFile);
            //
            string strSQL = "DELETE * FROM S3GT_GRAM WHERE Kyu=?";
            try
            {
                OleDbCommand cmd = new OleDbCommand(strSQL, cn);
                cmd.Parameters.Add("@Kyu", OleDbType.Integer);
                cmd.Parameters["@Kyu"].Value = strKyu;
                //
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cn.Close();
                return true;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Inserts the grammar cards to S3GT_DB.
        /// </summary>
        /// <param name="arrDTOGram">The array of  DTO grammar cards.</param>
        /// <param name="strKyu">The String of kyu.</param>
        /// <param name="dbFile">The database file.</param>
        /// <returns></returns>
        public Boolean InsertGrammarCards(DTO_Grammar[] arrDTOGram, String strKyu, String dbFile)
        {
            OleDbConnection cn = null;
            OleDbCommand cmd = null;
            string strSQL = "";
            int n = arrDTOGram.Length;
            int i;
            int j;
            //           
            try
            {
                //Initial String SQL
                cn = DataProvider.ConnectData(dbFile);
                string strSQL1 = "INSERT INTO S3GT_GRAM(Kyu,Sample,Syntax,Meaning_JP,Meaning_VN";
                string strSQL2 = ") values (?,?,?,?,?";
                //
                j = 0;
                for (; j < Constants.MAX_GRAMMAR_EXAMPLE; j++)
                {
                    strSQL1 += ",Example" + (j + 1).ToString();
                    strSQL2 += ",?";
                }
                strSQL2 += ")";
                strSQL = strSQL1 + strSQL2 + "";
                //
                i = 0;
                for (; i < n; i++)
                {
                    cmd = new OleDbCommand(strSQL, cn);
                    //Add Type of Value
                    cmd.Parameters.Add("@Kyu", OleDbType.WChar);
                    cmd.Parameters.Add("@Sample", OleDbType.WChar);
                    cmd.Parameters.Add("@Syntax", OleDbType.WChar);
                    cmd.Parameters.Add("@Meaning_JP", OleDbType.WChar);
                    cmd.Parameters.Add("@Meaning_VN", OleDbType.WChar);

                    //Add Values
                    cmd.Parameters["@Kyu"].Value = strKyu;
                    cmd.Parameters["@Sample"].Value = arrDTOGram[i].STR_Sample;
                    cmd.Parameters["@Syntax"].Value = arrDTOGram[i].STR_Syntax;
                    cmd.Parameters["@Meaning_JP"].Value = arrDTOGram[i].STR_Meaning_JP;
                    cmd.Parameters["@Meaning_VN"].Value = arrDTOGram[i].STR_Meaning_VN;

                    ////Execute Examples 
                    j = 0;
                    if (arrDTOGram[i].ArrExample.Count <= Constants.MAX_GRAMMAR_EXAMPLE)
                    {
                        for (; j < arrDTOGram[i].ArrExample.Count; j++)
                        {
                            String tmpStr = "@Example";
                            tmpStr += (j + 1).ToString();
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = arrDTOGram[i].ArrExample[j].ToString();
                        }
                        for (; j < Constants.MAX_GRAMMAR_EXAMPLE; j++)
                        {
                            String tmpStr = "@Example";
                            tmpStr += (j + 1).ToString();
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = "";
                        }
                    }
                    else
                    {
                        for (; j < Constants.MAX_GRAMMAR_EXAMPLE; j++)
                        {
                            String tmpStr = "@Example";
                            tmpStr += (j + 1).ToString();
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = arrDTOGram[i].ArrExample[j].ToString();
                        }
                    }

                    //Execute
                    cmd.ExecuteNonQuery();
                }
                //Close
                cmd.Cancel();
                cn.Close();
                return true;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Gets the excel sheet names.
        /// </summary>
        /// <param name="excelFile">The excel file.</param>
        /// <returns></returns>
        static String[] GetExcelSheetNames(string excelFile)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;
            try
            {
                // Connection String. Change the excel file to the file you  
                // will search.  
                String connString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                "Data Source=" + excelFile + ";Extended Properties=Excel 8.0;";
                // Create connection object by using the preceding connection string. 
                objConn = new OleDbConnection(connString);
                objConn.Open();
                // Lấy về dữ liệu   
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                {
                    return null;
                }
                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;
                // Add the sheet name to the string array.  
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }
                return excelSheets;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                // Clean up.  
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

        /// <summary>
        /// Reads the excel file.
        /// </summary>
        /// <param name="exFilePath">The excel file path.</param>
        /// <returns></returns>
        public DTO_Grammar[] ReadExcelFile(String exFilePath)
        {
            DTO_Grammar[] result = null;
            try
            {
                string sheetname = GetExcelSheetNames(exFilePath)[0];
                string srcConnString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + exFilePath + @";Extended Properties=""Excel 8.0;HDR=YES;""";
                string srcQuery = "SELECT * FROM[" + sheetname + "]";
                OleDbConnection srcConn = new OleDbConnection(srcConnString);
                srcConn.Open();
                OleDbCommand objCmdSelect = new OleDbCommand(srcQuery, srcConn);
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(objCmdSelect);
                da.Fill(ds, sheetname);
                srcConn.Close();
                //Check the right data
                if (String.Compare(ds.Tables[0].Columns["MauCau"].ToString(), "MauCau") != 0 ||
                    String.Compare(ds.Tables[0].Columns["CuPhap"].ToString(), "CuPhap") != 0 ||
                    String.Compare(ds.Tables[0].Columns["YNghia_JP"].ToString(), "YNghia_JP") != 0 ||
                    String.Compare(ds.Tables[0].Columns["YNghia_VN"].ToString(), "YNghia_VN") != 0)
                    return result;
                //Return to suitable result
                int n = ds.Tables[0].Rows.Count;
                int m = ds.Tables[0].Columns.Count;
                result = new DTO_Grammar[n];
                int i = 0;
                int j;
                for (; i < n; i++)
                {
                    result[i] = new DTO_Grammar();
                    result[i].STR_Sample = ds.Tables[0].Rows[i][0].ToString();
                    result[i].STR_Syntax = ds.Tables[0].Rows[i][1].ToString();
                    result[i].STR_Meaning_JP = ds.Tables[0].Rows[i][2].ToString();
                    result[i].STR_Meaning_VN = ds.Tables[0].Rows[i][3].ToString();
                    //Example
                    j = 4;
                    for (; j < m; j++)
                        result[i].ArrExample.Add(ds.Tables[0].Rows[i][j].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return result;
            }
            return result;
        }
        #endregion
    }
}
