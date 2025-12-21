using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO.Models.Entidades
{
    public class Imovel
    {
        #region
        public int Id { get; set; }
        public string Morada { get; set; }
        public double ValorRenda { get; set; }
        public int? IdInquilino { get; set; } // ID do utilizador que alugou
        public bool EstaDisponivel => IdInquilino == null;
        #endregion


    }
}
