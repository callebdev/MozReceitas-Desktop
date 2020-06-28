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

    
    public partial class FormLogin : Form
    {
        // Referencia da Conexao
        SqlConnection Conexao = new SqlConnection(@"Data Source=CALLEB\SQLEXPRESS;Initial Catalog=MozReceitasApp;Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
            edtEmail.Select(); // Inicializa a aplicacao com o TextBox edtEmail pronto para receber a entrada do usuario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Botao ENTRAR pressionado
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            Conexao.Open(); // Abre a conexao

            string query = "SELECT * FROM Usuario WHERE email  = '" + edtEmail.Text + "' AND senha = '"+edtPassword.Text+"'";

            SqlDataAdapter dp = new  SqlDataAdapter(query, Conexao);

            DataTable dt = new DataTable();

            dp.Fill(dt); // Preenche o DataTable com os dados retornados da query

            if(dt.Rows.Count == 1)
            {
                Usuario.usuarioLogado.setEmail(edtEmail.Text);
                Usuario.usuarioLogado.setSenha(edtPassword.Text);
                FormPrincipal principal = new FormPrincipal();
                this.Hide();
                principal.Show();
                Conexao.Close();
            }
            else
            {
                MessageBox.Show("O usuario nao esta cadastrado, ou a senha esta incorrecta! Tente novamente ou crie outra conta", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conexao.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            this.Hide();
            formCadastro.Show();
        }
        
    }

}
