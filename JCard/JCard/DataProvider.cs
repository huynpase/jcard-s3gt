using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;


namespace JCard
{
    public class DataProvider
    {

        protected OleDbCommand _command;
        protected String _ConnectionString;

        string str_datasource;

        public DataProvider(string str_dts)
        {
            str_datasource = str_dts;
        }

        public OleDbConnection Connect()
        {
            //_ConnectionString = "Provider=SQLOLEDB;Data Source=Your_Server_Name;Initial Catalog= Your_Database_Name;UserId=Your_Username;Password=Your_Password;" 
            _ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + str_datasource + " ;Jet OLEDB:Database Password=";

            OleDbConnection _connect = null;
            _connect = new OleDbConnection(_ConnectionString);
            _connect.Open();
            return _connect;
        }

        // Ham tao
        public DataProvider()
        {

        }

        public void DisConnect()
        {

        }

        public IDataReader excuteQuery(string strQuery)
        {
            OleDbConnection _connect = this.Connect();
            _command = new OleDbCommand(strQuery, _connect);
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void excuteNonQuery(string strQuery)
        {
            OleDbConnection _connect = this.Connect();
            _command = new OleDbCommand(strQuery, _connect);
            try
            {
                _command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                _connect.Close();
            }
        }

    }
}
