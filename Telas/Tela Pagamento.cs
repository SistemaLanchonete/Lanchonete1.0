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
    public partial class Tela_Pagamento : Form
    {
        private List<produto> listaProdutos;
        public Tela_Pagamento()
        {
            InitializeComponent();
            

            
        }
        class produto
        {
            public string nome;
            public double preco;
        }
        

        List<produto> LISTA_PRODUTOS_PAGA;
        List<produto> LISTA_COMPRAS_PAGA;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento relizado com Sucesso! Bom Apetite!");
        }

        private void lb_total_Click(object sender, EventArgs e)
        {
          
        }
        private void AdicionarProdutoCompra(produto p) // Add os produto em compras quando clico sobre algum produto em lista produto
        {
      
            var total = LISTA_COMPRAS_PAGA.Sum(I => I.preco);
            lb_total_paga.Text = total.ToString("R$ 0.00");
        }
        private void bt_nvcompra_Click(object sender, EventArgs e)
        {
            IniciarCompras();
        }

        private string ConstruirLinhaProduto(produto p)
        {
            string preco = p.preco.ToString("R$ 0.00");
            return p.nome + new string(' ', 30 - p.nome.Length - preco.Length) + preco;
        }
        private void IniciarCompras()
        {
            LISTA_COMPRAS_PAGA = new List<produto>();
        
            lb_total_paga.Text = "R$ 0.00 ";
        }

  
        private void Tela_Pagamento_Load(object sender, EventArgs e)
        {
            LISTA_PRODUTOS_PAGA = new List<produto>()
            {

                new produto() { nome = "Pizza", preco = 15.00 },
                new produto() { nome = "Hamburguer", preco = 13.00},
                new produto() { nome = "Tapioca", preco = 5.00 },
                new produto() { nome = "Churros", preco = 4.00},
                new produto() { nome = "Salgados", preco = 6.00},
                new produto() { nome = "Coxinha", preco = 3.00},
                new produto() { nome = "Esfirra", preco = 1.50},
                new produto() { nome = "Brownie", preco = 3.00 },
                new produto() { nome = "Pastel", preco = 5.00},
                new produto() { nome = "Torta", preco = 4.00 },
                new produto() { nome = "Milk Sheik", preco = 7.00 },
                 new produto() { nome = "Coca Cola 220 ml", preco = 4.50 }
            };
            foreach (produto p in LISTA_PRODUTOS_PAGA)
            {
                lista_produtos_paga.Items.Add(ConstruirLinhaProduto(p)); // Constroi as linhas de produtos
            }
            IniciarCompras();
        }

        private void lista_compra_paga_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lista_compra_paga_DoubleClick(object sender, EventArgs e)
        {

            if (lista_produtos_paga.SelectedIndex == -1) return;
            produto p = LISTA_PRODUTOS_PAGA[lista_produtos_paga.SelectedIndex];
            AdicionarProdutoCompra(p);
        }

        private void lista_produtos_paga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true)
            {
                checkBox2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true)
            {
                checkBox1.Enabled = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Enabled)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;

            }
            if (!checkBox1.Enabled)
            {
                checkBox1.Enabled = true;
                checkBox1.Checked = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox2.Checked = false;
            }
        }
    }
}
