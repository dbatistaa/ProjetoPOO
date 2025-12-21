using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO 
{
    public static class DataStorage
    {

        private static string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utilizadores.json");
        private static string imoveisPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imoveis.json");

        #region GuardaUtilizadores
        public static void SalvarUtilizadores(List<Utilizador> users)
        {
            try
            {
                string json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Erro ao guardar: " + ex.Message);
            }
        }

        public static List<Utilizador> CarregarUtilizadores()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<Utilizador>();
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Utilizador>>(json) ?? new List<Utilizador>();
            }
            catch
            {
                return new List<Utilizador>();
            }
        }

        #endregion

        #region GuardarImoveis

        public static void SalvarImoveis(List<Imovel> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(imoveisPath, json);
        }

        public static List<Imovel> CarregarImoveis()
        {
            try
            {
                if (!File.Exists(filePath)) return new List<Imovel>();
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Imovel>>(json) ?? new List<Imovel>();
            }
            catch
            {
                return new List<Imovel>();
            }
        }

        #endregion
    }
}