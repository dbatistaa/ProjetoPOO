using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.Models.Entidades
{
    public class Inquilino : Pessoa
    {
        #region   Atributos
        public DateTime DataInicioContrato { get; set; }
        public DateTime DataFimContrato { get; set; }
        #endregion
    }
}
