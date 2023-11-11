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
    public partial class Tela_Cardapio : Form
    {
        public Tela_Cardapio()
        {
            InitializeComponent();
          
        }
        private void customizeDesigner()
        {
            panelSideMenu.Visible = false;
            panel_sub_menu.Visible = false; 
            panel_tools.Visible = false;
        }
        private void hidSubMenu()
        {
            if (panel_sub_menu.Visible == true)
                panel_sub_menu.Visible = false;
            if (panel_tools.Visible == true)
                panel_tools.Visible = false;    
                
        }
        private void showSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidSubMenu();
                subMenu.Visible = true; 
            }
            else
                subMenu.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Opcoes_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_sub_menu); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidSubMenu();
            openChildForm(new Telinha_de_compras());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
      
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
       
        }

        private void button9_Click(object sender, EventArgs e)
        {
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
       
        }

        private void button12_Click(object sender, EventArgs e)
        {
       
        }

        private void button13_Click(object sender, EventArgs e)
        {
         
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm; 
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new TelaCarrinho());
        }
    }
}
