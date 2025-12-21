using System.Collections.Generic;
using System.Windows;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.Views;

namespace trabalhoPOO
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

         
            List<Utilizador> allUsers = DataStorage.CarregarUtilizadores();

     
            RegistryManager regManager = new RegistryManager(allUsers);
            var registryView = new trabalhoPOO.Views.RegistryWindow(regManager);


            this.MainWindow = registryView;
            this.ShutdownMode = ShutdownMode.OnLastWindowClose;
            registryView.Show();
        }
    }
}