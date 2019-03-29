using LojaWeb.Entidades;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class ProdutosDAO
    {
        private ISession session;

        public ProdutosDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Produto produto)
        { 
            session.Save(produto);
        }

        public void Remove(Produto produto)
        {

        }

        public void Atualiza(Produto produto)
        {
            this.session.Merge(produto);
        }

        public Produto BuscaPorId(int id)
        {
            return this.session.Get<Produto>(id);
        }

        public IList<Produto> Lista()
        {
            IQuery query = session.CreateQuery("from Produto");
            return query.List<Produto>();
        }

        public IList<Produto> ProdutosComPrecoMaiorDoQue(double? preco)
        {
            string hql = "from Produto p where p.Preco > :minimo";
            IQuery query = session.CreateQuery(hql);
            query.SetParameter("minimo", preco.GetValueOrDefault(0.0));
            return query.List<Produto>();
        }

        public IList<Produto> ProdutosDaCategoria(string nomeCategoria)
        {
            string hql = "from Produto p where p.Categoria.Nome = :nome";
            IQuery query = session.CreateQuery(hql);
            query.SetParameter("nome", nomeCategoria);
            return query.List<Produto>();
        }

        public IList<Produto> ProdutosDaCategoriaComPrecoMaiorDoQue(
        double? preco, string nomeCategoria)
        {
            string hql = "from Produto p where p.Preco >= :minimo " +
                          "and p.Categoria.Nome = :nome";
            IQuery query = session.CreateQuery(hql);
            query.SetParameter("nome", nomeCategoria);
            query.SetParameter("minimo", preco.GetValueOrDefault(0.0));
            return query.List<Produto>();
        }

        public IList<Produto> ListaPaginada(int pagina)
        {
            string hql = "from Produto p order by p.Id";
            int resultadosPorPagina = 10;
            IQuery query = session.CreateQuery(hql);
            query.SetMaxResults(resultadosPorPagina);
            query.SetFirstResult(resultadosPorPagina * (pagina - 1));
            return query.List<Produto>();
        }

        public IList<Produto> BuscaPorPrecoCategoriaENome(double? preco,
    string nomeCategoria, string nome)
        {
            ICriteria criteria = session.CreateCriteria<Produto>();
            if (preco != null)
            {
                criteria.Add(Restrictions.Gt("Preco", preco.Value));
            }
            if (!string.IsNullOrEmpty(nomeCategoria))
            {
                ICriteria criteriaCategoria = criteria.CreateCriteria("Categoria");
                criteriaCategoria.Add(Restrictions.Eq("Nome", nomeCategoria));
            }
            if (!string.IsNullOrEmpty(nome))
            {
                criteria.Add(Restrictions.Eq("Nome", nome));
            }
            return criteria.List<Produto>();
        }
    }
}