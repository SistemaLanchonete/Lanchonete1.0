using _01___Sistema_de_Lanchonete.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Sistema_de_Lanchonete
{
    public partial class Cadastar : Form
    {
        public Cadastar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            string cpf = tx_cpf.Text;

            try
            {
                ValidarCPF validarCpf = new ValidarCPF();
                if (validarCpf.ValidaCPF(cpf))
                {
                    label6.Visible = false;
                    pessoa.Cpf = cpf;
                }
                else
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "CPF é inválido";
                    tx_cpf.Clear();
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                // Tratar a exceção, se necessário
                Console.WriteLine($"Erro ao validar CPF: {ex.Message}");
            }



            if (tx_senha.Text == tx_Conf_senha.Text)
            {

                MessageBox.Show(tx_nome.Text + " " + tx_cpf.Text + " " + label1.Text + " " + tx_senha.Text + " " + tx_Conf_senha.Text);


            }
            else
            {
                label8.ForeColor = Color.Red;
                label8.Text = "As senha não são as mesmas!";
            }

            if (label1.Text == tx_Conf_email.Text)
            {

                MessageBox.Show(tx_nome.Text + " " + tx_cpf.Text + " " + label1.Text + " " + tx_senha.Text + " " + tx_Conf_senha.Text + " " + tx_Conf_email.Text);


            }
            else
            {
                label9.ForeColor = Color.Red;
                label9.Text = "0s Emails não são os mesmos!";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cadrastar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
