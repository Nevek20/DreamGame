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
using MySql.Data.MySqlClient;

namespace dream_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=bd_jogos; Uid=root; Pwd=;";
            string query = "INSERT INTO tb_games (Titulo, Avaliacao, Tamanho, Descricao, Valor, Desenvolvedor, Genero) VALUES (@Titulo, @Avaliacao, @Tamanho, @Descricao, @Valor, @Desenvolvedor, @Genero)";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();
                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmentros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@Titulo", textBoxTitulo.Text);
                        comando.Parameters.AddWithValue("@Avaliacao", maskedTextBoxAvaliacao.Text);
                        comando.Parameters.AddWithValue("@Tamanho", maskedTextBoxTamanho.Text);
                        comando.Parameters.AddWithValue("@Descricao", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Desenvolvedor", textBoxDesenvolvedor.Text);
                        comando.Parameters.AddWithValue("@Genero", textBoxGenero.Text);

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        textBoxTitulo.Text = "";
                        maskedTextBoxAvaliacao.Text = "";
                        maskedTextBoxTamanho.Text = "";
                        richTextBoxDescricao.Text = "";
                        maskedTextBoxValor.Text = "";
                        textBoxDesenvolvedor.Text = "";
                        textBoxGenero.Text = "";
                        textBoxTitulo.Focus();
                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
            maskedTextBoxAvaliacao.Text = "";
            maskedTextBoxTamanho.Text = "";
            richTextBoxDescricao.Text = "";
            maskedTextBoxValor.Text = "";
            textBoxDesenvolvedor.Text = "";
            textBoxGenero.Text = "";
            textBoxTitulo.Focus();
        }
    }
}
