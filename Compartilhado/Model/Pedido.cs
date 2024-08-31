using Amazon.DynamoDBv2.DataModel;

namespace Compartilhado.Model
{
    [DynamoDBTable("pedidos")]
    public class Pedido
    {
        public string id { get; set; } = string.Empty;  
        public decimal ValorTotal { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<Produto>? Produtos { get; set; }
        public Cliente? Cliente { get; set; }
        public Pagamento? Pagamento { get; set; }
        public string? Justificativa { get; set; }
        public string? Status { get; set; }
        public bool Pago { get; set; }
        public bool Faturado { get; set; }

       
    }
}
