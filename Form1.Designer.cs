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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            textUsuario = new TextBox();
            linkEsqueceuSenha = new LinkLabel();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.nice_systems196x1471;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(434, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.logo112x112;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(281, 493);
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
            label1.Location = new Point(162, 345);
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
            label2.Location = new Point(170, 390);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(232, 387);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(209, 23);
            txtSenha.TabIndex = 4;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(232, 342);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(209, 23);
            textUsuario.TabIndex = 5;
            // 
            // linkEsqueceuSenha
            // 
            linkEsqueceuSenha.AutoSize = true;
            linkEsqueceuSenha.LinkColor = Color.SteelBlue;
            linkEsqueceuSenha.Location = new Point(232, 438);
            linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            linkEsqueceuSenha.Size = new Size(117, 15);
            linkEsqueceuSenha.TabIndex = 6;
            linkEsqueceuSenha.TabStop = true;
            linkEsqueceuSenha.Text = "Esqueceu sua senha?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(232, 416);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Mostrar senha";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Loguin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(662, 669);
            Controls.Add(checkBox1);
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
            MaximizeBox = false;
            Name = "Loguin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nice";
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
        private CheckBox checkBox1;
    }
}