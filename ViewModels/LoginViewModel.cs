using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        private string _email; 
        private readonly LoginManager _loginManager;

        public event Action<Utilizador> OnLoginSuccess;
        public event Action OnRequestRegistry;
        public ICommand GoToRegistryCommand { get; }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public LoginViewModel(LoginManager gestorLogin)
        {
            _loginManager = gestorLogin;
            
            LoginCommand = new RelayCommand<object>(ExecuteLoginCommand, CanExecuteLoginCommand);

            GoToRegistryCommand = new RelayCommand<object>(obj => OnRequestRegistry?.Invoke());
        }   


        private void ExecuteLoginCommand(object parameter)
        {
            PasswordBox passwordBox = parameter as PasswordBox;
            if (passwordBox == null) return;

            string senha = passwordBox.Password;

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, insira a password.");
                return;
            }


            Utilizador utilizadorAutenticado = _loginManager.Autenticar(Email, senha);

            if (utilizadorAutenticado != null)
            {
                MessageBox.Show($"Bem-vindo, {utilizadorAutenticado.Email}!");
               
                OnLoginSuccess?.Invoke(utilizadorAutenticado);
            }
            else
            {
                MessageBox.Show("Email ou Password incorretos.");
            }
        }

        private bool CanExecuteLoginCommand(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Email);
        }
    }
}