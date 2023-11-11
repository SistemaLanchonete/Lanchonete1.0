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
    }
}
