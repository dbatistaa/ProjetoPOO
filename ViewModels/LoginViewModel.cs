using System.Windows.Input;

namespace trabalhoPOO.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        private string _username;
        private string _password;


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

        public string Password
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
        }


        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand);
        }

        private void ExecuteLoginCommand(object parameter)
        {

       //     UserRepository userRepositoyr = new UserRepository();

            Console.WriteLine("Login Done");


        }

    }
}
