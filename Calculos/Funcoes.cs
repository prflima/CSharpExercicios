namespace Calculos
{
    public class Funcoes
    {
        /// <summary>
        /// O método Soma recebe um array de números
        /// e realiza a soma entre eles
        /// </summary>
        /// <param name="valores">Passe um vetor de doubles</param>
        /// <returns>Retorna o resultado da soma</returns>
        public double Soma(double[] valores)
        {
            double rs = 0;
            for (int x = 0; x < valores.Length; x++)
                rs += valores[x];

            return rs;
        }

        /// <summary>
        /// O método realiza a média dos números
        /// passados
        /// </summary>
        /// <param name="valores">Passe um vetor de doubles</param>
        /// <returns>Retorna o resultado da Média</returns>
        public double Media(double[] valores)
        {
            double rs = 0;
            for (int x = 0; x < valores.Length; x++)
                rs += valores[x];

            return rs / valores.Length;
        }

        /// <summary>
        /// O método Potencia realiza o cáculo de
        /// potenciação usando os valores passados 
        /// pelo usuário.
        /// </summary>
        /// <param name="bs">Passe o valor da base</param>
        /// <param name="ex">Passe o valor do expoente</param>
        /// <returns>Retorna o resultado no formato double</returns>
        public double Potencia(int bs, int ex)
        {
            double rs = 1;
            for (int i = 1; i <= ex; i++)
                rs *= bs;

            return rs;
        }

        /// <summary>
        /// O método Maior, recebe um array de números
        /// e retorna o maior entre eles.
        /// </summary>
        /// <param name="valores">Passe um vetor de doubles</param>
        /// <returns>Retorna o resultado no formato double</returns>
        public double Maior(double[] valores)
        {
            double m = valores[0];
            for (int p = 0; p < valores.Length; p++)
                if (valores[p] > m)
                    m = valores[p];

            return m;
        }

        /// <summary>
        /// O método Menor, recebe um array de números
        /// e retorna o menor entre eles.
        /// </summary>
        /// <param name="valores">Passe um vetor de doubles</param>
        /// <returns>Retorna o resultado no formato double</returns>
        public double Menor(double[] valores)
        {
            double m = valores[0];
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] < m)
                    m = valores[i];
            }
            return m;
        }
    }
}