using System;
using System.Windows;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;

namespace trabalhoPOO.Views
{
    public partial class LoginWindow : Window
    {
        private readonly LoginManager _loginManager;

        public LoginWindow(LoginManager loginManager)
        {
            InitializeComponent();
            var vm = new LoginViewModel(loginManager);
            this.DataContext = vm;

            // 1. Redirecionar para a MainWindow (Sucesso)
            vm.OnLoginSuccess += (user) => {

                // CORREÇÃO AQUI: Passamos o ImovelManager estático do App para resolver o erro CS7036
                MainWindow mainWin = new MainWindow(App.ImovelManager);

                mainWin.DataContext = new MainViewModel(user);
                Application.Current.MainWindow = mainWin;
                mainWin.Show();
                this.Close();
            };

            vm.OnRequestRegistry += () => {
                var regMng = new RegistryManager(loginManager.Users);
                RegistryWindow regWin = new RegistryWindow(regMng);
                regWin.Show();
                this.Close();
            };
        }
    }
}