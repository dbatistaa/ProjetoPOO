using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.Models.Entidades
{
    public class Condominio
    {
        #region Atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string NifCondominio { get; set; }
        public DateTime DataConstituicao { get; set; }
        public string Gestor { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        #endregion

        //Lista de todas as fracoes do condominio
        public List<Fracao> ListaFracoes { get; set; } = new List<Fracao>();

    }
}
