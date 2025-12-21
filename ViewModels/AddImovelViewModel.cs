using System.Windows;
using System.Windows.Input;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.ViewModels
{
    public class AddImovelViewModel : BaseViewModel
    {
        private readonly ImovelManager _imovelManager;
        private readonly int _ownerId; // Guardamos o ID do utilizador logado

        public string Morada { get; set; }
        public string ValorRenda { get; set; }
        public string TipoImovel { get; set; }
        public ICommand SaveImovelCommand { get; }

        // O construtor agora recebe também o ID do utilizador
        public AddImovelViewModel(ImovelManager imovelManager, int ownerId)
        {
            _imovelManager = imovelManager ?? App.ImovelManager;
            _ownerId = ownerId;
            SaveImovelCommand = new RelayCommand<object>(ExecuteSave);
        }

        private void ExecuteSave(object parameter)
        {
            if (_imovelManager == null)
            {
                MessageBox.Show("Erro: O sistema não detetou o gestor de imóveis.");
                return;
            }

            if (double.TryParse(ValorRenda, out double renda))
            {
                int novoId = _imovelManager.Imoveis.Any() ? _imovelManager.Imoveis.Max(i => i.Id) + 1 : 1;

                
                Imovel novo = new Imovel
                {
                    Id = novoId,
                    Morada = Morada,
                    ValorRenda = renda,
                    ProprietarioId = _ownerId,
                    TipoImovel = TipoImovel
                };

                _imovelManager.AdicionarImovel(novo);
                DataStorage.SalvarImoveis(_imovelManager.Imoveis);

                MessageBox.Show("Imóvel registado com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor de renda válido.");
            }
        }
    }
}