namespace trabalhoPOO.Models.Entidades
{
    public class Despesa
    {
        #region Atributos
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataDespesa { get; set; }
        public string Categoria { get; set; }
        public DateTime DataVencimento { get; set; }
        #endregion
        //Lista de quotas geradas
        public List<Quota> QuotaGerada { get; set; } = new List<Quota>();
    }
}
