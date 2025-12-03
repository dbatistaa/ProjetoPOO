namespace trabalhoPOO.Models.Entidades
{
    public class Quota
    {
        #region
        public int Id { get; set; }
        public DateTime MesAno { get; set; }
        public decimal ValoDevido { get; set; }
        public string Estado { get; set; }
        public DateTime DataVencimento { get; set; }

        #endregion
        //Lista de pagamentos cobertos por esta quota
        public List<Pagamento> PagamentoRecebido { get; set; } = new List<Pagamento>();

    }
}
