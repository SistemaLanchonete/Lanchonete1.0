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

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_Conf_email.Clear();
            tx_senha.Clear();
            tx_cpf.Clear();
            tx_Conf_senha.Clear();
            tx_Conf_email.Clear();
            tx_Email.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
