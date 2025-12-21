using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;

namespace trabalhoPOO.Views
{
    /// <summary>
    /// Lógica interna para ListImoveisWindow.xaml
    /// </summary>
    public partial class ListImoveisWindow : Window
    {
        public ListImoveisWindow()
        {
            InitializeComponent();
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {
            // Obtém o imóvel da linha onde clicaste
            var button = sender as Button;
            var imovel = button?.DataContext as Imovel;

            if (imovel != null)
            {
                var result = MessageBox.Show($"Desejas remover o imóvel em {imovel.Morada}?", "Confirmar", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    
                    App.ImovelManager.Imoveis.Remove(imovel);

                    DataStorage.SalvarImoveis(App.ImovelManager.Imoveis);

                    
                    var vm = this.DataContext as ListImoveisViewModel;
                    vm?.ListaImoveis.Remove(imovel);

                    MessageBox.Show("Imóvel removido com sucesso!");
                }
            }
        }

        private void BtnAtribuir_Click(object sender, RoutedEventArgs e)
        {
            var imovel = (sender as Button)?.DataContext as Imovel;
            if (imovel == null) return;

           
            MessageBox.Show("Aqui abririas a lista de utilizadores para selecionar o inquilino.");

            // Exemplo de atribuição manual para testares:
            // imovel.InquilinoId = 99; // ID de teste
            // DataStorage.SalvarImoveis(App.ImovelManager.Imoveis);
        }

        private void BtnArrendar_Click(object sender, RoutedEventArgs e)
        {
            var imovel = (sender as Button)?.DataContext as Imovel;
            if (imovel == null) return;

          
            var userWin = new ListUsersWindow();
            userWin.Owner = this;

           
            if (userWin.ShowDialog() == true)
            {
                var inquilino = userWin.SelectedUser;

                if (inquilino != null)
                {
                    
                    imovel.InquilinoId = inquilino.Id;
                    DataStorage.SalvarImoveis(App.ImovelManager.Imoveis);

                   
                    if (this.DataContext is ListImoveisViewModel vm)
                    {
                        var index = vm.ListaImoveis.IndexOf(imovel);
                        if (index != -1)
                        {
                            vm.ListaImoveis.RemoveAt(index);
                            vm.ListaImoveis.Insert(index, imovel);
                        }
                    }

                  
                    MessageBox.Show($"Imóvel arrendado com sucesso!");
                }
            }
        }

        private void BtnLibertar_Click(object sender, RoutedEventArgs e)
        {
            var imovel = (sender as Button)?.DataContext as Imovel;
            if (imovel == null) return;

            if (MessageBox.Show("Desejas libertar este imóvel e remover o inquilino?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                
                imovel.InquilinoId = 0;

                
                DataStorage.SalvarImoveis(App.ImovelManager.Imoveis);

                
                if (this.DataContext is ListImoveisViewModel vm)
                {
                    var index = vm.ListaImoveis.IndexOf(imovel);
                    if (index != -1)
                    {
                        vm.ListaImoveis.RemoveAt(index);
                        vm.ListaImoveis.Insert(index, imovel);
                    }
                }
            }
        }
    }
}
