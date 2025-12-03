namespace trabalhoPOO.Models.Entidades
{
    public abstract class Pessoa
    {
        #region Atributos SuperClasse
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Morada { get; set; }

        public string Telefone { get; set; }
        public string Identificacao { get; set; }
        public string Email { get; set; }
        #endregion
    }
}
