using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyGame
{
    public partial class MenuRank : Form
    {
        private SoundControl soundControl;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        public MenuRank()
        {
            InitializeComponent();
            string Localdb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programação\SCRIPTS C#\MonkeyGameATTult\MonkeyGame (1)\MonkeyGame\BancodeDados\bdRanking.mdf"";Integrated Security=True";
            SqlConnection conexao = new SqlConnection(Localdb);

            string consulta = "SELECT * FROM Ranking, Usuaruis ORDER BY Pontos DESC;";

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(consulta, conexao);
                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    lb_id.Items.Add(leitor["Id"]);
                    lb_insta.Items.Add(leitor["Insta"]);
                    lb_pontos.Items.Add(leitor["Pontos"]);
                    lb_personagens.Items.Add(leitor["Personagem"]);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao acessar o banco");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void MenuRank_Load(object sender, EventArgs e)
        {
            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto

            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 18, FontStyle.Regular);

                // Atribua a fonte importada à sua Label
                lbl_personagens.Font = fonteImportada;
                lbl_id.Font = fonteImportada;
                lbl_instagram.Font = fonteImportada;
                lbl_pontuacao.Font = fonteImportada;

            }


            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            MenuJogo menurank = new MenuJogo();
            menurank.Show();
            this.Hide();
            SoundManager.PlayLooping();
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuExtras menuExtras = new MenuExtras();
            menuExtras.Show();
            this.Hide();
        }

        private void lbl_voltar_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_voltar.ForeColor = Color.White;
            lbl_voltar.Cursor = Cursors.Hand;
            pb_7.Visible = true;
            pb_8.Visible = true;
        }

        private void lbl_voltar_MouseLeave(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.White;
            lbl_voltar.Cursor = Cursors.Hand;
            pb_7.Visible = false;
            pb_8.Visible = false;
        }
    }
}
