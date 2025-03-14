using Jogo_do_macaco___feira;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyGame
{
    public partial class MenuPersonagem2 : Form
    {
        private SoundControl soundControl;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        string bonecoSelecionado;
        string bonecoSelecionado2;
        Personagem Jogador1 = null;
        Personagem Jogador2 = null;
        int pontos;
        int indexSelecionado = 0;

        public MenuPersonagem2()
        {
            InitializeComponent();

            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto

            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 16, FontStyle.Regular);
                Font fonteImportada2 = new Font(fontCollection.Families[0], 32, FontStyle.Regular);
                Font fonteImportada3 = new Font(fontCollection.Families[0], 15, FontStyle.Regular);
                // Atribua a fonte importada à sua Label
                lbl_nome.Font = fonteImportada3;
                lbl_lore.Font = fonteImportada2;
                lbl_voltar.Font = fonteImportada2;
                lbl_atk.Font = fonteImportada;
                lbl_def.Font = fonteImportada;
                lbl_carga.Font = fonteImportada;
                lbl_ult.Font = fonteImportada;
                gb_status.Font = fonteImportada;
            }

        }

        private void OnFrameChanged(object sender, EventArgs e)
        {

        }
        private void Personagens_Load(object sender, EventArgs e)
        {
            ImageAnimator.Animate(pb_demo.Image, OnFrameChanged);
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }


        private void pnl_lutador_MouseHover(object sender, EventArgs e)
        {

            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();

            PersonagensStatus StatusLutador = new PersonagensStatus(100, 15, 30, "Fortalecimento", 4);
            lbl_descPersonagem.Text = "Macaco Lutador, Veio de Los Macaques, \n" +
                "Localizado no Mundo dos Macacos,lá ele lutava Arte do \n" +
                "macaco e Monkey-jutsu profissionalmente contra todos \n" +
                "os macacos que tentavam desafiá-lo, porém após muitos\n" +
                "anos de luta, ele levou um soco tão forte, que foi\n" +
                "arremessado para outra dimensão,a do Mundo dos Macacos\n" +
                "e hoje ele luta incessavelmente para obter seu poder\n" +
                "máximo e voltar para sua cidade\n";
            lbl_lore.Visible = true;
            lbl_descPersonagem.Visible = true;
            lbl_descPersonagem.BackColor = Color.Transparent;
            lbl_descPersonagem.ForeColor = Color.White;
            lbl_nome.Text = "Lutador";
            pnl_lutador.BackColor = Color.DarkRed;
            lbl_atk.Text = "Ataque: " + StatusLutador.dano;
            lbl_def.Text = "Defesa: " + StatusLutador.defesa;
            lbl_carga.Text = "Carga: " + StatusLutador.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusLutador.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\atk_p1.gif");
        }

        private void pnl_lutador_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_lore.Visible = false;
            lbl_descPersonagem.Visible = false;
            pnl_lutador.BackColor = Color.Transparent;
            lbl_nome.Text = "";
            pb_demo.Image = null;
            lbl_atk.Text = "Ataque: ";
            lbl_def.Text = "Defesa: ";
            lbl_carga.Text = "Carga: ";
            lbl_ult.Text = "Ultimate: ";

        }

        private void pnl_mafioso_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();

            lbl_descPersonagem.Text = "Macaco Mafioso, Veio de uma zona pobre\n" +
                "do Mundo dos Macacos, com vários bares na sua cidade,\n" +
                "ele convivia muito com seu pai lá, ao passar dos tempos,\n" +
                "o mafioso ele viu os jogadores e donos de bixo nos bares\n" +
                "e quando virou um macaco adulto, decidiu virar bixeiro de\n" +
                "última hora, para ajudar nas rendas de sua árvore e ele era\n" +
                "tão destemido que depois de muita confiança e trabalho bem\n" +
                "feito ele conseguiu a confiança de todos e virou o chefe\n" +
                "da máfia no Mundo dos Macacos\n";
            lbl_lore.Visible = true;
            lbl_descPersonagem.Visible = true;
            pnl_alucard.BackColor = Color.DarkRed;
            PersonagensStatus StatusMafioso = new PersonagensStatus(100, 15, 20, "Furtividade", 3);
            lbl_nome.Text = "Alucard";
            lbl_atk.Text = "Ataque: " + StatusMafioso.dano;
            lbl_def.Text = "Defesa: " + StatusMafioso.defesa;
            lbl_carga.Text = "Carga: " + StatusMafioso.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusMafioso.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/alucard/idle_p1.gif");
            pb_demo.BackgroundImageLayout = ImageLayout.Stretch;
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_mafioso_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
            lbl_lore.Visible = false;
            pnl_alucard.BackColor = Color.Transparent;
            lbl_atk.Text = "Ataque: ";
            lbl_def.Text = "Defesa: ";
            lbl_carga.Text = "Carga: ";
            lbl_ult.Text = "Ultimate: ";
            lbl_nome.Text = "";
            pb_demo.Image = null;
        }

        private void pnl_guerreiro_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();

            lbl_descPersonagem.Text = "Macaco Guerreio, Veio de um continente isolado\n" +
                "do Mundo dos Macacos, lá ele passou a infância toda\n" +
                "com a influência de todos, a ser um guerreiro nato\n" +
                "para proteger sua nação, desde quando era um macaco\n" +
                "bebe, ele seguia os treinamentos de seu continente,\n" +
                "e isso perpetuou durante anos, até virar um macaco\n" +
                "adulto e desde então ele é virou o guerreiro mais\n" +
                "forte de todo o mundo\n";
            lbl_lore.Visible = true;
            lbl_descPersonagem.Visible = true;
            pnl_guerreiro.BackColor = Color.DarkRed;
            PersonagensStatus StatusGuerreiro = new PersonagensStatus(100, 25, 15, "Guerrilhiero", 4);
            lbl_nome.Text = "Guerreiro";
            lbl_atk.Text = "Ataque: " + StatusGuerreiro.dano;
            lbl_def.Text = "Defesa: " + StatusGuerreiro.defesa;
            lbl_carga.Text = "Carga: " + StatusGuerreiro.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusGuerreiro.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/guerreiro/idle_p1.gif");
            pb_demo.BackgroundImageLayout = ImageLayout.Stretch;
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_guerreiro_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
            lbl_lore.Visible = false;
            pnl_guerreiro.BackColor = Color.Transparent;
            lbl_nome.Text = "";
            lbl_atk.Text = "Ataque: ";
            lbl_def.Text = "Defesa: ";
            lbl_carga.Text = "Carga: ";
            lbl_ult.Text = "Ultimate: ";
            pb_demo.Image = null;
        }

        private void pnl_soldado_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();

            lbl_descPersonagem.Text = "Macaco Vergil, após alcançar o ápice do poder\n" +
                "e dominar seu universo, sente solidão e vazio. Uma visão\n" +
                "revela infinitos multiversos, e ele abre uma fenda no\n" +
                "espaço-tempo, causando uma catástrofe. Ele é arrebatado\n" +
                "para um mundo diferente, onde encontra uma versão\n" +
                "alternativa de si mesmo, desencadeando batalhas\n" +
                "multiversais no próprio Mundo do Macaco\n";
            lbl_descPersonagem.Visible = true;
            lbl_lore.Visible = true;
            pnl_vergil.BackColor = Color.DarkRed;
            PersonagensStatus StatusDevil = new PersonagensStatus(100, 20, 20, "Malevolencia", 5);
            lbl_nome.Text = "Vergil";
            lbl_atk.Text = "Ataque: " + StatusDevil.dano;
            lbl_def.Text = "Defesa: " + StatusDevil.defesa;
            lbl_carga.Text = "Carga: " + StatusDevil.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusDevil.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/vergil/idle_p1.gif");
            pb_demo.BackgroundImageLayout = ImageLayout.Stretch;
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_soldado_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
            lbl_lore.Visible = false;
            pnl_vergil.BackColor = Color.Transparent;
            lbl_nome.Text = "";
            lbl_atk.Text = "Ataque: ";
            lbl_def.Text = "Defesa: ";
            lbl_carga.Text = "Carga: ";
            lbl_ult.Text = "Ultimate: ";
            pb_demo.Image = null;
        }

        private void pnl_Apostador_MouseHover(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundCharacter.wav");
            soundControl.SetVolume(0.4f);
            soundControl.Play();

            lbl_descPersonagem.Text = "Macaco Dio, Tem um paradeiro anonimo, \nsó se sabe que ele tem algo chamado\n" +
                "de \"stand\" e dizem que é o mais forte que existe,porém,\n" +
                "não se enganem o \"DIO\" ele é muito poderoso\n" +
                "e perigoso que pretende causar a destruição \ncompleta do Mundo dos Macacos\n.";
            lbl_descPersonagem.Visible = true;
            lbl_lore.Visible = true;
            pnl_dio.BackColor = Color.DarkRed;
            PersonagensStatus StatusTimer = new PersonagensStatus(100, 20, 25, "Parar o tempo", 4);
            lbl_nome.Text = "Dio";
            lbl_atk.Text = "Ataque: " + StatusTimer.dano;
            lbl_def.Text = "Defesa: " + StatusTimer.defesa;
            lbl_carga.Text = "Carga: " + StatusTimer.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusTimer.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/dio/idle_p1.gif");
            pb_demo.BackgroundImageLayout = ImageLayout.Stretch;
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_Apostador_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
            lbl_lore.Visible = false;
            pnl_dio.BackColor = Color.Transparent;
            lbl_nome.Text = "";
            lbl_atk.Text = "Ataque: ";
            lbl_def.Text = "Defesa: ";
            lbl_carga.Text = "Carga: ";
            lbl_ult.Text = "Ultimate: ";
            pb_demo.Image = null;
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
            pb_1.Visible = true;
            pictureBox8.Visible = true;
        }

        private void lbl_voltar_MouseLeave(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.White;
            lbl_voltar.Cursor = Cursors.Hand;
            pb_1.Visible = false;
            pictureBox8.Visible = false;
        }
    }
}
