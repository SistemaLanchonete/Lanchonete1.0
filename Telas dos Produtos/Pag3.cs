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
    public partial class Pag3 : Form
    {
        public Pag3()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
    


        private void bt_verpreco_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_coxinha.Text = "R$ 3.00";
            }
            else
            {
                bt_verpreco_coxinha.Text = "Ver Preço";
            }
        }

        private void bt_estoque_Click(object sender, EventArgs e)
        {
            bt_estoque_coxinha.Text = "16";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_pastel.Text = "R$ 5.00";
            }
            else
            {
                bt_verpreco_coxinha.Text = "Ver Preço";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bt_estoque_pastel.Text = "16";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_brownie.Text = "R$ 3.00";
            }
            else
            {
                bt_verpreco_coxinha.Text = "Ver Preço";
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            bt_estoque_brownie.Text = "7";
        }
    }
}
