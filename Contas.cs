using _01___Sistema_de_Lanchonete.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Sistema_de_Lanchonete
{
    internal class Contas: Pessoa
    {
        ////public static List<Conta> BuscarContas()
        ////{
        ////    List<Conta> contas = new List<Conta>();
        ////    try
        ////    {
        ////        List<Agencia> agencias = Agencia.BuscarAgencias();
        ////        List<Usuario> usuarios = Usuario.BuscarTodos();
        ////        string sourcePath = @"Arquivos/contas.txt";
        ////        List<string> linhas = File.ReadAllLines(sourcePath).ToList();
        ////        foreach (string line in linhas)
        ////        {
        ////            string[] aux = line.Split('|');
        ////            Conta conta = new Conta();
        ////            conta.Id_conta = Convert.ToInt32(aux[0]);
        ////            conta.Nconta = Convert.ToInt32(aux[1]);
        ////            conta.SaldoTotal = Convert.ToDouble(aux[2]);
        ////            conta.DataCriacao = Convert.ToDateTime(aux[3]);
        ////            conta.Chavepix = aux[4];
        ////            conta.Senha = aux[5];

        ////            Agencia a = agencias.SingleOrDefault(a => a.Id == Convert.ToInt32(aux[6]));
        ////            conta.Agencia = a;

        ////            Usuario usuario = usuarios.SingleOrDefault(a => a.Id_user == Convert.ToInt32(aux[7]));
        ////            conta.Usuario = usuario;
        ////            contas.Add(conta);
        ////        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao buscar as contas na base de dados " + ex.Message);
        //    }
        //    return contas;
        }
}
