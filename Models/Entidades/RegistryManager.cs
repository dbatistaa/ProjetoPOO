using System;
using System.Collections.Generic;
using System.Linq;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.Models.Entidades
{
    public class RegistryManager
    {
        private List<Utilizador> _users;

        public List<Utilizador> Users => _users;

        public RegistryManager(List<Utilizador> users)
        {
            _users = users ?? new List<Utilizador>();
        }

        public bool Registrar(string email, string password, string nivel, int idPessoa)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) return false;

            // Verifica se o email já existe
            if (_users.Any(u => u.Email == email)) return false;

            try
            {
                
                Utilizador novo = new Utilizador(email, password, nivel, idPessoa);
                _users.Add(novo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}