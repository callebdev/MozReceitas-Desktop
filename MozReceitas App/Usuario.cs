using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozReceitas_App
{
    class Usuario
    {

        private String nome;
        private String email;
        private String senha;

        public Usuario()
        {
        }

        public static Usuario usuarioLogado = new Usuario("VAZIO", "VAZIO","VAZIO");

        public Usuario(String email, String senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public Usuario(String nome, String email, String senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getEmail()
        {
            return this.email;
        }

        public String getSenha()
        {
            return this.senha;
        }
    }
}
