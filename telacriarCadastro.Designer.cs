namespace windowsFforms_login
{
    partial class telacriarCadastro
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
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            buttonEnviar = new Button();
            linkLoguin = new LinkLabel();
            label3 = new Label();
            txtconfirmarSenha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 160);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Criar usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 216);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Criar senha:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(122, 178);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(200, 23);
            txtUser.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(122, 234);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(200, 23);
            txtSenha.TabIndex = 3;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(122, 330);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 5;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // linkLoguin
            // 
            linkLoguin.AutoSize = true;
            linkLoguin.LinkColor = Color.SteelBlue;
            linkLoguin.Location = new Point(176, 365);
            linkLoguin.Name = "linkLoguin";
            linkLoguin.Size = new Size(107, 15);
            linkLoguin.TabIndex = 6;
            linkLoguin.TabStop = true;
            linkLoguin.Text = "Já possui cadastro?";
            linkLoguin.LinkClicked += linkLoguin_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(122, 273);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Confirma senha:";
            // 
            // txtconfirmarSenha
            // 
            txtconfirmarSenha.Location = new Point(122, 291);
            txtconfirmarSenha.Name = "txtconfirmarSenha";
            txtconfirmarSenha.PasswordChar = '*';
            txtconfirmarSenha.Size = new Size(200, 23);
            txtconfirmarSenha.TabIndex = 4;
            // 
            // criarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(443, 472);
            Controls.Add(txtconfirmarSenha);
            Controls.Add(label3);
            Controls.Add(linkLoguin);
            Controls.Add(buttonEnviar);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "criarCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Button buttonEnviar;
        private LinkLabel linkLoguin;
        private Label label3;
        private TextBox txtconfirmarSenha;
    }
}