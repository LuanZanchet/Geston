using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;

using Dapper;

namespace Dados.Data
{ 
   
    public class Connection<T> where T : new()
    {
        public Connection()
        {
        }

        public List<T> Get(string sql, Dictionary<string, object> parametro = null)
        {
            try
            {
                OpenConnection();
                return GlobalConnection.Connection.Query<T>(sql, parametro).ToList();
            }
            catch (SqlException ex)
            {
                throw new Exception(string.Format("Erro ao executar a instrução SQL: {0}", ex.Message), ex);
            }
            finally
            {
                CloseConnection();
            }
        }
        public int ExecInsert(string sql, Dictionary<string, object> parameters)
        {
            try 
            { 
                OpenConnection();
                 return GlobalConnection.Connection.Query<int>(sql, parameters).Single();
            }
            catch (SqlException ex)
            {
                throw new Exception(string.Format("Erro ao executar a instrução SQL: {0}", ex.Message), ex);
            }
            finally
            {
                CloseConnection();
            }
        }
        public int Exec(string sql, Dictionary<string, object> parametro)
        {
            try
            {
                OpenConnection();
                return GlobalConnection.Connection.Execute(sql, parametro);
            }
            catch (SqlException ex)
            {
                throw new Exception(string.Format("Erro ao executar a instrução SQL: {0}", ex.Message), ex);
            }
            finally
            {
                CloseConnection();
            }
        }
        private void OpenConnection()
        {
            if (GlobalConnection.Connection.State != ConnectionState.Open)
            {
                GlobalConnection.Connection.Open();
            }
        }
        private void CloseConnection()
        {
            //GlobalConnection.conn.Close();
        }

    }
    public static class GlobalConnection
    {
        public static SQLiteConnection Connection { get; set; }

        public static void OpenConnection()
        {
            if (!File.Exists(SqLiteBase.DbFile))
            {
                //CreateDatabase();
            }
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
            Connection = SqLiteBase.SimpleDbConnection();
            Connection.Open();
        }

    

    }
}