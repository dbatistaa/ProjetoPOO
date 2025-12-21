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
    /// Lógica interna para ListUsersWindow.xaml
    /// </summary>
    public partial class ListUsersWindow : Window
    {
        public Utilizador SelectedUser { get; private set; }

        public ListUsersWindow()
        {
            InitializeComponent();

            this.DataContext = new ListUsersViewModel();
        }

        private void BtnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            
            SelectedUser = (sender as Button)?.DataContext as Utilizador;

            if (sender is Button btn && btn.DataContext is Utilizador user)
            {
                SelectedUser = user;
                this.DialogResult = true; 
                this.Close();
            }
        }
    }
}
