using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;
using trabalhoPOO.Views;

namespace trabalhoPOO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImovelManager _imovelManager;

        //public MainWindow()
        //{
        //    InitializeComponent();
            
        //}

        public MainWindow(ImovelManager imovelManager)
        {
            InitializeComponent();
            _imovelManager = imovelManager;
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
           
            Application.Current.Shutdown();
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            var listWin = new ListUsersWindow();
            listWin.Owner = this; 
            listWin.DataContext = new ListUsersViewModel();
            listWin.ShowDialog();
        }

        private void BtnAddImovel_Click(object sender, RoutedEventArgs e)
        {
            var manager = App.ImovelManager;

            if (manager == null)
            {
                MessageBox.Show("Erro: O ImovelManager ainda está null. Verifica o App.xaml.cs");
                return;
            }

            var vm = new AddImovelViewModel(manager);
            var addWin = new AddImovelWindow();
            addWin.DataContext = vm;
            addWin.ShowDialog();
        }
    }
}