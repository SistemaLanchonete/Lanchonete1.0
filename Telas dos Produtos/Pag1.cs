using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _01___Sistema_de_Lanchonete
{
    public partial class Pag1 : Form
    {
        public Pag1()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_churros.Text = "R$ 4.00";
            }
            else
            {
                bt_verpreco_churros.Text = "Ver Preço";
            }
        }

        private void bt_verpreco_Click(object sender, EventArgs e)
        {
            
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_pizza.Text = "R$ 15.00";
            }
            else
            {
                bt_verpreco_pizza.Text = "Ver Preço";
            }
            
        }

    
 
 
        private void bt_estoque_Click(object sender, EventArgs e)
        {
            bt_estoque.Text = "15";
        }

        

    

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bt_estoque_churros.Text = "4";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_milksheik.Text = "R$ 7.00";
            }
            else
            {
                bt_verpreco_milksheik.Text = "Ver Preço";
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            bt_estoque_milksheik.Text = "6";
        }
    }
}
