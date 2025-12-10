using System.Windows.Controls;
using System.Windows.Input;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        private string _username;
        private string _password;
        private readonly LoginManager _loginManager;


        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        /*public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }*/


        public LoginViewModel(LoginManager gestorLogin)
        {
           

            _loginManager = gestorLogin;

            
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private void ExecuteLoginCommand(object parameter)
        {

            //     UserRepository userRepositoyr = new UserRepository();

            PasswordBox passwordBox = parameter as PasswordBox;

            if (passwordBox != null)
            {
                string senha = passwordBox.Password;

                if (string.IsNullOrWhiteSpace(senha))
                {
                    
                    return;
                }

                // 2. Chamar o seu Gestor de Login (POO)
                Utilizador utilizadorAutenticado = _loginManager.Autenticar(Username, senha);

                if (utilizadorAutenticado != null)
                {
                    
                    Console.WriteLine("Login Done");
                }
                else
                {
                    // Credenciais inválidas
                }
            }
            else
            {
                
                Console.WriteLine("Password Inválida.");
            }


        }

        private bool CanExecuteLoginCommand(object parameter)
        {
            
            return !string.IsNullOrWhiteSpace(Username);
        }
    }
}
