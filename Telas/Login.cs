using _01___Sistema_de_Lanchonete.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _01___Sistema_de_Lanchonete
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
             private bool butaosalva = false;
             
    

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tela_Cardapio a = new Tela_Cardapio();
            a.ShowDialog();
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            butaosalva = false;
            bt_salvar.Enabled = false;
            bt_cardapio.Enabled = false;
            Tela_Cardapio a = new Tela_Cardapio();
            a.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (tx_email.Text == "admin" && tx_senha.Text == "1234")
            //{
            //    new Tela_Cardapio().ShowDialog();
            //}
            //else
            //{

            //    int conta = 0;
            //    if (tx_email.Text != "")
            //    {
            //        conta = Convert.ToInt32(tx_email.Text);
            //    }
            //    string senha = tx_senha.Text;

                //Pessoa c = Pessoa.BuscarContas().SingleOrDefault(x => x.Nconta == conta);

                //if (c != null && c.Senha.Equals(senha))
                //{
                //    lb_senhaI.Text = "";
                //    new Home(c).ShowDialog();
                //}
                //else
                //{
                //    lb_senhaI.Text = "Número de Conta ou Senha Inválidos!";
                //}

            //}
        }

        private void guna2Button3_Click(object sender, EventArgs e) // Salvar
        {

            bt_salvar.Enabled = false;
            bt_cardapio.Enabled = true;
            butaosalva = true;

            if (bt_salvar.Enabled == true)
            {
                
            }

            else if (bt_salvar.Enabled != true)
           {
               
            }
            string email = tx_email.Text.Trim();

            if (IsValidEmail(email))
            {
                MessageBox.Show("Salvo com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O e-mail não é válido. Por favor, insira um e-mail válido.", "Validação de E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            // Esta expressão regular verifica se o formato do e-mail é válido
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
    }
}