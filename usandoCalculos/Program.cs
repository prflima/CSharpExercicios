using System;
using Calculos;

namespace usandoCalculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int acao=0;

            Operacoes op = new Operacoes();
            Console.WriteLine("Digite um numero:");
            op.numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero:");
            op.numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja fazer?\n1- Soma\n2- Subtrai\n3- Dividir\n4-Multiplica");
            acao = int.Parse(Console.ReadLine());

            if(acao == 1)
                Console.WriteLine(op.Soma());
            else if(acao == 2)
                Console.WriteLine(op.Subtrair());
            else if(acao == 3)
                Console.WriteLine(op.Dividir());
            else if(acao == 4)
                Console.WriteLine(op.Multiplicar());
            else 
                Console.WriteLine("Essa função não existe!");       
            
    
        }
    }
}
