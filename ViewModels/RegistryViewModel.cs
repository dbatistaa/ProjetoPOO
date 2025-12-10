using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    public class RegistryViewModel:BaseViewModel
    {
        private readonly LoginManager _loginManager;
        public RegistryViewModel(LoginManager gestorLogin)
        {
            _loginManager = gestorLogin;
        }
    }
}
