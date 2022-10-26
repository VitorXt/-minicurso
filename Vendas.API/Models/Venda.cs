namespace Vendas.API.Models
{
    public class Venda
    {
        public int Numero { get; set; }
        public DateTime DataVenda { get; set; }
        public string NomeCliente { get; set; }

        //status -> Iniciada, Finalizada, Cancelada
        public StatusVenda StatusVenda { get; set; }

        //


    }
}
