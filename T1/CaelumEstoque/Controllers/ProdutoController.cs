using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        [Route("produtos", Name = "ListaProdutos")]
        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();
            return View(produtos);
        }

        public ActionResult Form()
        {
            CategoriasDAO categoriasDAO = new CategoriasDAO();
            ViewBag.Produto = new Produto();
            ViewBag.Categorias = categoriasDAO.Lista();
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            int idDaInformatica = 1;
            if (produto.CategoriaId.Equals(idDaInformatica) && produto.Preco < 100)
            {
                ModelState.AddModelError("produto.InformaticaComPrecoInvalido", "Erro de cadastro, os produtos da categoria informática devem ter um preço maior que  R$100,00");
            }

            if (ModelState.IsValid)
            {

                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);

                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Produto = produto;
                CategoriasDAO categoriasDAO = new CategoriasDAO();
                ViewBag.Categorias = categoriasDAO.Lista();
                return View("Form");
            }
        }
        [Route("produtos/{Id}", Name = "VisualizaProduto")]
        public ActionResult Visualiza(int id)
        {
            // Buscar os produtos no banco de dados
            ProdutosDAO dao = new ProdutosDAO();
            // Buscar produto
            Produto produto = dao.BuscaPorId(id);
            // Mandar produto para a camada de visualização
            ViewBag.Produto = produto;
            return View();
        }
    }
}