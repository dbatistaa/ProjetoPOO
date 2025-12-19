using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhoPOO.Models.Entidades;
using System.Windows.Input;

namespace trabalhoPOO.ViewModels
{
    public ICommand RegisterCommand { get; }
    public class RegistryViewModel
    {
        private readonly RegistryManager _manager;

        public string Email { get; set; }
        public string Password { get; set; }
        public string NivelAcesso { get; set; } = "Inquilino"; // Valor por defeito

        public ICommand RegisterCommand { get; }

        public RegistryViewModel(RegistryManager manager)
        {
            _manager = manager;
            RegisterCommand = new RelayCommand(ExecuteRegister);
        }

        private void ExecuteRegister()
        {
            // Aqui usas o teu RegistryManager que criamos antes
            bool sucesso = _manager.Registrar(Email, Password, NivelAcesso, 0);

            if (sucesso)
            {
                // Lógica para fechar janela ou mostrar mensagem
                System.Windows.MessageBox.Show("Registado com sucesso!");
            }
        }
    }
}
