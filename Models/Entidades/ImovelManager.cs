using System;
using System.Collections.Generic;
using System.Linq;

namespace trabalhoPOO.Models.Entidades
{
    public class ImovelManager
    {
        private List<Imovel> _imoveis;
        public List<Imovel> Imoveis => _imoveis;

        // Construtor que aceita a lista carregada do JSON
        public ImovelManager(List<Imovel> initialImoveis)
        {
            _imoveis = initialImoveis ?? new List<Imovel>();
        }

        public void AdicionarImovel(Imovel novo)
        {
            _imoveis.Add(novo);
        }
    }
}