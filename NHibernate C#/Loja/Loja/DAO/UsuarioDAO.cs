using Loja.Entidades;
using Loja.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    public class UsuarioDAO
    {

        private ISession session;

        public UsuarioDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Usuario usuario)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(usuario);
            transacao.Commit();
        }

        public Usuario BuscaPorId(int id)
        {
            return session.Get<Usuario>(id);
        }

        public IList<Usuario> ListaUsuarios()
        {
            using (var dao = session.BeginTransaction())
            {
                IQuery query = session.CreateSQLQuery("SELECT * FROM USUARIO")
                                      .AddEntity(typeof(Usuario));
                var user = query.List<Usuario>();

                foreach (var usuarios in user)
                {
                    Console.WriteLine(usuarios.Nome);
                }
                
                dao.Commit();
                return user;
            }
        }

        public IDbCommand GetUsuarios()
        {
            using (var sessao = session.BeginTransaction())
            {
                IDbCommand comando = session.Connection.CreateCommand();
                comando.CommandText = "SELECT * FROM USUARIO";
                comando.ExecuteReader();

                sessao.Commit();
                return comando;
            }
        }


    }
}
