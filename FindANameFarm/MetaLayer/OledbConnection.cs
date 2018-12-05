using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.SqlServer.Server;

namespace FindANameFarm.MetaLayer
{
    class OledbConnection : IIDbConnection
    {
        private readonly Dictionary<string, string> _properties;
        private OleDbConnection _connection;

        public OledbConnection(Dictionary<string, string> properties)
        {
            _properties = properties;
            Initialize();
        }

        // string builder method for connection string
        private void Initialize()
        {
            try
            {
                StringBuilder sb = new StringBuilder("Provider=");
                sb.Append(_properties["Provider"]);
                sb.Append(";Data Source=\"");
                sb.Append(_properties["Database"]);
                sb.Append("\"");
                if (_properties.ContainsKey("User"))
                {
                    if (_properties["User"].Length > 0)
                    {
                        sb.Append(";User ID=" + _properties["User"]);
                        sb.Append("Password=\"");
                        sb.Append(_properties["Password"]);
                        sb.Append("\"");
                    }
                }

                _connection = new OleDbConnection(sb.ToString());
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DbException("DBException - OleDatabaseConnection::initialize()\n" + e.Message);
            }
        }

        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DbException("DBException - OleDatabaseConnection::OpenConnection()\n" + e.Message);
            }

            return true;
        }

        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DbException("DBException - OleDatabaseConnection::CloseConnection()\n" + e.Message);
            }

            return true;
        }
        /// <summary>
        /// ian 26/10/2018
        /// based on in class example
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DbDataReader Select(string query)
        {
            DbDataReader reader;
            try
            {
                Debug.WriteLine(query);
                OleDbCommand command = new OleDbCommand(query) {Connection = _connection};


                reader = command.ExecuteReader();
                
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DbException("DBException - OleDatabaseConnection::RunQuery()\n" + e.Message);
            }
            //finally
            //{
            //    _connection?.Close();
            //}

            return reader;
        }

        /// <summary>
        /// ian 26/10/2018
        /// methods for sql statements
        /// </summary>
        /// <param name="queryString"></param>
        /// 
        public void Insert(string queryString)
        {
            try
            {
                OleDbCommand cmd = _connection.CreateCommand();
                cmd.CommandText = queryString;
                
                
                _connection.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                _connection?.Close();
            }
          

            
        }

        /// <summary>
        /// Ian 26/10/2018
        /// </summary>
        /// <param name="query"></param>
        public void Update(string query)
        {
            OleDbCommand cmd = _connection.CreateCommand();
          
            cmd.CommandText = query;
        
            _connection.Open();
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Ian 26/10/2018
        /// </summary>
        /// <param name="query"></param>
        public void Delete(string query)
        {
            OleDbCommand cmd = _connection.CreateCommand();
            cmd.CommandText = query;
           
            _connection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}


