using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Utilizador> ListaUtilizadores { get; set; }

        public Utilizador CurrentUser { get; set; }

        public string InfoUtilizador => $"Utilizador: {_user.Email} | Perfil: {_user.NivelAcesso}";


        public Visibility VisibilidadeProprietario =>
            _user.NivelAcesso == "Proprietario" ? Visibility.Visible : Visibility.Collapsed;

        public Visibility VisibilidadeInquilino =>
            _user.NivelAcesso == "Inquilino" ? Visibility.Visible : Visibility.Collapsed;

        public MainViewModel(Utilizador user)
        {
            _user = user;
            CurrentUser = user;

            var listaDoFicheiro = DataStorage.CarregarUtilizadores();
            ListaUtilizadores = new ObservableCollection<Utilizador>(listaDoFicheiro);

        }
    }
}
