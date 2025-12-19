using System.Windows;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;

namespace trabalhoPOO.Views
{
    /// <summary>
    /// Lógica interna para RegistryWindow.xaml
    /// </summary>
    public partial class RegistryWindow : Window
    {
        
        public RegistryWindow(RegistryManager registryManager)
        {
            InitializeComponent();
         
            RegistryViewModel viewModel = new RegistryViewModel(RegistryManager);

            this.DataContext = new RegistryViewModel(registryManager);
        }

    }
}
