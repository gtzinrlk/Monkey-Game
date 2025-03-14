using Jogo_do_macaco___feira;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MonkeyGame
{

    public partial class MenuJogo : Form
    {
        private SoundControl soundControl;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        int pontos;
        int musica;
        int start = 0;
        int quite = 0;
        public MenuJogo()
        {
            InitializeComponent();

            this.Opacity = 0; // Define a opacidade inicial como 0 (totalmente transparente)
            if (musica == 0)
            soundControl = new SoundControl("EffecrThunder.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            musica++;

        }

        private void MenuJogo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            // Inicia uma thread para a animação de brilho

            if (start == 0)
            {
                Thread animationThread = new Thread(StartAnimation);
                animationThread.Start();
                start++;
            }

            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto

            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 32, FontStyle.Regular);

                // Atribua a fonte importada à sua Label
                lbl_comecar.Font = fonteImportada;
                lbl_extras.Font = fonteImportada;
                lbl_sair.Font = fonteImportada;
            }
        }

        private void StartAnimation()
        {

                for (double opacity = 0; opacity <= 1; opacity += 0.1)
                {
                    // Atualiza a opacidade do formulário
                    this.Invoke((Action)(() =>
                    {
                        this.Opacity = opacity;
                    }));

                    // Aguarda um curto período para suavizar a animação
                    Thread.Sleep(50);
                }

        }


        private void lbl_comecar_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuPersonagem menuPersonagem = new MenuPersonagem();
            menuPersonagem.Show();
            this.Hide();
        }

        private void lbl_comecar_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_comecar.ForeColor = Color.WhiteSmoke;
            lbl_comecar.Cursor = Cursors.Hand;
            pb_1.Visible = true;
            pb_2.Visible = true;
        }

        private void lbl_comecar_MouseLeave(object sender, EventArgs e)
        {
            lbl_comecar.ForeColor = Color.White;
            lbl_comecar.Cursor = Cursors.Hand;
            pb_1.Visible = false;
            pb_2.Visible = false;
        }

        private void lbl_regras_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuAdicionarPontos menuAdicionarPontos = new MenuAdicionarPontos();
            menuAdicionarPontos.Show();
            this.Hide();
        }

        private void lbl_extra_Click(object sender, EventArgs e)
        {
            soundControl = new SoundControl("CharacterSelect.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            MenuExtras extras = new MenuExtras();
            extras.Show();
            this.Hide();
        }

        private void lbl_extra_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_extras.ForeColor = Color.White;
            lbl_extras.Cursor = Cursors.Hand;
            pb_3.Visible = true;
            pb_4.Visible = true;
        }

        private void lbl_extra_MouseLeave(object sender, EventArgs e)
        {
            lbl_extras.ForeColor = Color.White;
            lbl_extras.Cursor = Cursors.Hand;
            pb_3.Visible = false;
            pb_4.Visible = false;
        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            if (quite == 0)
                MessageBox.Show("Você realmente deseja sair do jogo?");
            if (quite != 0)
            {
                soundControl = new SoundControl("CharacterSelect.wav");
                soundControl.SetVolume(0.4f);
                soundControl.Play();
                Application.Exit();
            }

            quite++;
        }

        private void lbl_quit_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Cursor = Cursors.Hand;
            pb_5.Visible = true;
            pb_6.Visible = true;
        }

        private void lbl_quit_MouseLeave(object sender, EventArgs e)
        {
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Cursor = Cursors.Hand;
            pb_5.Visible = false;
            pb_6.Visible = false;
        }
    }
}


