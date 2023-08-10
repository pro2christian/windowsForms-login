using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFforms_login
{
    public partial class criarCadastro : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource = localhost; username = root; password = ; database = controle; Allow zero datetime=True";

        public criarCadastro()
        {
            InitializeComponent();
        }

        private void linkLoguin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loguin entrar = new Loguin();
            entrar.Show();
            this.Close();

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //insert
                conexao = new MySqlConnection(data_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtSenha.Text)){
                    MessageBox.Show("Os campos usúario & senha devem ser preenchidos",
                                    "Erro", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                    return;
                }
                                            
                var dt = DateTime.Now.ToString(@"yyy-MM-dd HH:mm:ss");
                cmd.CommandText = "INSERT INTO cadastro (usuario, senha, data)" +
                     "VALUES" +
                     "(@usuario,@senha,@data)";
                
                cmd.Parameters.AddWithValue("@usuario", txtUser.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("@data",dt);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Gravado com sucesso","Sucesso",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);

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
