using System;
using System.Windows.Forms;

namespace ponto_semanal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void btnentrar_Click(object sender, EventArgs e)
        {
            string nome = textUsuario.Text;
            string senha = textSenha.Text;
            if (CadastroUsuario.login(nome, senha))
            {
                textSenha.Text = String.Empty;
                textUsuario.Text = string.Empty;
                this.Visible = false;

                using (Form1 frm = new Form1())
                {
                    frm.ShowDialog();
                }
                this.Visible = true;    
            }
            else
            {
                MessageBox.Show("Acesso Negado");
          
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
