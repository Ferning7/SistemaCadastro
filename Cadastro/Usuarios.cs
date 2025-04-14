using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Usuarios
    {
        private int id;
        private string nome;
        private string email;
        private string senha;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        // Métodos
        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Método cadastrar usuário

        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);
                    string sqlInsert = "INSERT into usuarios (nome, email, senha) VALUES (@nome, @email, @senha)";

                    MySqlCommand comando = new MySqlCommand(sqlInsert, conexaoBanco);

                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário ->" + ex.Message);
                return false;
            }
        }
    }
}
