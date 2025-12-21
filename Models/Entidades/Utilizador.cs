namespace trabalhoPOO.Models.Entidades
{
    public class Utilizador
    {
        #region Atributos User
        public int Id { get; set; }

        public string Username {  get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string NivelAcesso { get; set; } //Proprietario ou Inquilino
        public int IdPessoaAssociada { get; set; }
        #endregion


        public Utilizador() { }

        public Utilizador(string email, string Password, string nivelAcesso, int idUser)
        {
            Email = email;
            // Na prática: deve usar uma biblioteca de hashing aqui (ex: BCrypt.Net)
            PasswordHash = HashSenha(Password);
            NivelAcesso = nivelAcesso;
            IdPessoaAssociada = idUser;
        }


        private string HashSenha(string password)
        {

            var textBytes = System.Text.Encoding.UTF8.GetBytes(password);
            return System.Convert.ToBase64String(textBytes);
        }


       
        public bool VerifyPassword(string Password)
        {
            return PasswordHash == HashSenha(Password);
        }

    }
}
