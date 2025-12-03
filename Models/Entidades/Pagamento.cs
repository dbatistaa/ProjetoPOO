namespace trabalhoPOO.Models.Entidades
{
    public class Pagamento
    {
        #region Atributos
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public string Metodo { get; set; }
        public string Referencia { get; set; }
        public string Comprovativo { get; set; }
        #endregion

        //Atributos estrangeiros
        // public int IdQuota { get; set; }

        //Ligacao com Proprietario
        // public int IdProprietario { get; set; }
    }
}
