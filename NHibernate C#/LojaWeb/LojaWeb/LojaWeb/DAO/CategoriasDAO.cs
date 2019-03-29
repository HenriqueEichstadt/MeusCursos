using LojaWeb.Entidades;
using LojaWeb.Models;
using NHibernate;
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
            return new List<Categoria>();
        }

        public IList<ProdutosPorCategoria> ListaNumeroDeProdutosPorCategoria()
        {
            return new List<ProdutosPorCategoria>();
        }
    }

}