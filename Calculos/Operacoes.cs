using System;

namespace Calculos
{
    public class Operacoes
    {
        public double numero1;
        public double numero2;
        double resultado;
        
        /// <summary>
        /// O método Soma realiza a soma entre os 
        /// números: numero1 e numero2
        /// Ao final, retorna o resultado.
        /// </summary>
        /// <returns>Retorna o resultado da adição no formato double</returns>
        public double Soma()
        {
            resultado = numero1+numero2;
            return resultado;
        }

        /// <summary>
        /// O método Subtrair realiza o cálcilo da
        /// diferença entre os números 1 e 2, que
        /// foram adicionados anteriormente.
        /// </summary>
        /// <returns>Retorna o resultado da Subtração no formato double</returns>
        public double Subtrair()
        {
            resultado = numero1-numero2;
            return resultado;
        }

        /// <summary>
        /// O método Multiplicar realiza a multiplicação
        /// entre dois números: numero1 e numero2
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação no formato double</returns>
        public double Multiplicar()
        {
            resultado = numero1*numero2;
            return resultado;
        }
        /// <summary>
        /// O método Dividir realiza a divisão
        /// entre dois números: numero1 e numero2
        /// </summary>
        /// <returns>Retorna o resultado da divisão no formato double</returns>
        public double Dividir()
        {
            resultado = numero1/numero2;
            return resultado;
        }

    }    
}
