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
    }
}
