using Loja.Entidades;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    class ProdutoDAO
    {
        private ISession session;

        public ProdutoDAO(ISession session)
        {
            this.session = session;
        }

        public IList<Produto> BuscaPorNomePrecoMinimoECategoria(string nome, decimal precoMinimo, string nomeDaCategoria)
        {
            ICriteria criteria = session.CreateCriteria<Produto>();
            if (!string.IsNullOrEmpty(nome))
            {
                criteria.Add(Restrictions.Eq("Nome", nome));
            }

            if(precoMinimo > 0)
            {
                criteria.Add(Restrictions.Ge("Preco", precoMinimo));
            }

            if (!string.IsNullOrEmpty(nomeDaCategoria))
            {
                ICriteria criteriaCategoria = session.CreateCriteria("Categoria");
                criteriaCategoria.Add(Restrictions.Eq("Nome", nomeDaCategoria));
            }
            return criteria.List<Produto>();
        }
    }
}
