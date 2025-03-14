using Jogo_do_macaco___feira;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyGame
{
    public partial class MenuExtras : Form
    {
        private SoundControl soundControl;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        public MenuExtras()
        {
            InitializeComponent();
            soundControl = new SoundControl("FateofSixtyYears.wav");
            soundControl.SetVolume(0.2f);
        }

        private void Extras_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            // Associe o evento Click da Label a um manipulador de eventos.
            lbl_regras.Click += lbl_regras_Click;

            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto

            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 32, FontStyle.Regular);

                // Atribua a fonte importada à sua Label
                lbl_personagens.Font = fonteImportada;
                lbl_regras.Font = fonteImportada;
                lbl_creditos.Font = fonteImportada;
                lbl_voltar.Font = fonteImportada;

            }
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuJogo menuJogo = new MenuJogo();
            menuJogo.Show();
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

        private void lbl_creditos_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuCredito menuCredito = new MenuCredito();
            menuCredito.Show();
            this.Hide();
        }

        private void lbl_creditos_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_creditos.ForeColor = Color.White;
            lbl_creditos.Cursor = Cursors.Hand;
            pb_5.Visible = true;
            pb_6.Visible = true;
        }

        private void lbl_creditos_MouseLeave(object sender, EventArgs e)
        {
            lbl_creditos.ForeColor = Color.White;
            lbl_creditos.Cursor = Cursors.Hand;
            pb_5.Visible = false;
            pb_6.Visible = false;
        }

        private void lbl_regras_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://tavo311.github.io/macaco/regras.html",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o link: " + ex.Message);
            }


        }

        private void lbl_regras_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_regras.ForeColor = Color.White;
            lbl_regras.Cursor = Cursors.Hand;
            pb_3.Visible = true;
            pb_4.Visible = true;
        }

        private void lbl_regras_MouseLeave(object sender, EventArgs e)
        {
            lbl_regras.ForeColor = Color.White;
            lbl_regras.Cursor = Cursors.Hand;
            pb_3.Visible = false;
            pb_4.Visible = false;
        }

        private void lbl_personagens_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuPersonagem2 menuPersonagem2 = new MenuPersonagem2();
            menuPersonagem2.Show();
            this.Hide();

        }

        private void lbl_personagens_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_personagens.ForeColor = Color.White;
            lbl_personagens.Cursor = Cursors.Hand;
            pb_1.Visible = true;
            pb_2.Visible = true;
        }

        private void lbl_personagens_MouseLeave(object sender, EventArgs e)
        {
            lbl_personagens.ForeColor = Color.White;
            lbl_personagens.Cursor = Cursors.Hand;
            pb_1.Visible = false;
            pb_2.Visible = false;
        }

        private void lbl_ranking_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuRank menuRank = new MenuRank();
            menuRank.Show();
            this.Hide();
        }

        private void lbl_ranking_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_ranking.ForeColor = Color.White;
            lbl_ranking.Cursor = Cursors.Hand;
            pb_9.Visible = true;
            pb_10.Visible = true;
        }

        private void lbl_ranking_MouseLeave(object sender, EventArgs e)
        {
            lbl_ranking.ForeColor = Color.White;
            lbl_ranking.Cursor = Cursors.Hand;
            pb_9.Visible = false;
            pb_10.Visible = false;
        }
    }
}
