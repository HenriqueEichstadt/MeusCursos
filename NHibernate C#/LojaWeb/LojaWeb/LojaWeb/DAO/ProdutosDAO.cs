using LojaWeb.Entidades;
using NHibernate;
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

        }

        public void Remove(Produto produto)
        {

        }

        public void Atualiza(Produto produto)
        {

        }

        public Produto BuscaPorId(int id)
        {
            return null;
        }

        public IList<Produto> Lista()
        {
            return new List<Produto>();
        }

        public IList<Produto> ProdutosComPrecoMaiorDoQue(double? preco)
        {
            return new List<Produto>();
        }

        public IList<Produto> ProdutosDaCategoria(string nomeCategoria)
        {
            return new List<Produto>();
        }

        public IList<Produto> ProdutosDaCategoriaComPrecoMaiorDoQue(double? preco, string nomeCategoria)
        {
            return new List<Produto>();
        }

        public IList<Produto> ListaPaginada(int paginaAtual)
        {
            return new List<Produto>();
        }

        public IList<Produto> BuscaPorPrecoCategoriaENome(double? preco, string nomeCategoria, string nome)
        {
            return new List<Produto>();
        }
    }
}