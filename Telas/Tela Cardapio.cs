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
    public partial class Tela_Cardapio : Form
    {
        public Tela_Cardapio()
        {
            InitializeComponent();      
        }
        bool precoVisivel = true;
      
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Pag1()); // abre a janela na mesma janela
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new pag2());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Pag3());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Pag4());
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            activeForm.Close(); 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);  // define o local onde ira abrir
            panelChildForm.Tag = childForm; 
            childForm.BringToFront();
            childForm.Show();
        }


        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
       
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Carrinho a = new Carrinho();
            a.ShowDialog();
        }
    }
}
