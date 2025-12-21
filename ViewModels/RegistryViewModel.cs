using System.Windows;
using System.Windows.Input;
using trabalhoPOO.Models.Entidades;
using trabalhoPOO.ViewModels;

namespace trabalhoPOO.ViewModels
{
    public class RegistryViewModel
    {
        private readonly RegistryManager _registryManager;
        public event Action OnRequestLogin;


        public string Email { get; set; }
        public string NivelAcesso { get; set; }
        public string IdPessoa { get; set; } 

        public ICommand RegisterCommand { get; }

        public ICommand GoToLoginCommand { get; } 

        public RegistryViewModel(RegistryManager registryManager)
        {
            _registryManager = registryManager;
            RegisterCommand = new RelayCommand<object>(ExecuteRegister);

            GoToLoginCommand = new RelayCommand<object>(obj => OnRequestLogin?.Invoke());
        }

        #region Registar User

        private void ExecuteRegister(object parameter)
        {
            var passwordBox = parameter as System.Windows.Controls.PasswordBox;
            string password = passwordBox?.Password;

            
            if (!int.TryParse(IdPessoa, out int idPessoaInt))
            {
                MessageBox.Show("O ID da Pessoa deve ser um número.");
                return;
            }

            
            bool sucesso = _registryManager.Registrar(Email, password, NivelAcesso, idPessoaInt);

            if (sucesso)
            {
                DataStorage.SalvarUtilizadores(_registryManager.Users);

                MessageBox.Show("Conta criada com sucesso!");
                OnRequestLogin?.Invoke();

            }
            else
            {
                MessageBox.Show("Erro ao registar. Verifique se o email já existe.");
            }
        }
        #endregion


    }
}