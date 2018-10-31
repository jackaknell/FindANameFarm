using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using System.Diagnostics;

namespace FindANameFarm.MetaLayer
{
    class OledbConnection : IIDbConnection
    {
        private readonly Dictionary<string, string> _properties;
        private OleDbConnection _connection;

        public OledbConnection(Dictionary<string, string> properties)
        {
            _properties = properties;
            initialize();
        }


        private void initialize()
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
                throw new DBException("DBException - OleDatabaseConnection::initialize()\n" + e.Message);
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
                throw new DBException("DBException - OleDatabaseConnection::OpenConnection()\n" + e.Message);
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
                throw new DBException("DBException - OleDatabaseConnection::CloseConnection()\n" + e.Message);
            }

            return true;
        }

        public DbDataReader Select(string query)
        {
            DbDataReader reader;
            try
            {
                OleDbCommand command = new OleDbCommand(query);
                Debug.WriteLine(query);
                command.Connection = _connection;
               
                reader = command.ExecuteReader();
                
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DBException("DBException - OleDatabaseConnection::RunQuery()\n" + e.Message);
            }
            //finally
            //{
            //    _connection?.Close();
            //}

            return reader;
        }
        public void Insert(string queryString)
        {
            try
            {
                OleDbCommand cmd = _connection.CreateCommand();
                cmd.CommandText = queryString;
                Debug.WriteLine(queryString);
                _connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                _connection?.Close();
            }
          

            
        }

        public void Update(string query)
        {
            OleDbCommand cmd = _connection.CreateCommand();
            cmd.CommandText = query;
            Debug.WriteLine(query);
            _connection.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(string query)
        {
            OleDbCommand cmd = _connection.CreateCommand();
            cmd.CommandText = query;

            _connection.Open();
            cmd.ExecuteNonQuery();
        }

        public DataSet GetDataSet(string sqlStatement)
        {
            try
            {
                DataSet dataSet;

                // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStatement, _connection);
                // create the dataset
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                //return the dataSet
                return dataSet;
            }
            finally
            {
                _connection.Close();
            }
           
        }

      
    }
}
