
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Dados.Data
{
    public abstract class AbstractRepository<T> where T : class, new()
    {
        #region Instancias
        protected Connection<T> conexao = new Connection<T>();
        #endregion

        #region Métodos publicos
        public virtual long Insert(T t)
        {
            return GlobalConnection.Connection.Insert<T>(t);
        }

        public virtual bool Atualizar(T t)
        {
            return GlobalConnection.Connection.Update<T>(t);
        }

        public virtual bool Delete(T t)
        {
            return GlobalConnection.Connection.Delete<T>(t);
        }

        public virtual List<T> GetAll()
        {
            return GlobalConnection.Connection.GetAll<T>().AsList();
        }

        public virtual T Get(int codigo)
        {
            return GlobalConnection.Connection.Get<T>(codigo);
        }
        #endregion
    }
}

