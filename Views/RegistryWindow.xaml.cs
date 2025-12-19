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
        
        public RegistryWindow(LoginManager loginManager)
        {
            InitializeComponent();
         
            RegistryViewModel viewModel = new RegistryViewModel(loginManager);

            this.DataContext = new RegistryViewModel(loginManager);
        }

    }
}
