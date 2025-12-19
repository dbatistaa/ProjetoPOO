using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO.Models.Entidades
{
    public class LoginManager
    {

        // Lista de todos os Utilizadores carregados da persistência (ficheiro)
        private List<Utilizador> _users;

        public LoginManager(List<Utilizador> AllUsers)
        {
            _users = AllUsers;
        }

        public LoginManager()
        {
            _users = new List<Utilizador>();
        }

        public Utilizador Autenticar(string email, string Password)
        {
            
            Utilizador utilizador = _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            
            if (utilizador == null || !utilizador.VerifyPassword(Password))
            {
                return null;
            }

            var user = _users.FirstOrDefault(u => u.Email == email);
            if (user != null && user.VerifyPassword(Password))
            {
                return user;
            }
            return null;

            //Se as credenciais forem válidas
            return utilizador;


        }
    }
}
