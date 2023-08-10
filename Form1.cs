using MySql.Data.MySqlClient;
namespace windowsFforms_login
{

    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void Loguin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_mostrarSenha_Click(object sender, EventArgs e)
        {
            //mostrar senha
            txtSenha.PasswordChar = checkBox_mostrarSenha.Checked ? '\0' : '*';
        }

        private void linkRealizarCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            criarCadastro criar = new criarCadastro();
            criar.Show();
            this.Hide();
        }
    }
}
