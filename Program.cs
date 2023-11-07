using _01___Sistema_de_Lanchonete.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Sistema_de_Lanchonete
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void ListaProd()
        {
            List<Produtos> prod = new List<Produtos>();
            Produtos p = new Produtos("Lanche", 6.00, "desc");

            prod.Add(p);

            foreach (Produtos produto in prod)
            {
                Console.WriteLine(prod);
            }
        }
    }
}
