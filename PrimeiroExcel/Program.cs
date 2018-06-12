using System;
using NetOffice.ExcelApi;

namespace PrimeiroExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product registration program");
            Console.WriteLine("----------------------------");

            string nome, marca;
            int codigo, quantidade;
            double preco;

            Console.WriteLine("Enter product code");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product name");
            nome = Console.ReadLine();

            Console.WriteLine("Enter the product brand");
            marca = Console.ReadLine();

            Console.WriteLine("Enter the quantity of the product");
            quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of the product");
            preco = double.Parse(Console.ReadLine());

            //Processo de instância da classe ArquivoExcel.cs
            ArquivoExcel ae = new ArquivoExcel();
            ae.codigo = codigo;
            ae.nome = nome;
            ae.marca = marca;
            ae.quantidade = quantidade;
            ae.preco = preco;

            Console.WriteLine(ae.Salvar());
        }
    }
}
