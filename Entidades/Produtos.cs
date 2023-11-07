using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Sistema_de_Lanchonete.Entidades
{
    internal class Produtos
    {
        public string NomeProd { get; set; }
        public double PrecoProd { get; set; }
        public string DescProd { get; set; }

        public Produtos() 
        { 
        
        }

        public Produtos(string nomeProd, double precoProd, string descProd)
        {
            NomeProd = nomeProd;
            PrecoProd = precoProd;
            DescProd = descProd;
        }



    }
}
