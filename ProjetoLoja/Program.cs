using System;
using ProjetoLoja.Dominio;
using ProjetoLoja.Repositorio;

namespace ProjetoLoja
{
    class Program
    {
        static void Main(string[] args)
        {
            RepCliente rcliente = new RepCliente();

            foreach(Cliente cl in rcliente.Listar())
            {
                Console.WriteLine(cl.Id+"-"+cl.Nome+"-"+cl.Sobrenome+"-"+cl.Email+"-"+cl.DataCadastro);
            }
        }
    }
}
