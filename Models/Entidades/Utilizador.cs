namespace trabalhoPOO.Models.Entidades
{
    public class Utilizador
    {
        #region Atributos User
        public int Id { get; set; }

        public string Username {  get; set; }
        public string PasswordHash { get; private set; }
        public string NivelAcesso { get; set; } //Proprietario ou Inquilino
        #endregion
    }
}
