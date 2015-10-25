using Npgsql;
using System;
using System.Data;

namespace App1DatabaseConnector
{
    public class ConnectionBuilder
    {
        private NpgsqlConnection _connection;
        private NpgsqlConnectionStringBuilder _connectionStringBuilder;
        public NpgsqlConnection Connection
        {
             get
            {
                return _connection;
            }
        }
        #region Public Interface
        public ConnectionBuilder(bool standardConnection)
        {
            _connectionStringBuilder = new NpgsqlConnectionStringBuilder();
            if (standardConnection)
            {
                this.Server("localhost")
                    .Port("5432")
                    .Database("App1")
                    .User("App1DatabaseUser")
                    .Password("pass1234");
            }
        }

        public ConnectionBuilder Server(string server)
        {
            _connectionStringBuilder.Add("Server", server);
            return this;
        }

        public ConnectionBuilder Port(string port)
        {
            _connectionStringBuilder.Add("Port", port);
            return this;
        }

        public ConnectionBuilder User(string user)
        {
            _connectionStringBuilder.Add("User Id", user);
            return this;
        }

        public ConnectionBuilder Database(string database)
        {
            _connectionStringBuilder.Add("Database", database);
            return this;
        }

        public ConnectionBuilder Password(string password)
        {
            _connectionStringBuilder.Add("Password", password);
            return this;
        }

        public bool OpenConnection()
        {
            _connection = new NpgsqlConnection(_connectionStringBuilder);
            try
            {
                _connection.Open();
                return true;
            }
            catch(Exception msg)
            {
                return false;
            }
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public DataSet ExecuteSelectSQL(string statment)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(statment, _connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void ExecuteInsertSQL(string statment)
        {
            if (!statment.ToLower().Contains("insert")) return;
            try
            {
                NpgsqlCommand command = _connection.CreateCommand();
                command.CommandText = statment;
                command.ExecuteNonQuery();
            }
            catch(Exception msg)
            {
                throw msg;
            }
        }

        public void ExecuteDeleteSQL(string statment)
        {
            if (!statment.ToLower().Contains("delete")) return;
            try
            {
                NpgsqlCommand command = _connection.CreateCommand();
                command.CommandText = statment;
                command.ExecuteNonQuery();
            }
            catch(Exception msg)
            {
                throw msg;
            }
        }
        #endregion

        #region Private Methods

       

        #endregion
    }
}
