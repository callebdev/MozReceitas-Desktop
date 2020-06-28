using MozReceitas_App;
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
    public partial class FormPrincipal : Form
    {

        // Referencia da Conexao
        SqlConnection Conexao = new SqlConnection(@"Data Source=CALLEB\SQLEXPRESS;Initial Catalog=MozReceitasApp;Integrated Security=True");
        Usuario usuarioLogado = Usuario.usuarioLogado;

        public FormPrincipal()
        {
            InitializeComponent();
            usuarioLogado.setNome("VAZIO");
            lblEmail.Text = usuarioLogado.getEmail();
        }

        private void btnNovaReceita_Click(object sender, EventArgs e)
        {
            FormNovaReceita formNovaReceita = new FormNovaReceita();
            formNovaReceita.Show();
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            FormNovaSenha formNovaSenha = new FormNovaSenha();
            formNovaSenha.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            // QUANDO INICIA O FORM
            Conexao.Open(); // Abre a conexao

            int t = lstTodasReceitas.Items.Count;

            for(int i = 0; i < t ; i++)
            {
                lstTodasReceitas.Items.RemoveAt(i);
            }


            String query = "SELECT titulo, descricao, autor from Receita;";

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                lstTodasReceitas.Items.Add("");
                lstTodasReceitas.Items.Add("TITULO: " + dataReader[0] + " - MODO DE PREPARACAO - " + dataReader["descricao"] + " - AUTOR - " + dataReader["autor"]);
            }

            Conexao.Close(); // Fecha a conexao

        }

        private void btnListarTodasReceitas_Click(object sender, EventArgs e)
        {

            Conexao.Open(); // Abre a conexao
            

            for (int i = 0; i < lstTodasReceitas.Items.Count; i++)
            {
                lstTodasReceitas.Items.RemoveAt(i);
            }

            String  query = "SELECT titulo, descricao, autor from Receita;";

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                lstTodasReceitas.Items.Add("");
                lstTodasReceitas.Items.Add("TITULO: "+ dataReader[0] + " - MODO DE PREPARACAO - " + dataReader["descricao"] + " - AUTOR - " + dataReader["autor"]);
                
            }

            Conexao.Close(); // Fecha a conexao

        }
    }
}
