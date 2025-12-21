using System;
using System.Collections.Generic;
using System.Linq;

namespace trabalhoPOO.Models.Entidades
{
    public class LoginManager
    {
        public List<Utilizador> _users;

        public LoginManager(List<Utilizador> AllUsers)
        {
            _users = AllUsers;
        }

        public LoginManager()
        {
            _users = new List<Utilizador>();
        }

        public Utilizador Autenticar(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return null;

            Utilizador utilizador = _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

         
            if (utilizador != null && utilizador.VerifyPassword(password))
            {
                return utilizador;
            }

            return null;
        }
    }
}