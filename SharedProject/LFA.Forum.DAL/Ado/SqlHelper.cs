using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.DAL.Ado
{
    public class SqlHelper : IDisposable
    {
        #region Private Members

        private SqlConnection _conn;
        private string _strConn;
        protected bool _disposed = false;

        #endregion

        #region Private Methods

        private SqlCommand CreateCommand(string query, object[] args, CommandType type)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = query;
            cmd.CommandType = type;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] is string && i < args.Length - 1)
                {
                    SqlParameter p = new SqlParameter(args[i].ToString(), args[++i].ToString());
                    cmd.Parameters.Add(p);
                }
                else if (args[i] is SqlParameter)
                {
                    cmd.Parameters.Add(args[i]);
                }
            }
            return cmd;
        }

        #endregion

        #region Constructor

        public SqlHelper()
        {
            _strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=Forums;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";

            //SqlConnection ccc = new SqlConnection();
            _conn = new SqlConnection();
            _conn.ConnectionString = _strConn;
            _conn.Open();
        }

        #endregion

        #region Public Methods

        public SqlDataReader ExecuteReader(string query, params object[] args)
        {
            SqlCommand cmd = CreateCommand(query, args, CommandType.Text);
            var reader = cmd.ExecuteReader();
            return reader;
        }

        public SqlDataReader ExecuteReaderProc(string query, params object[] args)
        {
            SqlCommand cmd = CreateCommand(query, args, CommandType.StoredProcedure);
            cmd.Connection = _conn;
            return cmd.ExecuteReader();
        }

        public int ExecuteNonQueryProc(string query, params object[] args)
        {
            SqlCommand cmd = CreateCommand(query, args, CommandType.StoredProcedure);
            cmd.Connection = _conn;
            return cmd.ExecuteNonQuery();
        }

        public int ExecuteNonQuery(string query, params object[] args)
        {
            SqlCommand cmd = CreateCommand(query, args, CommandType.Text);
            cmd.Connection = _conn;
            return cmd.ExecuteNonQuery();
        }



        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_conn != null)
                    {
                        _conn.Dispose();
                        _conn = null;
                    }
                }
                _disposed = true;
            }
        }


    }

    //public class SqlHelper : IDisposable
    //{
    //    private SqlConnection _conn;
    //    private string _connectionString;
    //    protected bool _disposed = false;

    //    protected void Connect()
    //    {
    //        _conn = new SqlConnection(_connectionString);
    //        _conn.Open();
    //    }

    //    public SqlHelper()
    //    {
    //        _connectionString = @"Data Source=.\sqlexpress;User Id=sa;Password=P@ssw0rd;Initial Catalog=Forums;";
    //        Connect();
    //    }
    //    public SqlDataReader ExecuterReader(string query, params object[] args)
    //    {
    //        using (SqlCommand cmd = CreateCommand(query, CommandType.Text))
    //        {

    //            for (int i = 0; i < args.Length; i++)
    //            {
    //                if (args[i] is string && i < (args.Length - 1))
    //                {
    //                    SqlParameter param = new SqlParameter((string)args[i], args[++i]);
    //                    cmd.Parameters.Add(param);
    //                }
    //                else if (args[i] is SqlParameter)
    //                {
    //                    cmd.Parameters.Add(args[i]);
    //                }
    //                else
    //                {
    //                    throw new ArgumentException("Invalid number of type of arguments supplied use @value value");
    //                }


    //            }

    //            return cmd.ExecuteReader();
    //        }
    //    }
    //    public SqlCommand CreateCommand(string query, CommandType type)
    //    {
    //        SqlCommand cmd = new SqlCommand(query, _conn);
    //        cmd.CommandType = type;
    //        return cmd;

    //    }

    //    public int ExecuteNonQuery(string query, params object[] args)
    //    {
    //        using (SqlCommand cmd = CreateCommand(query, CommandType.Text))
    //        {
    //            return cmd.ExecuteNonQuery();
    //        }
    //    }

    //    public SqlDataReader ExecuterReaderProc(string procName)
    //    {
    //        using (SqlCommand cmd = CreateCommand(procName, CommandType.StoredProcedure))
    //        {
    //            return cmd.ExecuteReader();
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }
    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!_disposed)
    //        {
    //            if (disposing)
    //            {
    //                if (_conn != null)
    //                {
    //                    _conn.Dispose();
    //                    _conn = null;
    //                }
    //            }
    //            _disposed = true;
    //        }
    //    }
    //}
}
