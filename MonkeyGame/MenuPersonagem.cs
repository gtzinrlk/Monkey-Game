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
    public partial class MenuPersonagem : Form
    {
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        string bonecoSelecionado;
        string bonecoSelecionado2;
        string map;
        Personagem Jogador1 = null;
        Personagem Jogador2 = null;
        int pontos;
        int indexSelecionado = 0;

        public MenuPersonagem()
        {
            InitializeComponent();
            pnl_lutador.Click += Panel_Click;
            pnl_guerreiro.Click += Panel_Click;
            pnl_alucard.Click += Panel_Click;
            pnl_vergil.Click += Panel_Click;
            pnl_dio.Click += Panel_Click;

            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto

            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 22, FontStyle.Regular);
                Font fonteImportada2 = new Font(fontCollection.Families[0], 18, FontStyle.Regular);
                Font fonteImportada3 = new Font(fontCollection.Families[0], 20, FontStyle.Regular);
                // Atribua a fonte importada à sua Label
                lbl_nome.Font = fonteImportada3;
                lbl_player.Font = fonteImportada2;
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

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            indexSelecionado += 1;

            if (indexSelecionado == 0)
            {
                lbl_player.ForeColor = Color.Red;
                lbl_player.Text = "Player 1";
            }
            else
            {
                lbl_player.ForeColor = Color.Green;
                lbl_player.Text = "Player 2";
            }

            if (indexSelecionado == 1)
            {

                if (clickedPanel == pnl_lutador)
                {
                    PersonagensStatus StatusLutador = new PersonagensStatus(100, 15, 30, "Fortalecimento", 4);
                    Jogador1 = new Personagem("Lutador", StatusLutador);
                }
                if (clickedPanel == pnl_alucard)
                {
                    PersonagensStatus StatusMafioso = new PersonagensStatus(100, 15, 20, "Pague a Divida", 3);
                    Jogador1 = new Personagem("Alucard", StatusMafioso);

                }
                if (clickedPanel == pnl_guerreiro)
                {
                    PersonagensStatus StatusGuerreiro = new PersonagensStatus(100, 25, 15, "Espirito do guerreiro", 4);
                    Jogador1 = new Personagem("Guerreiro", StatusGuerreiro);
                }
                if (clickedPanel == pnl_vergil)
                {
                    PersonagensStatus StatusDevil = new PersonagensStatus(100, 20, 20, "Malevolencia", 6);
                    Jogador1 = new Personagem("Vergil", StatusDevil);
                }
                if (clickedPanel == pnl_dio)
                {
                    PersonagensStatus StatusDio = new PersonagensStatus(100, 30, 10, "Parar o Tempo", 8);
                    Jogador1 = new Personagem("Dio", StatusDio);
                }
            }
            if (indexSelecionado >= 2)
            {
                if (clickedPanel == pnl_lutador)
                {
                    PersonagensStatus StatusLutador = new PersonagensStatus(100, 15, 30, "Fortalecimento", 4);
                    Jogador2 = new Personagem("Lutador", StatusLutador);
                }
                if (clickedPanel == pnl_alucard)
                {
                    PersonagensStatus StatusMafioso = new PersonagensStatus(100, 15, 20, "Pague a Divida", 3);
                    Jogador2 = new Personagem("Alucard", StatusMafioso);

                }
                if (clickedPanel == pnl_guerreiro)
                {
                    PersonagensStatus StatusGuerreiro = new PersonagensStatus(100, 25, 15, "Espirito do guerreiro", 4);
                    Jogador2 = new Personagem("Guerreiro", StatusGuerreiro);
                }
                if (clickedPanel == pnl_vergil)
                {
                    PersonagensStatus StatusDevil = new PersonagensStatus(100, 20, 20, "Malevolencia", 6);
                    Jogador2 = new Personagem("Vergil", StatusDevil);
                }
                if (clickedPanel == pnl_dio)
                {
                    PersonagensStatus StatusDio = new PersonagensStatus(100, 30, 10, "Parar o Tempo", 8);
                    Jogador2 = new Personagem("Dio", StatusDio);
                }

                SeleçãodeMapa jogo = new SeleçãodeMapa(Jogador1, Jogador2, pontos, null, map);
                jogo.Show();
                this.Hide();
            }
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
            PersonagensStatus StatusLutador = new PersonagensStatus(100, 15, 30, "Fortalecimento", 4);

            lbl_descPersonagem.Text = "Macaco Lutador, Veio de Los Macaques, Localizado no Mundo dos \n" +
                "Macacos, lá ele lutava Arte do macaco e Monkey-jutsu profissionalmente contra todos\n" +
                "os macacos que tenhava desafia-lo, porém após muitos anos de luta,\n" +
                "ele levou um soco tão forte, que foi arremesado para outra dimensão,\n" +
                "a do 'Monkey Game' e hoje ele luta incassavelmente para obter seu poder\n" +
                "maximo e voltar para sua cidade";
            lbl_descPersonagem.Visible = false;
            lbl_descPersonagem.BackColor = Color.Transparent;
            lbl_descPersonagem.ForeColor = Color.White;
            lbl_nome.Text = "Lutador";
            if (indexSelecionado == 0) { pnl_lutador.BackColor = Color.DarkRed; }
            else { pnl_lutador.BackColor = Color.DarkGreen; }
            lbl_atk.Text = "Ataque: " + StatusLutador.dano;
            lbl_def.Text = "Defesa: " + StatusLutador.defesa;
            lbl_carga.Text = "Carga: " + StatusLutador.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusLutador.HabilidadeEspecial;
            //pb_demo.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\idle_p1.gif");
        }

        private void pnl_lutador_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
            pnl_lutador.BackColor = Color.Transparent;
            lbl_nome.Text = "";
            lbl_atk.Text = "Ataque: ";
            lbl_def.Text = "Defesa: ";
            lbl_carga.Text = "Carga: ";
            lbl_ult.Text = "Ultimate: ";
            pb_demo.Image = null;

        }

        private void pnl_mafioso_MouseHover(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "Macaco Alucard";
            lbl_descPersonagem.Visible = false;
            if (indexSelecionado == 0) { pnl_alucard.BackColor = Color.DarkRed; }
            else { pnl_alucard.BackColor = Color.DarkGreen; }
            PersonagensStatus StatusMafioso = new PersonagensStatus(100, 15, 20, "Atirador", 3);
            lbl_nome.Text = "Alucard";
            lbl_atk.Text = "Ataque: " + StatusMafioso.dano;
            lbl_def.Text = "Defesa: " + StatusMafioso.defesa;
            lbl_carga.Text = "Carga: " + StatusMafioso.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusMafioso.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/alucard/idle_p1.gif");
            pb_demo.BackgroundImageLayout = ImageLayout.Tile;
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_mafioso_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
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
            lbl_descPersonagem.Text = "Macaco Guerreiro";
            lbl_descPersonagem.Visible = false;
            if (indexSelecionado == 0) { pnl_guerreiro.BackColor = Color.DarkRed; }
            else { pnl_guerreiro.BackColor = Color.DarkGreen; }
            PersonagensStatus StatusGuerreiro = new PersonagensStatus(100, 25, 15, "Guerrilheiro", 4);
            lbl_nome.Text = "Guerreiro";
            lbl_atk.Text = "Ataque: " + StatusGuerreiro.dano;
            lbl_def.Text = "Defesa: " + StatusGuerreiro.defesa;
            lbl_carga.Text = "Carga: " + StatusGuerreiro.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusGuerreiro.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/guerreiro/idle_p1.gif");
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_guerreiro_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
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
            lbl_descPersonagem.Text = "Macaco Vergil";
            lbl_descPersonagem.Visible = false;
            if (indexSelecionado == 0) { pnl_vergil.BackColor = Color.DarkRed; }
            else { pnl_vergil.BackColor = Color.DarkGreen; }
            PersonagensStatus StatusDevil = new PersonagensStatus(100, 20, 20, "Malevolencia", 5);
            lbl_nome.Text = "Vergil";
            lbl_atk.Text = "Ataque: " + StatusDevil.dano;
            lbl_def.Text = "Defesa: " + StatusDevil.defesa;
            lbl_carga.Text = "Carga: " + StatusDevil.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusDevil.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/vergil/idle_p1.gif");
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_soldado_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
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
            lbl_descPersonagem.Text = "Macaco Dio";
            lbl_descPersonagem.Visible = false;
            if (indexSelecionado == 0) { pnl_dio.BackColor = Color.DarkRed; }
            else { pnl_dio.BackColor = Color.DarkGreen; }
            PersonagensStatus StatusTimer = new PersonagensStatus(100, 30, 10, "Stop Time", 8);
            lbl_nome.Text = "Dio";
            lbl_atk.Text = "Ataque: " + StatusTimer.dano;
            lbl_def.Text = "Defesa: " + StatusTimer.defesa;
            lbl_carga.Text = "Carga: " + StatusTimer.carga;
            lbl_ult.Text = "Ultimate: \n" + StatusTimer.HabilidadeEspecial;
            pb_demo.Image = Image.FromFile(@"../../../Fotos/animação/dio/idle_p1.gif");
            ImageAnimator.UpdateFrames();
            pb_demo.Refresh();
        }

        private void pnl_Apostador_MouseLeave(object sender, EventArgs e)
        {
            lbl_descPersonagem.Text = "";
            lbl_descPersonagem.Visible = false;
            pnl_dio.BackColor = Color.Transparent;
            lbl_nome.Text = "";
            lbl_atk.Text = "Ataque: ";
            lbl_def.Text = "Defesa: ";
            lbl_carga.Text = "Carga: ";
            lbl_ult.Text = "Ultimate: ";
            pb_demo.Image = null;
        }

    }
}
