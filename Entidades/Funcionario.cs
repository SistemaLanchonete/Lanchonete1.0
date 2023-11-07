using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Sistema_de_Lanchonete.Entidades
{
    internal class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public int CargaHoraria { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string cargo, double salario, int cargaHoraria, string nome, string cpf, DateTime dataNasc, string email, string telefone, string nacionalidade, string genero, string tipoconta)
        : base(nome, cpf, dataNasc, email, telefone, nacionalidade, genero, tipoconta)
        {
            Cargo = cargo;
            Salario = salario;
            CargaHoraria = cargaHoraria;
        }
    }
}
