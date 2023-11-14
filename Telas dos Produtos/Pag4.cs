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
    public partial class Pag4 : Form
    {
        public Pag4()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_hamburguer.Text = "R$ 13.00";
            }
            else
            {
                bt_verpreco_tapioca.Text = "Ver Preço";
            }
        }

   

        private void bt_verpreco_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_tapioca.Text = "R$ 5.00";
            }
            else
            {
                bt_verpreco_tapioca.Text = "Ver Preço";
            }
        }

        private void bt_estoque_Click(object sender, EventArgs e)
        {
            bt_estoque_tapioca.Text = "12";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_cocacola.Text = "R$ 4.50";
            }
            else
            {
                bt_verpreco_cocacola.Text = "Ver Preço";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bt_estoque_cocacola.Text = "11";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            bt_estoque_hamburguer.Text = "13";
        }
    }
}
