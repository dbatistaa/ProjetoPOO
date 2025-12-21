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
            if (_users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase))) return false;

            int novoId = _users.Any() ? _users.Max(u => u.Id) + 1 : 1;

            try
            {
                
                Utilizador novo = new Utilizador(email, password, nivel, novoId);

               
                novo.Id = novoId;

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