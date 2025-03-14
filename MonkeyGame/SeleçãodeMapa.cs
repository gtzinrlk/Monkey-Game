using Jogo_do_macaco___feira;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MonkeyGame
{
    public partial class SeleçãodeMapa : Form
    {
        public SoundControl soundControl;
        int segundosPassados = 15;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        Personagem Jogador1_1 = null;
        Personagem Jogador2_2 = null;
        string macacoganhador2;
        string SelectMapa;
        int pontos1;
        int indexSelecionado = 0;
        public SeleçãodeMapa(Personagem Jogador1, Personagem Jogador2, int pontos, string macacoganhador, string SelectMapa)
        {
            InitializeComponent();

            this.Jogador1_1 = Jogador1;
            this.Jogador2_2 = Jogador2;
            this.pontos1 = pontos;
            this.macacoganhador2 = macacoganhador;

            TimerRandom.Start();
            pnl_mapa1.Click += Panel_Click;
            pnl_mapa2.Click += Panel_Click;
            pnl_mapa3.Click += Panel_Click;
            pnl_mapa4.Click += Panel_Click;
            pnl_mapa5.Click += Panel_Click;
            pnl_mapa6.Click += Panel_Click;
            pnl_mapa7.Click += Panel_Click;
            pnl_mapa8.Click += Panel_Click;
            /*pnl_mapa9.Click += Panel_Click;
            pnl_mapa10.Click += Panel_Click;
            pnl_mapa11.Click += Panel_Click;
            pnl_mapa12.Click += Panel_Click;*/

        }

        private void SeleçãodeMapa_Load(object sender, EventArgs e)
        {
            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto

            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 30, FontStyle.Regular);
                Font fonteImportada2 = new Font(fontCollection.Families[0], 20, FontStyle.Regular);
                Font fonteImportada3 = new Font(fontCollection.Families[0], 22, FontStyle.Regular);
                // Atribua a fonte importada à sua Label
                lbl_selecao.Font = fonteImportada3;
                lbl_temprandom.Font = fonteImportada2;
                lbl_mapaselecionado.Font = fonteImportada;
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {

            Panel clickedPanel = sender as Panel;
            indexSelecionado += 1;
            if (indexSelecionado == 1)
            {
                if (clickedPanel == pnl_mapa1)
                {
                    SelectMapa = "MacacoApostador.png";
                    string SelectMapaLocal = "Macaco Apostador";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }
                if (clickedPanel == pnl_mapa2)
                {
                    SelectMapa = "MacacoGangstar.png";
                    string SelectMapaLocal = "Macaco Gangstar";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }
                if (clickedPanel == pnl_mapa3)
                {
                    SelectMapa = "MacacoGuerreiro.png";
                    string SelectMapaLocal = "Macaco Guerreiro";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }
                if (clickedPanel == pnl_mapa4)
                {
                    SelectMapa = "MacacoSoldado.png";
                    string SelectMapaLocal = "Macaco Soldado";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }
                if (clickedPanel == pnl_mapa5)
                {
                    SelectMapa = "MacacoMafioso.png";
                    string SelectMapaLocal = "Macaco Mafioso";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }
                if (clickedPanel == pnl_mapa6)
                {
                    SelectMapa = "MacacoLutador.gif";
                    string SelectMapaLocal = "Macaco Lutador";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }
                if (clickedPanel == pnl_mapa7)
                {
                    SelectMapa = "MacacoBudha.gif";
                    string SelectMapaLocal = "Macaco Budha";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }
                if (clickedPanel == pnl_mapa8)
                {
                    SelectMapa = "MacacoPalhaço.gif";
                    string SelectMapaLocal = "Macaco Palhaço";
                    lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                    pnl_mapa1.Cursor = Cursors.Hand;
                }



                //soundControl.Stop(); 

                TimerRandom.Stop();
                Jogo jogo = new Jogo(Jogador1_1, Jogador2_2, pontos1, macacoganhador2, SelectMapa);
                jogo.Show();
                this.Hide();
                // Passar essas informações para o "Jogo"
            }
        }
        private void TimerRandom_Tick(object sender, EventArgs e)
        {
            bool JAcaoAusente = false;

            if (segundosPassados > 0)
            {
                segundosPassados--;
                lbl_temprandom.Text = "Tempo de Escolha \n                  " + segundosPassados;
            }
            else if (segundosPassados == 0)
            {
                lbl_temprandom.Visible = false;
                JAcaoAusente = true;
                if (segundosPassados == 0)
                {
                    TimerRandom.Stop();
                    Random random = new Random();
                    int MapaAleatorio = random.Next(1, 8);

                    if (MapaAleatorio == 1)
                    {
                        SelectMapa = "MacacoApostador.png";
                        string SelectMapaLocal = "Macaco Apostador";

                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }

                    if (MapaAleatorio == 2)
                    {
                        SelectMapa = "MacacoGangstar.png";
                        string SelectMapaLocal = "Macaco Gangstar";
                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }

                    if (MapaAleatorio == 3)
                    {
                        SelectMapa = "MacacoGuerreiro.png";
                        string SelectMapaLocal = "Macaco Guerreiro";
                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }
                    if (MapaAleatorio == 4)
                    {
                        SelectMapa = "MacacoSoldado.png";
                        string SelectMapaLocal = "Macaco Soldado";
                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }
                    if (MapaAleatorio == 5)
                    {
                        SelectMapa = "MacacoMafioso.png";
                        string SelectMapaLocal = "Macaco Mafioso";
                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }
                    if (MapaAleatorio == 6)
                    {
                        SelectMapa = "MacacoLutador.gif";
                        string SelectMapaLocal = "Macaco Lutador";
                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }
                    if (MapaAleatorio == 7)
                    {
                        SelectMapa = "MacacoBudha.gif";
                        string SelectMapaLocal = "Macaco Budha";
                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }
                    if (MapaAleatorio == 8)
                    {
                        SelectMapa = "MacacoPalhaço.gif";
                        string SelectMapaLocal = "Macaco Palhaço";
                        lbl_mapaselecionado.Text = $"Mapa selecinado: {SelectMapaLocal}";
                        lbl_mapaselecionado.Visible = true;
                    }

                    else if (SelectMapa != null)
                    {
                        Jogo jogo = new Jogo(Jogador1_1, Jogador2_2, pontos1, macacoganhador2, SelectMapa);
                        jogo.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void pnl_mapa1_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Apostador";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }

        private void pnl_mapa1_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }

        private void pnl_mapa2_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Gangstar";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }

        private void pnl_mapa2_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }

        private void pnl_mapa3_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Guerreiro";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }

        private void pnl_mapa3_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }

        private void pnl_mapa4_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Soldado";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }

        private void pnl_mapa4_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }
        private void pnl_mapa5_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Mafioso";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }

        private void pnl_mapa5_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }
        private void pnl_mapa6_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Lutador";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }

        private void pnl_mapa6_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }

        private void pnl_mapa7_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Budha";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }
        private void pnl_mapa7_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }
        private void pnl_mapa8_MouseHover(object sender, EventArgs e)
        {
            string SelectMapa = "Macaco Palhaço";
            lbl_mapaselecionado.Text = $"Está tentando selecionar o mapa: {SelectMapa}";
            lbl_mapaselecionado.Visible = true;
        }
        private void pnl_mapa8_MouseLeave(object sender, EventArgs e)
        {
            lbl_mapaselecionado.Text = "";
            lbl_mapaselecionado.Visible = false;
        }
    }
}
