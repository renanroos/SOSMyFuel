using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSMyFuel
{
    /// <summary>
    /// Classe estática que faz os cálculos de quantidade
    /// Criado por Renan Roos
    /// 21/06/2016
    /// </summary>
    static class CalculaMedia
    {
        /// <summary>
        /// Método estático responsável por calcular quantos litros foram abastecidos
        /// Criado por Renan Roos
        /// 21/06/2016
        /// </summary>
        /// <param name="preco">Valor do litro de combustível</param>
        /// <param name="valor">Valor abastecido</param>
        /// <returns></returns>
        public static int calculaLitros(int preco, int valor)
        {
            //Renan Roos - 21/06/2016 - Cálculo da quantidade de litros abastecidos - Início
            return valor / preco;
            //Renan Roos - 21/06/2016 - Cálculo da quantidade de litros abastecidos - Fim
        }

        /// <summary>
        /// Método estático responsável por calcular a média de combustível
        /// Criado por Renan Roos
        /// 21/06/2016
        /// </summary>
        /// <param name="kms">Quantidade de quilômetros executados</param>
        /// <param name="litros">Quantidade de litros abastecidos (Fornecido pelo método calculaLitros)</param>
        /// <returns></returns>
        public static int calculaMedia(int kms, int litros)
        {
            //Renan Roos - 21/06/2016 - Cálculo da média de consumo de combustível - Início
            return kms / litros;
            //Renan Roos - 21/06/2016 - Cálculo da média de consumo de combustível - Fim
        }

    }
}
