using MySql.Data.MySqlClient;
namespace windowsFforms_login
{

    public partial class Loguin : Form
    {
        private MySqlConnection conexao;
        private string datasource = "datasource = localhost; username = root; password= ; database = controle; Allow zero datetime=True;";
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
            txtSenhaLoguin.PasswordChar = checkBox_mostrarSenha.Checked ? '\0' : '*';
        }

        private void linkRealizarCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telacriarCadastro criar = new telacriarCadastro();
            criar.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(datasource);
                void limpaForms()
                {
                    textUsuarioLoguin.Text = string.Empty;
                    txtSenhaLoguin.Text = string.Empty;

                }
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;


                if (string.IsNullOrWhiteSpace(textUsuarioLoguin.Text) || string.IsNullOrWhiteSpace(txtSenhaLoguin.Text))
                {
                    MessageBox.Show("Os campos devem ser preenchidos!!",
                                      "Erro",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    limpaForms();
                    textUsuarioLoguin.Focus();
                    return;
                }


                //verifica se o usuario existe 
                cmd.CommandText = "SELECT COUNT(*) FROM cadastro WHERE usuario = @usuario";

                cmd.Parameters.AddWithValue("@usuario", txtSenhaLoguin.Text);

                int existe = Convert.ToInt32(cmd.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("Usuário não cadastrado",
                                    "Erro",
                                    MessageBoxButtons.OK);
                    limpaForms();
                    textUsuarioLoguin.Focus();
                    return;
                }
                else
                //verifica a senha 
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@usuario", textUsuarioLoguin.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenhaLoguin.Text);

                    cmd.CommandText = "SELECT COUNT(*) FROM cadastro WHERE usuario = @usuario AND senha = @senha";

                    int naoExiste = Convert.ToInt32(cmd.ExecuteScalar());

                    if (naoExiste == 0)
                    {
                        MessageBox.Show("Senha Incorreta!",
                                        "Erro",
                                        MessageBoxButtons.OK);
                        textUsuarioLoguin.Focus();
                        return;
                    }

                    else
                    {
                        telaloguinSucess sucesso = new telaloguinSucess();
                        this.Hide();
                        sucesso.Show();

                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
