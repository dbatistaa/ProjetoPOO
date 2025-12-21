using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    public class ListImoveisViewModel : BaseViewModel
    {
        private List<Imovel> _allMyImoveis; // Lista base para não perder dados ao filtrar
        public ObservableCollection<Imovel> ListaImoveis { get; set; }

       
        public List<string> AvailableTypes { get; } = new List<string> { "All", "Apartamento", "Moradia", "Quarto" };

        private string _selectedType = "All";
        public string SelectedType
        {
            get => _selectedType;
            set
            {
                _selectedType = value;
                ApplyFilter(); 
                OnPropertyChanged("SelectedType");
            }
        }

        public ListImoveisViewModel(int loggedUserId)
        {
           
            var globalImoveis = App.ImovelManager.Imoveis;

            
            _allMyImoveis = globalImoveis
                .Where(i => i.ProprietarioId == loggedUserId)
                .ToList();

            ListaImoveis = new ObservableCollection<Imovel>(_allMyImoveis);
        }

        private void ApplyFilter()
        {
            ListaImoveis.Clear();


            var filtered = _selectedType == "All"
            ? _allMyImoveis
            : _allMyImoveis.Where(i => i.TipoImovel == _selectedType).ToList();

            foreach (var item in filtered)
            {
                ListaImoveis.Add(item);
            }
        }
    }
}