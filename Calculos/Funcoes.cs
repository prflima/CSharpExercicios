namespace Calculos
{
    public class Funcoes
    {
        public double Soma(double[] valores)
        {
            double rs = 0;
            for(int x = 0; x < valores.Length; x++)
            rs += valores [x];

            return rs;
        }

        public double Media(double[]valores)
        {
            double rs  = 0;
            for(int x = 0; x < valores.Length; x++)
            rs += valores[x];

            return rs/valores.Length;
        }

        public double Potencia(int bs, int ex)
        {
            double rs = 1;
            for(int i = 1; i <= ex; i++)
            rs*=bs;

            return rs;
        }

        public double Maior(double[] valores)
        {
            double m = valores[0];
            for(int p = 0; p < valores.Length; p++)
                if(valores[p] > m)
                m = valores[p];

            return m;
        }
    }
}