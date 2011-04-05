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
        protected OleDbTransaction _transaction;
        protected OleDbConnection _connection;

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

        public static OleDbConnection ConnectData(String dbFile)
        {
            string cnStr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + dbFile;
            OleDbConnection cn = null;
            try
            {
                cn = new OleDbConnection(cnStr);
                cn.Open();
                return cn;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _connect.Close();
            }
        }

        public void beginTransaction()
        {
            _connection = this.Connect();
            _transaction = _connection.BeginTransaction();
            _command = _connection.CreateCommand();

            _command.Connection = _connection;
            _command.Transaction = _transaction;
        }

        public void executeNonQueryTrans(string strQuery)
        {
            _command.CommandText = strQuery;
            _command.ExecuteNonQuery();
        }

        public void commitTransaction()
        {
            _transaction.Commit();
        }

        public void rollbackTransaction()
        {
            _transaction.Rollback();
        }

        public void endTransaction()
        {
            if (_connection != null)
            {
                if (_connection.State != ConnectionState.Closed)
                {
                    _connection.Close();
                }

                _connection.Dispose();
            }

            if (_command != null)
            {
                _command.Dispose();
            }

            if (_transaction != null)
            {
                _transaction.Dispose();
            }
        }
    }
}
