using System;

namespace ProjetoLoja.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }  
        public DateTime DataCadastro { get; set; }  

        public Cliente()
        {
            
        }
        public Cliente(int id, string nome, string sobrenome, string email, DateTime datacadastro)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Email = email;
            this.DataCadastro = datacadastro;        
        }
    }
}