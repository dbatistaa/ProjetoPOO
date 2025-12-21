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
        private readonly LoginManager _loginManager;


        public LoginWindow(LoginManager loginManager)
        {
            InitializeComponent();
            var vm = new LoginViewModel(loginManager);
            this.DataContext = vm;

            // 1. Redirecionar para o Login (Sucesso)
            vm.OnLoginSuccess += (user) => {
                MainWindow mainWin = new MainWindow();
                mainWin.DataContext = new MainViewModel(user);
                Application.Current.MainWindow = mainWin;
                mainWin.Show();
                this.Close();
            };

            
            vm.OnRequestRegistry += () => {
               
                var regMng = new RegistryManager(loginManager._users);
                RegistryWindow regWin = new RegistryWindow(regMng);
                regWin.Show();
                this.Close();
            };

        }
    }
}
