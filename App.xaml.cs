using Projeto.Views;
using System.Windows;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;
using trabalhoPOO.Views;


namespace trabalhoPOO
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            

            List<Utilizador> AllUsers = new List<Utilizador>();
            LoginManager LoginManager = new LoginManager(AllUsers);

            RegistryWindow registryView = new RegistryWindow(LoginManager);

            // 3. Mostrar a RegistryWindow
            registryView.Show();

            
            this.MainWindow = registryView;
            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }


    }

}
