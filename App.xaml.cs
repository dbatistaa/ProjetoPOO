using System.Collections.Generic;
using System.Windows;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.Views;

namespace trabalhoPOO
{
    public partial class App : Application
    {
        
        public static ImovelManager ImovelManager { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            List<Utilizador> allUsers = DataStorage.CarregarUtilizadores();
            List<Imovel> imoveisCarregados = DataStorage.CarregarImoveis();

     
            ImovelManager = new ImovelManager(imoveisCarregados);

            RegistryManager regManager = new RegistryManager(allUsers);
            var registryView = new RegistryWindow(regManager);

            this.MainWindow = registryView;
            registryView.Show();
        }
    }
}