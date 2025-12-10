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
        // CONSTRUTOR CORRIGIDO: Aceita o LoginManager (DI)
        // O argumento 'gestorLogin' é necessário para criar a ViewModel.
        public RegistryWindow(LoginManager loginManager)
        {
            InitializeComponent();

            // 1. Cria a ViewModel de Registo (assumindo que existe)
            RegistryViewModel viewModel = new RegistryViewModel(loginManager);

            // 2. Atribui a ViewModel à View
            this.DataContext = viewModel;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
