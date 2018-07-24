using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();
            AtualizarProduto();
        }

        private static void AtualizarProduto()
        {
            // Incluir um Produto
            GravarUsandoEntity();
            RecuperarProdutos();

            // Atualizar o Produto
            using (var repo = new LojaContext())
            {
                Produto primeiro = repo.Produtos.First();
                primeiro.Nome = "Cassino Royalle - Editado";
                repo.Produtos.Update(primeiro);
                repo.SaveChanges();
            }
                RecuperarProdutos();


        }

        private static void ExcluirProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                Console.WriteLine ("Foram encontrados {0} produto(s).", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Cassino Royalle";
            p.Categoria = "Livros";
            p.Preco = 49.90;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Cassino Royalle";
            p.Categoria = "Livros";
            p.Preco = 49.90;

            using (var contexto = new LojaContext())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            }
        }
    }
}
