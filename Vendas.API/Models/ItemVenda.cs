namespace Vendas.API.Models
{
    public class ItemVenda
    {
        public int NumeroVenda { get; set; }
        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

    }
}
