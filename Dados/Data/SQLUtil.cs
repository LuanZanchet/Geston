using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Data
{
    public class SQLUtil
    {

        public string GetSQLClass(Type type)
        {
            TableClass tc = new TableClass(type);
            return tc.CreateTableScript();
        }


        public void CreateDatabase(List<Type> lista)
        {
            var sql = String.Empty;
            foreach (var item in lista)
                sql += GetSQLClass(item);

            using (var cnn = SqLiteBase.SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(sql);
            }
        }


    }
    public class TableClass
    {
        private List<KeyValuePair<String, Type>> _fieldInfo = new List<KeyValuePair<String, Type>>();
        private string _className = String.Empty;

        private Dictionary<Type, String> dataMapper
        {
            get
            {
                Dictionary<Type, String> dataMapper = new Dictionary<Type, string>();
                dataMapper.Add(typeof(int), "INTEGER");
                dataMapper.Add(typeof(string), "TEXT ");
                dataMapper.Add(typeof(bool), "INTEGER");
                dataMapper.Add(typeof(DateTime), "TEXT");
                dataMapper.Add(typeof(float), "REAL");
                dataMapper.Add(typeof(decimal), "REAL");
                dataMapper.Add(typeof(Guid), "UNIQUEIDENTIFIER");

                return dataMapper;
            }
        }

        public List<KeyValuePair<String, Type>> Fields
        {
            get { return this._fieldInfo; }
            set { this._fieldInfo = value; }
        }

        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        public TableClass(Type t)
        {
            this._className = t.Name;

            foreach (PropertyInfo p in t.GetProperties())
            {
                KeyValuePair<String, Type> field = new KeyValuePair<String, Type>(p.Name, p.PropertyType);
                var attribute = Attribute.GetCustomAttribute(p, typeof(Dapper.Contrib.Extensions.KeyAttribute)) as Dapper.Contrib.Extensions.KeyAttribute;
                if (attribute == null)
                    this.Fields.Add(field);
            }
        }

        public string CreateTableScript()
        {
            System.Text.StringBuilder script = new StringBuilder();
            script.AppendLine("CREATE TABLE IF NOT EXISTS " + this.ClassName);
            script.AppendLine("(");
            script.AppendLine("\t ID integer primary key AUTOINCREMENT,");
            for (int i = 0; i < this.Fields.Count; i++)
            {
                KeyValuePair<String, Type> field = this.Fields[i];

                if (dataMapper.ContainsKey(field.Value))
                {
                    script.Append("\t " + field.Key + " " + dataMapper[field.Value]);

                }
                else
                {
                    script.Append("\t " + field.Key + " text");
                }

                if (i != this.Fields.Count - 1 && field.Key.ToUpper() != "ID")
                {
                    script.Append(",");
                }

                script.Append(Environment.NewLine);
            }

            script.AppendLine(");");

            return script.ToString();
        }
    }
}
