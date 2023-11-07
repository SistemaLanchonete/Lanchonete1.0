using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Sistema_de_Lanchonete.Entidades
{
    internal class Cliente : Pessoa
    {
        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, DateTime dataNasc, string email, string telefone, string nacionalidade, string genero, string tipoconta)
        : base(nome, cpf, dataNasc, email, telefone, nacionalidade, genero, tipoconta)
        {

        }

    }
}
