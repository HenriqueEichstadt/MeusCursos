using Loja.DAO;
using Loja.Entidades;
using Loja.Infra;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            ISession session = NHibernateHelper.AbreSession();
            
            PessoaFisica Murilo = new PessoaFisica();
            Murilo.Nome = "Murilo";
            Murilo.CPF = "000.000.000-00";

            PessoaJuridica Caelum = new PessoaJuridica();
            Caelum.Nome = "Caelum";
            Caelum.CNPJ = "0000000000000000";

            UsuarioDAO dao = new UsuarioDAO(session);
            dao.Adiciona(Murilo);
            dao.Adiciona(Caelum);
            
            
            session.Close();
            Console.Read();
        }

        // Criando a Venda do projeot com many-to-many
        public static void CriandoAVenda()
        {
            ISession session = NHibernateHelper.AbreSession();
            ITransaction transaction = session.BeginTransaction();
            Venda venda = new Venda();

            Usuario cliente = session.Get<Usuario>(1);
            venda.Cliente = cliente;

            Produto p1 = session.Get<Produto>(1);
            Produto p2 = session.Get<Produto>(2);

            venda.Produtos.Add(p1);
            venda.Produtos.Add(p2);
            session.Save(venda);
            transaction.Commit();
            session.Close();

            Console.Read();
        }


        //Guardando em Cache
            public IList<Usuario> ListaUsuariosGuardandoEmCache()
            {
            ISession session = NHibernateHelper.AbreSession();
            IQuery query = session.CreateQuery("from Usuario");
                query.SetCacheable(true);
                return query.List<Usuario>();
            Console.Read();
            //ISession session = NHibernateHelper.AbreSession();
            //ISession session2 = NHibernateHelper.AbreSession();

            //session.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();
            //session2.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();

        }

        // Utilizando Criteria
        public static void UsandoCriteria()
        {
            ISession session = NHibernateHelper.AbreSession();
            ProdutoDAO produtoDao = new ProdutoDAO(session);
            IList<Produto> produtos = produtoDao.BuscaPorNomePrecoMinimoECategoria("", 0, "");
            foreach (var produto in produtos)
            {
                Console.WriteLine(@"Nome: " + produto.Nome +
                                   " Preco: " + produto.Preco.ToString() +
                                   " Categoria: " + produto.Categoria.Nome);
            }
            Console.Read();
        }

        // Aula 5 - Problema do N+1
        public static void ProblemaDoNMais1()
        {
            ISession session = NHibernateHelper.AbreSession();
            IQuery query = session.CreateQuery("from Produto p join fetch p.Categoria");
            IList<Produto> produtos = query.List<Produto>();
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.Nome + " - " + produto.Categoria.Nome);
            }
            session.Close();
            Console.Read();
        }


        public static void RecuperandoDados()
        {

            ISession session = NHibernateHelper.AbreSession();
            //Com nameof para pegar nome certo da entidade
            //IQuery query = session.CreateQuery($@"from {nameof(Produto)}");  
            //COM ORDER BY
            //IQuery query = session.CreateQuery($"from Produto p order by p.Nome");   

            // COM PARAMETROS BUSCANDO POR INNER JOIN
            //IQuery query = session.CreateQuery($@"from Produto p where p.Preco > :valor and p.Categoria.Nome = :categoria");
            //query.SetParameter("valor", 9);
            //query.SetParameter("categoria", "Bebidas");
            //IList<Produto> produtos = query.List<Produto>();

            IQuery query = session.CreateQuery($@"select p.Categoria as Categoria, count(p) as NumeroDePedidos from Produto p group by p.Categoria");
            query.SetResultTransformer(Transformers.AliasToBean<ProdutosPorcategoria>());

            IList<ProdutosPorcategoria> relatorio = query.List<ProdutosPorcategoria>();
            session.Close();
            Console.Read();
        }

        // Busca por Lazzynes
        public static void Lazzyness()
        {
            ISession session = NHibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();
            Categoria categoria = session.Load<Categoria>(1);
            IList<Produto> produtos = categoria.Produtos;
            transacao.Commit();
            session.Close();
            Console.Read();
        }

        // Relacionamento entre entidades
        public static void ManyToOne()
        {
            Categoria categoriaRoupa = new Categoria();
            categoriaRoupa.Nome = "Bebidas";

            Produto produto = new Produto();
            produto.Nome = "Coca-Cola";
            produto.Preco = 10;

            produto.Categoria = categoriaRoupa;


            ISession session = NHibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();
            session.Save(categoriaRoupa);
            session.Save(produto);
            transacao.Commit();
            session.Close();
            Console.Read();
        }

        // Aula 2 - Persistindo dados
        public void AdicionaNaTabela()
        {
            ISession session = NHibernateHelper.AbreSession();

            UsuarioDAO db = new UsuarioDAO(session);

            //Usuario novoUsuario = new Usuario();
            //novoUsuario.Nome = "Henrique Alexsander Eichstädt";

            //db.Adiciona(novoUsuario);

            //Console.WriteLine(novoUsuario.Nome);
            Console.Read();
            session.Close();
        }

        public static void CriaTabela()
        {
            NHibernateHelper.GeraSchema();
        }
    }

    public class ProdutosPorcategoria
    {
        public Categoria Categoria { get; set; }
        public long NumeroDePedidos { get; set; }
    }
}
