using Loja.Entidades;
using NHibernate;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infra
{
    public class Query
    {
        private ISession session = NHibernateHelper.AbreSession();
        private string QueryString { get; set; }

        public Query()
        {
            //this.session = session;
        }

        public IList<T> Select<T>(string selectQuery) where T : new()
        {
                IQuery query = session.CreateSQLQuery(selectQuery)
                                      .AddEntity(typeof(T));
                return query.List<T>();
        }

        //public void Update<T>(string updateQuery)
        //{
        //    IQuery query = session.Update();
        //}


        //IDbCommand comando = session.Connection.CreateCommand();
        //comando.CommandText = "";
        //    comando.ExecuteNonQuery();
    }
}
