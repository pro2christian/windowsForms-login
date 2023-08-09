namespace windowsFforms_login
{
    partial class Loguin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            textUsuario = new TextBox();
            linkEsqueceuSenha = new LinkLabel();
            checkBox_mostrarSenha = new CheckBox();
            linkRealizarCadastro = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(412, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 99);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.logo112x112;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(257, 495);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 126);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(138, 347);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(146, 392);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(208, 389);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(209, 23);
            txtSenha.TabIndex = 2;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(208, 344);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(209, 23);
            textUsuario.TabIndex = 1;
            // 
            // linkEsqueceuSenha
            // 
            linkEsqueceuSenha.AutoSize = true;
            linkEsqueceuSenha.LinkColor = Color.SteelBlue;
            linkEsqueceuSenha.Location = new Point(208, 447);
            linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            linkEsqueceuSenha.Size = new Size(117, 15);
            linkEsqueceuSenha.TabIndex = 4;
            linkEsqueceuSenha.TabStop = true;
            linkEsqueceuSenha.Text = "Esqueceu sua senha?";
            // 
            // checkBox_mostrarSenha
            // 
            checkBox_mostrarSenha.AutoSize = true;
            checkBox_mostrarSenha.ForeColor = Color.White;
            checkBox_mostrarSenha.Location = new Point(208, 418);
            checkBox_mostrarSenha.Name = "checkBox_mostrarSenha";
            checkBox_mostrarSenha.Size = new Size(101, 19);
            checkBox_mostrarSenha.TabIndex = 3;
            checkBox_mostrarSenha.Text = "Mostrar senha";
            checkBox_mostrarSenha.UseVisualStyleBackColor = true;
            checkBox_mostrarSenha.Click += checkBox_mostrarSenha_Click;
            // 
            // linkRealizarCadastro
            // 
            linkRealizarCadastro.AutoSize = true;
            linkRealizarCadastro.LinkColor = Color.SteelBlue;
            linkRealizarCadastro.Location = new Point(263, 624);
            linkRealizarCadastro.Name = "linkRealizarCadastro";
            linkRealizarCadastro.Size = new Size(100, 15);
            linkRealizarCadastro.TabIndex = 5;
            linkRealizarCadastro.TabStop = true;
            linkRealizarCadastro.Text = "Realizar cadastro?";
            // 
            // Loguin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(607, 669);
            Controls.Add(linkRealizarCadastro);
            Controls.Add(checkBox_mostrarSenha);
            Controls.Add(linkEsqueceuSenha);
            Controls.Add(textUsuario);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Loguin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Study project";
            Load += Loguin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private TextBox textUsuario;
        private LinkLabel linkEsqueceuSenha;
        private CheckBox checkBox_mostrarSenha;
        private LinkLabel linkRealizarCadastro;
    }
}