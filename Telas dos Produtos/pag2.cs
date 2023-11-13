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
    public partial class pag2 : Form
    {
        public pag2()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Carrinho a = new Carrinho();
            a.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Carrinho a = new Carrinho();
            a.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Carrinho a = new Carrinho();
            a.ShowDialog();
        }

        private void bt_verpreco_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_torta.Text = "R$ 4.00";
            }
            else
            {
                bt_verpreco_torta.Text = "Ver Preço";
            }
        }

        private void bt_estoque_Click(object sender, EventArgs e)
        {
            bt_estoque_torta.Text = "20";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_esfirra.Text = "R$ 13.00";
            }
            else
            {
                bt_verpreco_esfirra.Text = "Ver Preço";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bt_estoque_esfirra.Text = "18";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_salgadinhos.Text = "R$ 6.00";
            }
            else
            {
                bt_verpreco_salgadinhos.Text = "Ver Preço";
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            bt_estoque_salgadinhos.Text = "12";
        }
    }
}
