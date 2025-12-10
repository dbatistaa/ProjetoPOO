using System;
using System.Windows;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;

namespace trabalhoPOO.Views
{
    /// <summary>
    /// Lógica interna para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow(LoginManager loginManager)
        {
            if (loginManager is null) throw new ArgumentNullException(nameof(loginManager));

            InitializeComponent();

            var viewModel = new LoginViewModel(loginManager);

            DataContext = viewModel;
        }

        
        private void InitializeComponent()
        {
           this.DataContext = this;
        }
    }
}
