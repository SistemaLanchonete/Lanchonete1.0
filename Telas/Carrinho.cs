﻿using System;
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
    public partial class Carrinho : Form
    {
        private double valorTotal;
        class produto
        {
            public string nome;
            public double preco;
        }
        List<produto> LISTA_PRODUTOS;
        List<produto> LISTA_COMPRAS;
        public Carrinho()
        {
            InitializeComponent();
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            LISTA_PRODUTOS = new List<produto>()
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
            foreach (produto p in LISTA_PRODUTOS)
            {
                lista_produto.Items.Add(ConstruirLinhaProduto(p)); // Constroi as linhas de produtos
            }
            IniciarCompras();
        }
        private string ConstruirLinhaProduto(produto p)
        {
            string preco = p.preco.ToString("R$ 0.00") ;
            return p.nome + new string(' ', 30 - p.nome.Length - preco.Length) + preco;
        }
        private void IniciarCompras()
        {
            LISTA_COMPRAS = new List<produto>();
            lista_compra.Items.Clear();
            lb_total.Text = "R$ 0.00 ";
        }

        private void AdicionarProdutoCompra(produto p) // Add os produto em compras quando clico sobre algum produto em lista produto
        {
            LISTA_COMPRAS.Add(p); // Aqui estva o erro (era lista produto que projetava errado, e então os produtos serão levados para lista compra)
            lista_compra.Items.Add(ConstruirLinhaProduto(p)); // Aqui coloca os produtos na lista compra

            var total = LISTA_COMPRAS.Sum(I => I.preco);
            lb_total.Text = total.ToString("R$ 0.00"); // Valor Total

        }
        private void bt_nvcompra_Click(object sender, EventArgs e)
        {
            IniciarCompras();
        }
       
        private void lista_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lista_compras_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento relizado com Sucesso! Bom Apetite!");
            if (LISTA_COMPRAS.Count > 0)
            {
                MessageBox.Show("Compra Finalizada!" + Environment.NewLine + lb_total.Text);
                IniciarCompras();
                Tela_Pagamento telapagamento = new Tela_Pagamento();
                 telapagamento.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um produto para adicionar ao carrinho.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_total_Click(object sender, EventArgs e)
        {

        }

        private void lista_produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lista_produto_DoubleClick(object sender, EventArgs e)
        {
            if (lista_produto.SelectedIndex == -1) return;
            produto p = LISTA_PRODUTOS[lista_produto.SelectedIndex];
            AdicionarProdutoCompra(p);
        }
    }
}
