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
            // LoginCommand = new ViewModelCommand(ExecuteLoginCommand);

            _loginManager = gestorLogin;

            // 2. Inicializa o comando, que agora pode usar _gestorLogin
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private void ExecuteLoginCommand(object parameter)
        {

            //     UserRepository userRepositoyr = new UserRepository();

            PasswordBox passwordBox = parameter as PasswordBox;
            // Console.WriteLine("Login Done");

            if (passwordBox != null)
            {
                string senha = passwordBox.Password;

                if (string.IsNullOrWhiteSpace(senha))
                {
                    // Tratar erro (senha vazia)
                    return;
                }

                // 2. Chamar o seu Gestor de Login (POO)
                Utilizador utilizadorAutenticado = _loginManager.Autenticar(Username, senha);

                if (utilizadorAutenticado != null)
                {
                    // Login bem-sucedido
                    Console.WriteLine("Login Done");
                }
                else
                {
                    // Credenciais inválidas
                }
            }
            else
            {
                // Se o CommandParameter não foi passado corretamente
                Console.WriteLine("Erro ao passar a senha.");
            }


        }

        private bool CanExecuteLoginCommand(object parameter)
        {
            // O comando só é permitido se o campo Username/Email não estiver vazio
            // O 'parameter' não é usado aqui, mas é obrigatório na assinatura
            return !string.IsNullOrWhiteSpace(Username);
        }
    }
}
