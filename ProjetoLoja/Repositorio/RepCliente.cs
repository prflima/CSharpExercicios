using System;
using ProjetoLoja.Dominio;
using MySql.Data; // Trabalha com volume de dados para cadastro ou consulta no banco
using MySql.Data.MySqlClient; // Estabele a comunicação com o banco
using System.Collections.Generic;
using System.Data;

namespace ProjetoLoja.Repositorio
{
    public class RepCliente
    {
        public List<Cliente> Listar()
        {


            // Vamos criar uma lista para guardar os clientes que
            // vem do banco de dados

            List<Cliente> lstClientes = new List<Cliente>();

            //Instância da classe MySQLConnection, nos permite
            //estabelecer a comunicação com o servidor de banco
            //de dados MySQL
            MySqlConnection conexao = new MySqlConnection();

            // Ajuda a executar dos comandos de SQL nas tabelas
            //do banco de dados loja
            MySqlCommand cmd = new MySqlCommand();

            // O DataReader é um leitor de dados. Vamos usá-lo para
            // guardar os dados retornados da consulta Select nas tabelas
            MySqlDataReader dr;

            //Especificar o caminho do servidor e demais dados
            //para a conexao
            conexao.ConnectionString = "Persist Security Info=False;database=dbloja;server=localhost;port=3306;sslmode=none;userid=root;password=senac@tat";
            try
            {
                conexao.Open(); // Abrir a conexao com servidor
                cmd.Connection = conexao;
                // Estabelece uma relação entre os comandos de sql com a conexao do banco de dados que vamos utilizar (dbloja).

                //Definir qual o tipo de comando que iremos
                // executar no banco de dados.

                cmd.CommandType = CommandType.Text;

                // Após a definição do tipo de comando com o text, iremos realizar
                // a consulta com um comando DML que será o SELECT.

                cmd.CommandText = "Select * from cliente";

                // Vamos executar a consulta acima. Para tal, usaremos
                // a variável dr que irá guardar o resultado do select e 
                // o comando ExecuteReader() -> Executa a Leitura.

                dr = cmd.ExecuteReader();

                // Enquanto houver dados na tabela, não pare de ler.
                // Para saber se há dados na tabela, utilizamos o comando
                // Read() -> Ler. Se ele é capaz de ler as linhas, isso significa
                // que existem mais dados na tabela. E assim irá ler
                // linha após linha, até chegar o fim da tabela.
                while(dr.Read())
                {
                    // A cada linha de dados extraída da tabela Clientes
                    // É passada para um novo objeto Cliente e assim seus dados
                    // são organizados e depois alocados em uma lista
                    // para que a próxima linha de dados da tabela, seja lida.

                    Cliente cli = new Cliente(); // Método construtor da nossa classe Cliente
                    cli.Id = dr.GetInt32(0); // Colocando na propriedade Id da nossa classe Cliente, o valor inteiro da coluna de posição 0 na nossa tabela de banco de dados
                    cli.Nome = dr.GetString(1); // Colocando na propriedade Nome da nossa classe Cliente, o valor string da coluna de posição 1 na nossa tabela de banco de dados
                    cli.Sobrenome = dr.GetString(2); // Colocando na propriedade Sobrenome da nossa classe Cliente, o valor string da coluna de posição 2 na nossa tabela de banco de dados
                    cli.Email = dr.GetString(3); // Colocando na propriedade Email da nossa classe Cliente, o valor string da coluna de posição 3 na nossa tabela de banco de dados
                    cli.DataCadastro = dr.GetDateTime(4); // Colocando na propriedade DataCadastro da nossa classe Cliente, o valor DateTime da coluna de posição 4 na nossa tabela de banco de dados

                    // Vamos guardar as informações de Cliente, na lista "lstClientes", e agrupar os dados enquanto o laço estiver rodando.
                    lstClientes.Add(cli);
                    
                } // Fim do while

            } // Fim do try
            catch(Exception ex)
            {
                throw new Exception("Erro ao tentar listar os clientes. "+ex.Message);
                // Como estamos criando uma lista e não uma string, vamos usar o método throw new, para retornar uma mensagem de erro.
            }
            finally
            {
                conexao.Close(); // Fechar a conexao com o banco de dados.
            }
            return lstClientes;
        }
    }
}