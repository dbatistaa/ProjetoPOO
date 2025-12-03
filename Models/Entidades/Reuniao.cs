namespace trabalhoPOO.Models.Entidades
{
    public class Reuniao
    {
        #region Atributos
        public int Id { get; set; }
        public string Convocador { get; set; }
        public DateTime DataHora { get; set; }
        public TimeSpan Duracao { get; set; }
        public string Local { get; set; }
        public string Assuntos { get; set; }
        #endregion

        //Lista de Pessoas presentes na Reuniao
        public List<Pessoa> Participantes { get; set; } = new List<Pessoa>();

        //LIgacao com Ata

        public Ata AtaGerada { get; set; }

    }
}
