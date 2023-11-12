using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool JsonSerializar(Pessoa pessoa, string path)
        {
            var strJson = JsonConvert.SerializeObject(pessoa);
            return SaveFilePessoa(strJson, path);


        }
        public bool SaveFilePessoa(string strJson, string path)
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    sr.WriteLine(strJson);


                }
                return true;
            }
            catch (Exception at)
            {
                MessageBox.Show("Falha " + at.Message);
                return false;
            }

        }
        public static Pessoa JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Pessoa>(Json);
        }

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
