namespace _01___Sistema_de_Lanchonete
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tx_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_cardapio = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.lb_senhaI = new System.Windows.Forms.Label();
            this.bt_salvar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(90, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(90, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(260, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 71);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(94, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Lembrar Senha";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.Transparent;
            this.tx_email.BorderRadius = 17;
            this.tx_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_email.DefaultText = "";
            this.tx_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_email.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.tx_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tx_email.ForeColor = System.Drawing.Color.Black;
            this.tx_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_email.Location = new System.Drawing.Point(164, 154);
            this.tx_email.Name = "tx_email";
            this.tx_email.PasswordChar = '\0';
            this.tx_email.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.tx_email.PlaceholderText = "";
            this.tx_email.SelectedText = "";
            this.tx_email.Size = new System.Drawing.Size(367, 31);
            this.tx_email.TabIndex = 12;
            this.tx_email.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // tx_senha
            // 
            this.tx_senha.BackColor = System.Drawing.Color.Transparent;
            this.tx_senha.BorderRadius = 17;
            this.tx_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_senha.DefaultText = "";
            this.tx_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_senha.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.tx_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_senha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tx_senha.ForeColor = System.Drawing.Color.Black;
            this.tx_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_senha.Location = new System.Drawing.Point(164, 215);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tx_senha.PlaceholderText = "";
            this.tx_senha.SelectedText = "";
            this.tx_senha.Size = new System.Drawing.Size(367, 31);
            this.tx_senha.TabIndex = 13;
            // 
            // bt_cardapio
            // 
            this.bt_cardapio.AnimatedGIF = true;
            this.bt_cardapio.BackColor = System.Drawing.Color.Transparent;
            this.bt_cardapio.BorderColor = System.Drawing.SystemColors.Desktop;
            this.bt_cardapio.BorderRadius = 19;
            this.bt_cardapio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_cardapio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_cardapio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_cardapio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_cardapio.Enabled = false;
            this.bt_cardapio.FillColor = System.Drawing.Color.Gray;
            this.bt_cardapio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cardapio.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_cardapio.Location = new System.Drawing.Point(391, 273);
            this.bt_cardapio.Name = "bt_cardapio";
            this.bt_cardapio.Size = new System.Drawing.Size(211, 46);
            this.bt_cardapio.TabIndex = 14;
            this.bt_cardapio.Text = "Visualizar Cardápio";
            this.bt_cardapio.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button2.BackgroundImage")));
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 19;
            this.guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2Button2.Location = new System.Drawing.Point(40, 45);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Button2.PressedDepth = 2;
            this.guna2Button2.Size = new System.Drawing.Size(39, 57);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // lb_senhaI
            // 
            this.lb_senhaI.AutoSize = true;
            this.lb_senhaI.Location = new System.Drawing.Point(549, 223);
            this.lb_senhaI.Name = "lb_senhaI";
            this.lb_senhaI.Size = new System.Drawing.Size(39, 13);
            this.lb_senhaI.TabIndex = 16;
            this.lb_senhaI.Text = "label1";
            // 
            // bt_salvar
            // 
            this.bt_salvar.BorderRadius = 17;
            this.bt_salvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_salvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_salvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_salvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_salvar.FillColor = System.Drawing.Color.Gray;
            this.bt_salvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.White;
            this.bt_salvar.Location = new System.Drawing.Point(203, 274);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(180, 45);
            this.bt_salvar.TabIndex = 17;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 383);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.lb_senhaI);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.bt_cardapio);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2TextBox tx_email;
        private Guna.UI2.WinForms.Guna2TextBox tx_senha;
        private Guna.UI2.WinForms.Guna2Button bt_cardapio;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label lb_senhaI;
        private Guna.UI2.WinForms.Guna2Button bt_salvar;
    }
}