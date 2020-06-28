using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozReceitas_App
{
    public partial class FormNovaSenha : Form
    {

        // Referencia da Conexao
        SqlConnection Conexao = new SqlConnection(@"Data Source=CALLEB\SQLEXPRESS;Initial Catalog=MozReceitasApp;Integrated Security=True");
        Usuario usuarioLogado = Usuario.usuarioLogado;

        public FormNovaSenha()
        {
            InitializeComponent();
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {

            if (edtSenhaAntiga.Text != usuarioLogado.getSenha())
            {
                // ERRO as senhas nao sao iguais

                MessageBox.Show("A senha antiga esta incorrecta!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Definir nova senha

                if (edtNovaSenha.Text.Length < 6)
                {

                    // ERRO numero de caracteres da senha
                    MessageBox.Show("A nova senha deve ter mais de 5 digitos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    String email = usuarioLogado.getEmail();

                    Conexao.Open();

                    String query = "UPDATE Usuario SET senha = '" + edtNovaSenha.Text + "' WHERE email =  '" + email + "'";

                    SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);

                    DataTable dt = new DataTable();

                    dp.Fill(dt); // Preenche o DataTable com os dados retornados da query
                    Usuario.usuarioLogado.setSenha(edtNovaSenha.Text);

                    this.Hide();
                    Conexao.Close();
                    MessageBox.Show("Senha Alterada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
