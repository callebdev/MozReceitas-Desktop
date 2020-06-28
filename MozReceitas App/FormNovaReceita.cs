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
    public partial class FormNovaReceita : Form
    {

        // Referencia da Conexao
        SqlConnection Conexao = new SqlConnection(@"Data Source=CALLEB\SQLEXPRESS;Initial Catalog=MozReceitasApp;Integrated Security=True");
        Usuario usuarioLogado = Usuario.usuarioLogado;


        public FormNovaReceita()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {

            if (edtTitulo.Text.Length<1 || edtDescricao.Text.Length < 5)
            {
                MessageBox.Show("Campos incorrectos ou vazios!", "Erro ao publicar receita", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                Conexao.Open(); // Abre a conexao
                String email = usuarioLogado.getEmail();
                string query = "INSERT INTO Receita (titulo, descricao, autor) values ('" + edtTitulo.Text + "', '" + edtDescricao.Text + "', '" + email + "')";

                SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);

                DataTable dt = new DataTable();

                dp.Fill(dt); // Preenche o DataTable com os dados retornados da query

                this.Hide();
                Conexao.Close();
                MessageBox.Show("Receita publicada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            
        }
    }
}
