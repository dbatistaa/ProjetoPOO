using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.Models.Entidades
{
    public class RegistryManager
    {
        private List<Utilizador> _utilizadores;
        private static int _proximoId = 1;

        public RegistryManager(List<Utilizador> utilizadores)
        {
            _utilizadores = utilizadores;
        }

        public bool Registrar(string email, string password, string nivelAcesso, int idPessoa)
        {
           
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return false;

           
            if (_utilizadores.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                return false;

            try
            {
                
                Utilizador novo = new Utilizador(email, password, nivelAcesso, idPessoa);

               
                novo.Id = _proximoId++;

                _utilizadores.Add(novo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
