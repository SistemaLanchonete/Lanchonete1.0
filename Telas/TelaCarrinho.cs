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
    public partial class TelaCarrinho : Form
    {
        public TelaCarrinho()
        {
            InitializeComponent();
        }

        private void TelaCarrinho_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Tela_Pagamento j = new Tela_Pagamento();
            j.ShowDialog();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxColumn produtoColumn = new DataGridViewTextBoxColumn();
            produtoColumn.HeaderText = "Produto";
            guna2DataGridView1.Columns.Add(produtoColumn);

            DataGridViewTextBoxColumn precoColumn = new DataGridViewTextBoxColumn();
            precoColumn.HeaderText = "Preço";
            guna2DataGridView1.Columns.Add(precoColumn);

            DataGridViewImageColumn imagemColumn = new DataGridViewImageColumn();
            imagemColumn.HeaderText = "Imagem";
            guna2DataGridView1.Columns.Add(imagemColumn);

            // Adicione alguns dados de exemplo
            guna2DataGridView1.Rows.Add("Produto 1", 10.99);
            guna2DataGridView1.Rows.Add("Produto 2", 20.50);

            // Formate a exibição de dados monetários
            guna2DataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Formate apenas as células na coluna de preço
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                e.Value = string.Format("{0:C}", e.Value); // Formate como moeda
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

