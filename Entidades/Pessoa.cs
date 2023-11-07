using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Sistema_de_Lanchonete.Entidades
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nacionalidade { get; set; }
        public string Genero { get; set; }
        public string TipoConta { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, DateTime dataNasc, string email, string telefone, string nacionalidade, string genero, string tipoconta)
        {
            Nome = nome;
            Cpf = cpf;
            DataNasc = dataNasc;
            Email = email;
            Telefone = telefone;
            Nacionalidade = nacionalidade;
            Genero = genero;
        }
    }
}
