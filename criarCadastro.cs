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

    }
}
