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
            label8.Text = "";
            label9.Text = "";
            label6.Text = "";

        }

        private void Cadrastar_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void bt_salvar_cadrastro_Click(object sender, EventArgs e)
        {
        
                Pessoa pessoa = new Pessoa();
                string cpf = tx_cpf.Text;
                bool dadosValidos = true; // Verificador de todos os campos válidos.

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
                        dadosValidos = false;

                    }
                }
                catch (Exception ex)
                {
                    // Tratar a exceção, se necessário
                    Console.WriteLine($"Erro ao validar CPF: {ex.Message}");
                    dadosValidos = false;
                    
                }

                if (tx_senha.Text == tx_Conf_senha.Text)
                {
                    label8.Text = "";
                }
                else
                {
                    label8.ForeColor = Color.Red;
                    label8.Text = "As senha não são as mesmas!";
                    dadosValidos = false;
                }

                if (tx_Email.Text == tx_Conf_email.Text)
                {
                    label9.Text = "";
                }
                else
                {
                    label9.ForeColor = Color.Red;
                    label9.Text = "0s Emails não são os mesmos!";
                    dadosValidos = false;
                }

                if (dadosValidos)
                {
                    MessageBox.Show($"Os dados são: {tx_nome.Text + " " + tx_cpf.Text + " " + label1.Text + " " + tx_senha.Text + " " + tx_Conf_senha.Text}");
                    MessageBox.Show($"Salvo com Sucesso!");
                }
        }  

        private void tx_Conf_senha_TextChanged(object sender, EventArgs e)
        {

        }
        private void tx_Conf_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();    
            tx_Conf_email.Clear();
            tx_senha.Clear();   
            tx_cpf.Clear();
            tx_Conf_senha.Clear();
            tx_Conf_email.Clear();
            tx_Email.Clear();   
    
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tx_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
