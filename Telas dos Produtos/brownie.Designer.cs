namespace _01___Sistema_de_Lanchonete
{
    partial class brownie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brownie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_estoque = new Guna.UI2.WinForms.Guna2Button();
            this.bt_verpreco = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_estoque);
            this.panel1.Controls.Add(this.bt_verpreco);
            this.panel1.Location = new System.Drawing.Point(-24, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 301);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Esfirra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-119, -122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 548);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bt_estoque
            // 
            this.bt_estoque.BackColor = System.Drawing.Color.Transparent;
            this.bt_estoque.BorderColor = System.Drawing.Color.Blue;
            this.bt_estoque.BorderRadius = 15;
            this.bt_estoque.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_estoque.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_estoque.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_estoque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_estoque.FillColor = System.Drawing.SystemColors.GrayText;
            this.bt_estoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_estoque.ForeColor = System.Drawing.Color.White;
            this.bt_estoque.Location = new System.Drawing.Point(498, 170);
            this.bt_estoque.Name = "bt_estoque";
            this.bt_estoque.Size = new System.Drawing.Size(127, 36);
            this.bt_estoque.TabIndex = 5;
            this.bt_estoque.Text = "Estoque";
            // 
            // bt_verpreco
            // 
            this.bt_verpreco.BackColor = System.Drawing.Color.Transparent;
            this.bt_verpreco.BorderColor = System.Drawing.Color.Blue;
            this.bt_verpreco.BorderRadius = 15;
            this.bt_verpreco.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_verpreco.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_verpreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_verpreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_verpreco.FillColor = System.Drawing.SystemColors.GrayText;
            this.bt_verpreco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_verpreco.ForeColor = System.Drawing.Color.White;
            this.bt_verpreco.Location = new System.Drawing.Point(498, 113);
            this.bt_verpreco.Name = "bt_verpreco";
            this.bt_verpreco.Size = new System.Drawing.Size(127, 36);
            this.bt_verpreco.TabIndex = 4;
            this.bt_verpreco.Text = "Ver Preço";
            // 
            // brownie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "brownie";
            this.Text = "brownie";
            this.Load += new System.EventHandler(this.brownie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button bt_estoque;
        private Guna.UI2.WinForms.Guna2Button bt_verpreco;
    }
}