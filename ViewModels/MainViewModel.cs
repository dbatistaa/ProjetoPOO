using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly Utilizador _user;

        public string InfoUtilizador => $"Utilizador: {_user.Email} | Perfil: {_user.NivelAcesso}";


        public Visibility VisibilidadeProprietario =>
            _user.NivelAcesso == "Proprietario" ? Visibility.Visible : Visibility.Collapsed;

        public Visibility VisibilidadeInquilino =>
            _user.NivelAcesso == "Inquilino" ? Visibility.Visible : Visibility.Collapsed;

        public MainViewModel(Utilizador user)
        {
            _user = user;
        }
    }
}
