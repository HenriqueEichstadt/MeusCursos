using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class VendasController : Controller
    {
        private VendasDAO vendasDAO;
        private UsuariosDAO usuariosDAO;
        private ProdutosDAO produtosDAO;

        public VendasController(VendasDAO vendasDAO,ProdutosDAO produtosDAO, UsuariosDAO usuariosDAO)
        {
            this.vendasDAO = vendasDAO;
            this.produtosDAO = produtosDAO;
            this.usuariosDAO = usuariosDAO;
        }

        public ActionResult Index()
        {
            IList<Venda> vendas = vendasDAO.Lista();
            return View(vendas);
        }
        public ActionResult ListaProdutos()
        {
            IList<Produto> produtos = produtosDAO.Lista();
            ViewBag.ProdutosNoCarrinho = this.Carrinho.Produtos.Count;
            return View(produtos);
        }
        public ActionResult AdicionaProduto(int produtoId)
        {
            Produto produto = produtosDAO.BuscaPorId(produtoId);
            this.Carrinho.Adiciona(produto);
            return RedirectToAction("ListaProdutos");
        }
        public ActionResult FechaPedido()
        {
            IList<Produto> produtos = this.Carrinho.Produtos;
            IList<Usuario> usuarios = this.usuariosDAO.Lista();
            ViewBag.Usuarios = usuarios;
            return View(produtos);
        }
        public ActionResult CompletaPedido(int usuarioId)
        {
            Usuario usuario = usuariosDAO.BuscaPorId(usuarioId);
            Venda venda = this.Carrinho.CriaVenda(usuario);
            vendasDAO.Adiciona(venda);
            this.Carrinho = new Carrinho();
            return RedirectToAction("Index");
        }
        public ActionResult LimpaCarrinho()
        {
            this.Carrinho = new Carrinho();
            return RedirectToAction("ListaProdutos");
        }

        // O Valor da propriedade Carrinho é armazenado na sessão
        private Carrinho Carrinho
        {
            get
            {
                Carrinho atual = Session["Carrinho"] as Carrinho;
                if (atual == null)
                {
                    atual = new Carrinho();
                    Session["Carrinho"] = atual;
                }
                return atual;
            }
            set
            {
                Session["Carrinho"] = value;
            }
        }
    }
}
