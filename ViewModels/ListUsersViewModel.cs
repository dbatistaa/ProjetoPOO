using System.Collections.ObjectModel;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    public class ListUsersViewModel : BaseViewModel
    {
        public ObservableCollection<Utilizador> ListaUtilizadores { get; set; }

        public ListUsersViewModel()
        {
            // Carrega os dados persistidos no ficheiro
            var dados = DataStorage.CarregarUtilizadores();
            ListaUtilizadores = new ObservableCollection<Utilizador>(dados);
        }
    }
}