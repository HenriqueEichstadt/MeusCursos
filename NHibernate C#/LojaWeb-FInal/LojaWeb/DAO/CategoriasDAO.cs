using LojaWeb.Entidades;
using LojaWeb.Models;
using NHibernate;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class CategoriasDAO
    {
        private ISession session;

        public CategoriasDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Categoria categoria)
        {
            session.Save(categoria);
        }

        public void Remove(Categoria categoria)
        {

        }

        public void Atualiza(Categoria categoria)
        {

        }

        public Categoria BuscaPorId(int id)
        {
            return null;
        }

        public IList<Categoria> Lista()
        {
            return new List<Categoria>();
        }

        public IList<Categoria> BuscaPorNome(string nome)
        {
            string hql = "from Categoria c where c.Nome = :nome";
            IQuery query = session.CreateQuery(hql);
            query.SetParameter("nome", nome);
            return query.List<Categoria>();
        }

        public IList<ProdutosPorCategoria> ListaNumeroDeProdutosPorCategoria()
        {
            string hql = "select c from Categoria c join fetch c.Produtos";
            IQuery query = session.CreateQuery(hql);
            query.SetResultTransformer(Transformers.AliasToBean<ProdutosPorCategoria>());
            return query.List<ProdutosPorCategoria>();
        }
    }

}