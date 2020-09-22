using System;
using System.Data.SQLite;

namespace Dados.Data
{
    public class SqLiteBase
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\Dados.sqlite"; }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}