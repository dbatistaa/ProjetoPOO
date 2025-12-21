using System.Collections.ObjectModel;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    public class ListUsersViewModel : BaseViewModel
    {
        public ObservableCollection<Utilizador> ListaUtilizadores { get; set; }

        public ListUsersViewModel()
        {
            
            var allUsers = DataStorage.CarregarUtilizadores();

          
            var tenantsOnly = allUsers
                .Where(u => u.NivelAcesso == "Inquilino")
                .ToList();

            ListaUtilizadores = new ObservableCollection<Utilizador>(tenantsOnly);
        }
    }
}