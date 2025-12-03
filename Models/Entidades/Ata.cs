namespace trabalhoPOO.Models.Entidades
{
    public class Ata
    {
        #region Atributos da Classe
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Conteudo { get; set; }
        public bool Publicada { get; set; }
        #endregion


        //Lista de Assinaturas
        public List<string> Assinatura { get; set; } = new List<string>();
        public string ArquivoDigital { get; set; }


        //Atributo Estrangeiro

        // public int IdReuniao { get; set; }
    }
}
