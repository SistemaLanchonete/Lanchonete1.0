﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01___Sistema_de_Lanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login();  
            a.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastar a = new Cadastar();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Cadastar a = new Cadastar();
            a.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
