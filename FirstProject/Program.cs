using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double n1;
            double n2;
            double soma, subtrair, multiplicar, dividir, resto;

            n1=50;
            n2=20;

            soma = n1+n2;
            subtrair = n1-n2;
            multiplicar = n1*n2;
            dividir = n1/n2;
            resto = n1%n2;
            Console.WriteLine("A Soma de"+n1+" e "+n2+"é igual a"+soma);
            Console.WriteLine("A Subtração de"+n1+" e "+n2+"é igual a"+subtrair);
            Console.WriteLine("A Multiplicação de"+n1+"e"+n2+"é igual a"+multiplicar);
            Console.WriteLine("A divisão de"+n1+"e"+n2+"é igual a"+dividir);
            Console.WriteLine("O resto da divisão entre "+n1+ "e" +n2+"é igual a" +resto);
        }
    }
}
