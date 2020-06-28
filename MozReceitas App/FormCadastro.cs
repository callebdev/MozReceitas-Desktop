using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MozReceitas_App
{
    public partial class FormCadastro : Form
    {

        // Referencia da Conexao
        SqlConnection Conexao = new SqlConnection(@"Data Source=CALLEB\SQLEXPRESS;Initial Catalog=MozReceitasApp;Integrated Security=True");

        public FormCadastro()
        {
            InitializeComponent();
            edtNome.Select();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (edtNome.Text.Length < 3 || edtEmail.Text.Length < 11 || edtSenha.Text.Length < 6 || edtSenhaRep.Text.Length < 6)
            {
                // Caso os valores nos campos nao sejam validos
                MessageBox.Show("Campos vazios ou incorrectos!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if(passwordIgual(edtSenha.Text, edtSenhaRep.Text) == false)
                {
                    // Caso a senha1 e senha2 nao sejam iguais
                    MessageBox.Show("As senhas nao sao iguas", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Senhas iguais -> Registrar usuario

                    Conexao.Open(); // Abre a conexao

                    string queryVerifica = "SELECT * FROM Usuario WHERE email  = '" + edtEmail.Text + "'";

                    string queryAdiciona = "INSERT INTO Usuario (nome, email, senha) values ('"+edtNome.Text+"', '"+edtEmail.Text+"', '"+edtSenha.Text+"')";

                    SqlDataAdapter sqlAdapter1 = new SqlDataAdapter(queryVerifica, Conexao);

                    DataTable dataTable1 = new DataTable();

                    sqlAdapter1.Fill(dataTable1); // Preenche o DataTable com os dados retornados da query

                    if (dataTable1.Rows.Count == 1)
                    {
                        //FormPrincipal principal = new FormPrincipal();
                        //this.Hide();
                        //principal.Show();
                        MessageBox.Show("Um usuario ja esta cadastrado com o mesmo email", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Conexao.Close();
                    }
                    else
                    {
                   
                        SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(queryAdiciona, Conexao);
                        sqlAdapter2.Fill(dataTable1);
                        
                        FormLogin formLogin = new FormLogin();
                        this.Hide();
                        formLogin.Show();

                        MessageBox.Show("Usuario: "+edtNome.Text+" foi cadastrado com sucesso! Faca login.", "Cadastro Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Conexao.Close();
                    }

                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        // Verifica se os objectos sao iguais
        private Boolean passwordIgual (Object a, Object b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
