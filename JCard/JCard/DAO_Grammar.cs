using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace JCard
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
        /// <param name="catID">The category ID.</param>
        /// <returns>List of grammar cards</returns>
        public ArrayList GetGrammarCardByLevel(int catID)
        {
            ArrayList result = new ArrayList();
            DataProvider provider = new DataProvider(str_datasource);
            String sql = "SELECT * FROM S3GT_GRAM WHERE CAT_ID='" + catID.ToString() + "'";
            IDataReader reader = provider.excuteQuery(sql);
            try
            {
                while (reader.Read())
                {
                    DTO_Grammar gramCard = new DTO_Grammar();
                    gramCard.LGR_ID = long.Parse(reader["GR_ID"].ToString());
                    gramCard.LCAT_ID = catID;
                    gramCard.STR_Sample = reader["Sample"].ToString();
                    gramCard.STR_Syntax = reader["Syntax"].ToString();
                    gramCard.STR_Meaning_JP = reader["Meaning_JP"].ToString();
                    gramCard.STR_Meaning_VN = reader["Meaning_VN"].ToString();

                    for (int i = 0; i < Constants.MAX_GRAMMAR_EXAMPLE; i++)
                    {
                        string tempEx = reader["Example" + (i + 1).ToString()].ToString();
                        if (tempEx != string.Empty && tempEx != null)
                            gramCard.ArrExampleJP.Add(tempEx);
                    }

                    result.Add(gramCard);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Get all Grammar Cards
        /// </summary>
        /// <returns></returns>
        public ArrayList GetAllGrammarCard()
        {
            ArrayList result = new ArrayList();
            DataProvider provider = new DataProvider(str_datasource);
            String sql = "Select * from S3GT_GRAM";
            IDataReader reader = provider.excuteQuery(sql);
            try
            {
                while (reader.Read())
                {
                    DTO_Grammar gramCard = new DTO_Grammar();
                    gramCard.LGR_ID = long.Parse(reader["GR_ID"].ToString());
                    gramCard.LCAT_ID = long.Parse(reader["CAT_ID"].ToString());
                    gramCard.STR_Sample = reader["Sample"].ToString();
                    gramCard.STR_Syntax = reader["Syntax"].ToString();
                    gramCard.STR_Meaning_JP = reader["Meaning_JP"].ToString();
                    gramCard.STR_Meaning_VN = reader["Meaning_VN"].ToString();

                    for (int i = 0; i < Constants.MAX_GRAMMAR_EXAMPLE; i++)
                    {
                        string tempEx_JP = reader["Example" + (i + 1).ToString() + "_JP"].ToString();
                        string tempEx_VN = reader["Example" + (i + 1).ToString() + "_VN"].ToString();

                        if (tempEx_JP == null) tempEx_JP = string.Empty;
                        if (tempEx_VN == null) tempEx_VN = string.Empty;

                        if ((tempEx_JP != string.Empty) || (tempEx_VN != string.Empty))
                        {
                            gramCard.ArrExampleJP.Add(tempEx_JP);
                            gramCard.ArrExampleVN.Add(tempEx_VN);
                        }
                    }

                    result.Add(gramCard);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Deletes all the grammar cards in S3GT database.
        /// </summary>
        /// <param name="catID">The category ID.</param>
        /// <returns></returns>
        public Boolean DeleteGrammarCards(int catID)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectData(str_datasource);
            //
            string strSQL = "DELETE * FROM S3GT_GRAM WHERE CAT_ID=?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            try
            {
                cmd.Parameters.Add("@CAT_ID", OleDbType.Integer);
                cmd.Parameters["@CAT_ID"].Value = catID;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Cancel();
                cn.Close();
            }
        }

        /// <summary>
        /// Inserts the grammar cards to S3GT_DB.
        /// </summary>
        /// <param name="arrDTOGram">The array of  DTO grammar cards.</param>
        /// <param name="catID">The category ID.</param>
        /// <returns></returns>
        public Boolean InsertGrammarCards(DTO_Grammar[] arrDTOGram, int catID)
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
                cn = DataProvider.ConnectData(str_datasource);
                string strSQL1 = "INSERT INTO S3GT_GRAM(CAT_ID,Sample,Syntax,Meaning_JP,Meaning_VN";
                string strSQL2 = ") values (?,?,?,?,?";
                //
                j = 0;
                for (; j < Constants.MAX_GRAMMAR_EXAMPLE; j++)
                {
                    strSQL1 += ",Example" + (j + 1).ToString() + "_JP,Example" + (j + 1).ToString() + "_VN";
                    strSQL2 += ",?,?";

                }
                strSQL2 += ")";
                strSQL = strSQL1 + strSQL2 + "";
                //
                i = 0;
                for (; i < n; i++)
                {
                    cmd = new OleDbCommand(strSQL, cn);
                    //Add Type of Value
                    cmd.Parameters.Add("@CAT_ID", OleDbType.Integer);
                    cmd.Parameters.Add("@Sample", OleDbType.WChar);
                    cmd.Parameters.Add("@Syntax", OleDbType.WChar);
                    cmd.Parameters.Add("@Meaning_JP", OleDbType.WChar);
                    cmd.Parameters.Add("@Meaning_VN", OleDbType.WChar);

                    //Add Values
                    cmd.Parameters["@CAT_ID"].Value = catID;
                    cmd.Parameters["@Sample"].Value = arrDTOGram[i].STR_Sample;
                    cmd.Parameters["@Syntax"].Value = arrDTOGram[i].STR_Syntax;
                    cmd.Parameters["@Meaning_JP"].Value = arrDTOGram[i].STR_Meaning_JP;
                    cmd.Parameters["@Meaning_VN"].Value = arrDTOGram[i].STR_Meaning_VN;

                    //Execute Examples 
                    //Require: the number of Example VN and Example JP is equal 
                    j = 0;
                    if (arrDTOGram[i].ArrExampleVN.Count <= Constants.MAX_GRAMMAR_EXAMPLE)
                    {
                        for (; j < arrDTOGram[i].ArrExampleVN.Count; j++)
                        {
                            //Example JP
                            String tmpStr = "@Example";
                            tmpStr += (j + 1).ToString() + "_JP";
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = arrDTOGram[i].ArrExampleJP[j].ToString();
                            //Example VN
                            tmpStr = "@Example";
                            tmpStr += (j + 1).ToString() + "_VN";
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = arrDTOGram[i].ArrExampleVN[j].ToString();

                        }
                        for (; j < Constants.MAX_GRAMMAR_EXAMPLE; j++)
                        {
                            //Example JP
                            String tmpStr = "@Example";
                            tmpStr += (j + 1).ToString() + "_JP";
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = "";
                            //Example VN
                            tmpStr = "@Example";
                            tmpStr += (j + 1).ToString() + "_VN";
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = "";
                        }
                    }
                    else
                    {
                        for (; j < Constants.MAX_GRAMMAR_EXAMPLE; j++)
                        {
                            //Example JP
                            String tmpStr = "@Example";
                            tmpStr += (j + 1).ToString() + "_JP";
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = arrDTOGram[i].ArrExampleJP[j].ToString();
                            //Example VN
                            tmpStr = "@Example";
                            tmpStr += (j + 1).ToString() + "_VN";
                            cmd.Parameters.Add(tmpStr, OleDbType.WChar);
                            cmd.Parameters[tmpStr].Value = arrDTOGram[i].ArrExampleVN[j].ToString();
                        }
                    }

                    //Execute
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (OleDbException ex)
            {
                throw (ex);
            }
            finally
            {
                //Close
                cmd.Cancel();
                cn.Close();
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
                throw (ex);
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
                if (String.Compare(ds.Tables[0].Columns[0].ToString(), "MauCau") != 0 ||
                    String.Compare(ds.Tables[0].Columns[1].ToString(), "CuPhap") != 0 ||
                    String.Compare(ds.Tables[0].Columns[2].ToString(), "YNghia_JP") != 0 ||
                    String.Compare(ds.Tables[0].Columns[3].ToString(), "YNghia_VN") != 0)
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
                    {
                        if ((j % 2) == 0)//Example_JP
                            result[i].ArrExampleJP.Add(ds.Tables[0].Rows[i][j].ToString());
                        else//Example_VN
                            result[i].ArrExampleVN.Add(ds.Tables[0].Rows[i][j].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return result;
        }
        #endregion
    }
}
