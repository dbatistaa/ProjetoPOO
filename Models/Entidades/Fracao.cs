namespace trabalhoPOO.Models.Entidades
{
    public class Fracao
    {
        #region Atributos
        public int Id { get; set; }
        public string Designacao { get; set; }
        public decimal Permilagem { get; set; }
        public decimal Area { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        #endregion


        //Atributos estraneiros
        // public int IdCondominio { get; set; }
        // public List<Proprietario> Proprietarios { get; set; } //Associa o Proprietario
        //public Inquilino InquilinoAtual { get; set; } // Associa o ocupante atual
    }
}
