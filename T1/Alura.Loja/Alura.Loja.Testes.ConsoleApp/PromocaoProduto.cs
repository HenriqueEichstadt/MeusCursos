namespace Alura.Loja.Testes.ConsoleApp
{
    public class PromocaoProduto
    {
        public int ProdutoId { get; set; }
        public Produto produto { get; set; }
        public int PromocaoId { get; set; }
        public Promocao Promocao { get; set; }
    }
}
