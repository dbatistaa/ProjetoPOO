using System.Windows;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;

namespace trabalhoPOO.Views
{
    public partial class RegistryWindow : Window
    {
        public RegistryWindow(RegistryManager manager)
        {
            InitializeComponent();
            var vm = new RegistryViewModel(manager);
            this.DataContext = vm;


            vm.OnRequestLogin += () =>
            {

                var loginMng = new LoginManager(manager.Users);

                LoginWindow loginWin = new LoginWindow(loginMng);

                Application.Current.MainWindow = loginWin;

                loginWin.Show();
                this.Close(); 
            };
        }
    }
}