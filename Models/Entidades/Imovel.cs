using Newtonsoft.Json;
using System;
using System.Linq;

namespace trabalhoPOO.Models.Entidades
{
    public class Imovel
    {
        #region Propriedades Base
        public int Id { get; set; }
        public string Morada { get; set; }
        public double ValorRenda { get; set; }
        public int ProprietarioId { get; set; }
        public string TipoImovel { get; set; }
        public int InquilinoId { get; set; } 
        #endregion

        #region Propriedades Visuais (Não salvam no JSON)

        [JsonIgnore]
        public bool EstaDisponivel => InquilinoId == 0;

        [JsonIgnore]
        public string InquilinoStatus => EstaDisponivel ? "LIVRE" : "OCUPADO";

        [JsonIgnore]
        public string StatusColor => EstaDisponivel ? "Green" : "Red";

        [JsonIgnore]
        public string BotaoArrendarVisibility => EstaDisponivel ? "Visible" : "Collapsed";

        
        [JsonIgnore]
        public string BotaoLibertarVisibility => !EstaDisponivel ? "Visible" : "Collapsed";


        [JsonIgnore]
        public string NomeInquilino
        {
            get
            {
                if (InquilinoId == 0) return "---";

                
                var todosUtilizadores = DataStorage.CarregarUtilizadores();
                var user = todosUtilizadores.FirstOrDefault(u => u.Id == InquilinoId);

                return user != null ? user.Email : $"ID: {InquilinoId}";
            }
        }
        #endregion
    }
}