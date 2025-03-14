using Jogo_do_macaco___feira;
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

namespace MonkeyGame
{
    public partial class MenuAdicionarPontos : Form
    {
        public int pontos;
        public string macacoganhador;

        public MenuAdicionarPontos()
        {
            InitializeComponent();

        }
        public MenuAdicionarPontos(int Pontos, string Macacoganhador)
        {
            pontos = Pontos;
            macacoganhador = Macacoganhador;
        }


        private void txt_instagram_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string caminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Silxvaaz\Desktop\MACACO\MonkeyGame\BancodeDados\bdRanking.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(caminho);
                conn.Open();

                //Adicionar pontuação/personagem no banco
                try
                {

                    string comando = "INSERT INTO Ranking(Insta, Pontos, Personagem) VALUES (@Insta, @pontos, @personagem)";
                    using (SqlCommand Comando = new SqlCommand(comando, conn))
                    {
                        Comando.Parameters.Add(new SqlParameter("@Insta", this.txt_instagram.Text));
                        Comando.Parameters.Add(new SqlParameter("@personagem", macacoganhador));
                        Comando.Parameters.AddWithValue("@pontos", pontos);
                        Comando.ExecuteNonQuery();

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você teve um erro de exceção com o banco de dados:" + ex.Message);

                }
                MenuJogo menuInicial = new MenuJogo();
                menuInicial.Show();
                this.Hide();

            }

        }

        private void MenuAdicionarPontos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }
    }
}
