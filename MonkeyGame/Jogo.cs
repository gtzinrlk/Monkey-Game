using MonkeyGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_macaco___feira
{
    public partial class Jogo : Form
    {
        private SoundControl soundControl;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        private Personagem jogador1;//Armazena o boneco selecionado e seus atributos
        private Personagem jogador2;
        public int Pontos = 2012;
        public string Macacoganhador = "Mafiosos";
        public string MacacoMapa;
        public string personagem1;
        public string personagem2;
        public bool VerificaçãoPlayer = false;
        public bool PlayerAction1 = false;
        public bool PlayerAction2 = false;

        private enum Acao
        {
            Atacar,
            Defender,
            Recarregar,
            Ultimate,
            nulo,
        }
        int vidaJogador1 = 100;
        int vidaJogador2 = 100;

        private Dictionary<int, Acao> acaoSelecionada = new Dictionary<int, Acao>();// Armazena a ações 
        int jogado = 1;//round 

        //Ações da ultimate do macaco mafioso
        bool ultimateFurtividade1;
        bool ultimateFurtividade2;
        int roundsAfk1;
        int roundsAfk2;
        int roundAtual;
        int segundosPassadosJ1 = 8;
        int segundosPassadosJ2 = 8;
        int terminoUlt1;
        int quantdeult = 0;
        Random rouboRdn = new Random();

        public Jogo(Personagem Jogador1, Personagem Jogador2, int pontos, string macacoganhador, string Mapa)
        {
            InitializeComponent();

            this.MacacoMapa = Mapa;
            this.BackgroundImage = Image.FromFile($@"..\..\..\Background's\Backgrounds_Macacos\{MacacoMapa}");

            //macacoSelect = "\Alucard\atk\alucard_atk_loop.gif"; EXEMPLO 

            //this.pb_player1 = Image.FromFile($@"..\..\..\Fotos\animação\Alucard\atk\{MacacoSelect}");
            //this.pb_player2 = Image.FromFile($@"..\..\..\Fotos\animação\{MacacoSelect}");

            tm_TempoDeEscolha.Start();

            jogador1 = Jogador1;
            jogador2 = Jogador2;

            lbl_nome1.Text = Jogador1.nome;
            lbl_nome2.Text = Jogador2.nome;

            MenuAdicionarPontos menuAdicionarPontos = new MenuAdicionarPontos(pontos, macacoganhador);
            pontos = Pontos;
            macacoganhador = Macacoganhador;
        }

        private void Jogo_KeyDown(object sender, KeyEventArgs e)
        {
            // Começar com nulo
            if (!acaoSelecionada.ContainsKey(1))
                acaoSelecionada[1] = Acao.nulo;

            if (!acaoSelecionada.ContainsKey(2))
                acaoSelecionada[2] = Acao.nulo;


            if (e.KeyCode == Keys.Z)
            {
                if (pgb_ultimate1.Value >= 1)
                {
                    acaoSelecionada[1] = Acao.Atacar;
                    lbl_Ready1.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Jogador 1 para atacar necessita de munição");
                }
            }
            else if (e.KeyCode == Keys.X)
            {
                acaoSelecionada[1] = Acao.Defender;
                lbl_Ready1.ForeColor = Color.Green;
            }
            else if (e.KeyCode == Keys.C)
            {
                if (pgb_ultimate1.Value < 6)
                {
                    acaoSelecionada[1] = Acao.Recarregar;
                    lbl_Ready1.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Jogador 1 você já possui munição maxima");
                }
            }
            else if (e.KeyCode == Keys.V)
            {
                if (pgb_ultimate1.Value >= jogador1.status.carga)
                {
                    acaoSelecionada[1] = Acao.Ultimate;
                    lbl_Ready1.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Jogador 1 não possui munição sufucienta para ultar");
                }
            }




            if (e.KeyCode == Keys.Up)
            {
                if (pgb_ultimate2.Value >= 1)
                {
                    acaoSelecionada[2] = Acao.Atacar;
                    lbl_ready2.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Jogador 2 para atacar necessita de munição");
                }
            }

            else if (e.KeyCode == Keys.Left)
            {
                acaoSelecionada[2] = Acao.Defender;
                lbl_ready2.ForeColor = Color.Green;
            }

            else if (e.KeyCode == Keys.Right)
            {
                if (pgb_ultimate2.Value < 6)
                {
                    if (ultimateFurtividade1 == true)
                    {
                        MessageBox.Show("Sua recarga foi desativada");
                    }

                    if (terminoUlt1 == jogado) ultimateFurtividade1 = false;
                    if (ultimateFurtividade1 == false)
                    {

                        pictureBox7.Visible = true;
                        //lbl_recarregar2.Visible = true;
                        acaoSelecionada[2] = Acao.Recarregar;
                        lbl_ready2.ForeColor = Color.Green;
                    }
                }
                else
                {
                    MessageBox.Show("Jogador 2 você já possui munição maxima");
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (pgb_ultimate2.Value >= jogador2.status.carga)
                {
                    acaoSelecionada[2] = Acao.Ultimate;
                    lbl_ready2.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Jogador 2 não possui munição sufucienta para ultar");
                }
            }


            if (e.KeyCode == Keys.Enter)
            {
                if (acaoSelecionada[1] != Acao.nulo && acaoSelecionada[2] != Acao.nulo)
                {//se as ações não forem nulas acontecera isto
                    if (vidaJogador1 <= 0)
                    {
                        MessageBox.Show("Jogador 2 foi o vencedor");
                    }
                    else if (vidaJogador2 <= 0)
                    {
                        MessageBox.Show("Jogador 1 foi o vencedor");
                    }
                    else
                    {
                        ExecutarAcaoSelecionada(acaoSelecionada[1], acaoSelecionada[2]);
                        acaoSelecionada.Clear();
                        lbl_Ready1.ForeColor = Color.Black;
                        lbl_ready2.ForeColor = Color.Black;
                        segundosPassadosJ1 = 8;
                        segundosPassadosJ2 = 8;
                    }

                }
                else
                {
                    MessageBox.Show("Algum dos jogadores não selecionou uma ação");
                }
            }
        }


        private void ExecutarAcaoSelecionada(Acao acaoJogador1, Acao acaoJogador2)
        {
            ProcessarAcaoJogador(jogador1, acaoJogador1, jogador2, acaoJogador2);//Executa de forma que ação começa por quem está jogando na rodada
            jogado++;
            lbl_Round.Text = "Round: " + jogado;
        }
        private void ProcessarAcaoJogador(Personagem jogador1, Acao acaoJogador1, Personagem jogador2, Acao acaoJogador2)
        {


            #region Tratamendo de ações do jogador1





            if (acaoJogador1 == Acao.Atacar)
            {

                if (acaoJogador2 == Acao.Ultimate)
                {


                    pgb_vidaJogador2.Value -= jogador1.status.dano;
                    vidaJogador2 -= jogador1.status.dano;
                    lbl_vidaJogador2.Text = vidaJogador2 + "/" + "100";

                    lbl_acoes.Text = "Jogador 1 atacou e causou: " + jogador1.status.dano + " e Jogador 2 usou a ultimate";
                    pgb_ultimate1.Value--;
                    pgb_ultimate2.Value -= jogador2.status.carga;

                    pb_player1.Image = Image.FromFile($@"..\..\..\Fotos\animação\{personagem1}\atk_p1.gif");
                    pb_player2.Image = Image.FromFile($@"..\..\..\Fotos\animação\{personagem2}\ult_p2.gif");

                    return;
                }
                if (acaoJogador2 == Acao.Atacar)
                {

                    pgb_vidaJogador1.Value -= jogador2.status.dano;
                    vidaJogador1 -= jogador2.status.dano;
                    lbl_vidaJogador1.Text = vidaJogador1 + "/" + "100";
                    pgb_ultimate2.Value--;
                    pgb_vidaJogador2.Value -= jogador1.status.dano;
                    vidaJogador2 -= jogador1.status.dano;
                    lbl_vidaJogador2.Text = vidaJogador2 + "/" + "100";
                    lbl_acoes.Text = "Jogador 1 atacou e Jogador 2 atacou danos respectivos foram " + jogador2.status.dano + " e " + jogador1.status.dano;
                    pgb_ultimate1.Value--;
                    return;
                }
                if (acaoJogador2 == Acao.Recarregar)
                {

                    pgb_vidaJogador2.Value -= jogador1.status.dano;
                    vidaJogador2 -= jogador1.status.dano;
                    lbl_vidaJogador2.Text = vidaJogador2 + "/" + "100";
                    pgb_ultimate2.Value++;
                    lbl_acoes.Text = "Jogador 1 Atacou e causou " + jogador1.status.dano + " e Jogador 2 recarregou";
                    pgb_ultimate1.Value--;
                    return;
                }


            }
            if (acaoJogador1 == Acao.Defender)
            {
                lbl_acoes.Text = "Jogador 1 defendeu";
                if (acaoJogador2 == Acao.Defender)
                {
                    lbl_acoes.Text = "Jogador 2 e 1 Defendeu";
                }
            }
            if (acaoJogador1 == Acao.Defender && acaoJogador2 == Acao.Atacar)
            {

                int danoReduzido = jogador2.status.dano - (jogador1.status.defesa / 2);
                vidaJogador1 -= danoReduzido;
                //Dano Efetivo = Dano do Atacante - (Defesa do Defensor / 2)

                pgb_vidaJogador1.Value -= danoReduzido;
                lbl_vidaJogador1.Text = vidaJogador1 + "/" + "100";
                pgb_ultimate2.Value--;
                lbl_acoes.Text = "Jogador 1 defende por partes o dano do jogador 2 e recebeu de dano: " + danoReduzido;
            }

            //try por recarga infinita
            if (acaoJogador1 == Acao.Recarregar)
            {
                if (pgb_ultimate1.Value < 6)
                {

                    lbl_acoes.Text = "Jogador 1 recarregou";
                    if (acaoJogador2 == Acao.Recarregar)
                    {
                        lbl_acoes.Text = "Jogador 1 e 2 recarregaram";
                        pgb_ultimate1.Value += 1;
                    }
                    if (acaoJogador2 == Acao.Defender)
                    {
                        lbl_acoes.Text = "Jogador 1 recarregou e Jogador 2 defendeu";
                        pgb_ultimate1.Value += 1;
                    }
                    if (acaoJogador2 == Acao.Ultimate)
                    {
                        lbl_acoes.Text = "Jogador 1 recarregou e Jogador 2 usou a ultimate";
                        pgb_ultimate1.Value += 1;
                    }
                }
            }
            //ultimates
            if (acaoJogador1 == Acao.Ultimate)
            {
                if (pgb_ultimate1.Value >= jogador1.status.carga)
                {
                    //lutador
                    if (jogador1.status.HabilidadeEspecial == "Fortalecimento")
                    {
                        double randomValue = new Random().NextDouble();

                        double chanceDeAumento = 0.25;

                        if (randomValue <= chanceDeAumento)
                        {
                            int AumentoAtaque1 = 10;
                            jogador1.status.dano += AumentoAtaque1;
                        }
                        else
                        {
                            int AnulacaodeDefesa = 15;
                            int AumentoAtaque2 = 15;
                            jogador1.status.dano += AumentoAtaque2;
                            jogador1.status.defesa -= AnulacaodeDefesa;

                        }

                        pgb_ultimate1.Value -= jogador1.status.carga;
                    }
                    // alucard / mafioso
                    if (jogador1.status.HabilidadeEspecial == "Pague a Divida")
                    {
                        if (pgb_ultimate1.Value >= jogador1.status.carga)
                        {

                            roundsAfk1 = rouboRdn.Next(1, 3);
                            ultimateFurtividade1 = true;

                            roundAtual = jogado;
                            terminoUlt1 = roundAtual + roundsAfk1;
                            pictureBox7.Visible = false;
                            //lbl_recarregar2.Visible = false;
                            pgb_ultimate1.Value -= jogador1.status.carga;
                        }
                    }


                    // Guerreiro
                    if (jogador1.status.HabilidadeEspecial == "Espirito do guerreiro")
                    {
                        double randomValue = new Random().NextDouble();

                        double chanceDeAumento = 0.25;
                        pgb_ultimate1.Value -= jogador1.status.carga;
                        if (randomValue <= chanceDeAumento)
                        {
                            int aumentoDefesa = 10;
                            jogador1.status.defesa += aumentoDefesa;
                        }
                        else
                        {
                            int aumentoAtaque = 20;
                            jogador1.status.dano += aumentoAtaque;

                        }
                    }
                    // Vergil
                    if (quantdeult != 0)
                    {
                        if (jogador1.status.HabilidadeEspecial == "Malevolencia")
                        {
                            int corte = 50;
                            pgb_vidaJogador2.Value -= corte;

                            pictureBox4.Visible = false;
                            //lbl_ultimate1.Visible = false;


                            pgb_ultimate1.Value -= jogador1.status.carga;
                        }
                    }
                    // Dio
                    if (jogador1.status.HabilidadeEspecial == "Parar o Tempo")
                    {
                        segundosPassadosJ1 = 0;

                        if (segundosPassadosJ2 == 8)
                        {
                            segundosPassadosJ2 /= 2;
                        }

                    }
                }
            }
            #endregion







            #region Tratamendo de ações do jogador2
            if (acaoJogador2 == Acao.Atacar)
            {
                if (acaoJogador1 == Acao.Ultimate)
                {
                    if (vidaJogador2 - jogador1.status.dano > 0)
                    {
                        pgb_vidaJogador1.Value -= jogador2.status.dano;
                        vidaJogador1 -= jogador2.status.dano;
                        lbl_vidaJogador1.Text = vidaJogador1 + "/" + "100";
                        lbl_acoes.Text = "Jogador 1 atacou e causou: " + jogador2.status.dano + " e Jogador 2 usou a ultimate";
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 venceu");
                    }
                }
                if (acaoJogador1 == Acao.Atacar)
                {
                    pgb_vidaJogador1.Value -= jogador2.status.dano;
                    vidaJogador1 -= jogador2.status.dano;
                    lbl_vidaJogador1.Text = vidaJogador1 + "/" + "100";
                    pgb_ultimate1.Value--;
                    pgb_vidaJogador2.Value -= jogador1.status.dano;
                    vidaJogador2 -= jogador1.status.dano;
                    lbl_vidaJogador2.Text = vidaJogador2 + "/" + "100";
                    lbl_acoes.Text = "Jogador 1 atacou e Jogador 2 atacou danos respectivos foram " + jogador2.status.dano + " e " + jogador1.status.dano;
                }
                if (acaoJogador1 == Acao.Recarregar)
                {
                    pgb_vidaJogador1.Value -= jogador2.status.dano;
                    vidaJogador1 -= jogador2.status.dano;
                    lbl_vidaJogador1.Text = vidaJogador1 + "/" + "100";
                    pgb_ultimate1.Value++;
                    lbl_acoes.Text = "Jogador 2 Atacou e causou " + jogador2.status.dano + " e Jogador 1 recarregou";
                }
                pgb_ultimate2.Value--;
            }
            if (acaoJogador2 == Acao.Defender)
            {
                lbl_acoes.Text = "Jogador 2 defendeu";
                if (acaoJogador1 == Acao.Defender)
                {
                    lbl_acoes.Text = "Jogador 2 e 1 Defendeu";
                }
                if (acaoJogador1 == Acao.Recarregar)
                {
                    lbl_acoes.Text = "Jogador 2 defendeu e Jogador 1 recarregou";
                }
            }
            if (acaoJogador2 == Acao.Defender && acaoJogador1 == Acao.Atacar)
            {
                if (vidaJogador2 > 0)
                {
                    int danoReduzido = jogador1.status.dano - (jogador2.status.defesa / 2);
                    vidaJogador2 -= danoReduzido;
                    //Dano Efetivo = Dano do Atacante - (Defesa do Defensor / 2)

                    pgb_vidaJogador2.Value -= danoReduzido;
                    lbl_vidaJogador2.Text = vidaJogador2 + "/" + "100";
                    pgb_ultimate1.Value--;
                    lbl_acoes.Text = "Jogador 2 defendeu por partes o ataque do jogador 1 e recebeu " + danoReduzido + " de dano";
                }
                else
                {
                    pgb_vidaJogador1.Value = 0;
                    lbl_vidaJogador2.Text = 0 + "/" + "100";
                    MessageBox.Show("Jogador 1 venceu!!!");
                }
            }
            if (acaoJogador2 == Acao.Recarregar)
            {
                if (pgb_ultimate2.Value < 6)
                    pgb_ultimate2.Value += 1;

                lbl_acoes.Text = "Jogador 2 recarregou";
                if (acaoJogador1 == Acao.Recarregar)
                {
                    lbl_acoes.Text = "Jogador 2 e 1 recarregaram";
                }
                if (acaoJogador1 == Acao.Defender)
                {
                    lbl_acoes.Text = "Jogador 2 recarregou e Jogador 1 defendeu";
                }
                if (acaoJogador1 == Acao.Ultimate)
                {
                    lbl_acoes.Text = "Jogador 2 recarregou e Jogador 1 usou a ultimate";
                }
            }
            //ultimates
            if (acaoJogador2 == Acao.Ultimate)
            {
                if (pgb_ultimate2.Value >= jogador2.status.carga)
                {
                    if (jogador2.status.HabilidadeEspecial == "Fortalecimento")
                    {
                        double randomValue = new Random().NextDouble();

                        double chanceDeAumento = 0.25;
                        pgb_ultimate2.Value -= jogador2.status.carga;
                        if (randomValue <= chanceDeAumento)
                        {
                            int AumentoAtaque1 = 10;
                            jogador2.status.dano += AumentoAtaque1;
                        }
                        else
                        {
                            int AnulacaodeDefesa = 15;
                            int AumentoAtaque2 = 15;
                            jogador2.status.dano += AumentoAtaque2;
                            jogador2.status.defesa -= AnulacaodeDefesa;

                        }
                        MessageBox.Show(jogador2.status.dano.ToString() + " " + jogador2.status.defesa);

                    }
                    if (jogador2.status.HabilidadeEspecial == "Pagar a Divida")
                    {
                        if (pgb_ultimate2.Value >= jogador2.status.carga)
                        {

                            roundsAfk1 = rouboRdn.Next(1, 3);
                            ultimateFurtividade2 = true;

                            roundAtual = jogado;
                            terminoUlt1 = roundAtual + roundsAfk1;
                            pictureBox3.Visible = false;
                            //lbl_recarregar1.Visible = false;
                            pgb_ultimate2.Value -= jogador1.status.carga;
                        }

                    }
                    if (jogador2.status.HabilidadeEspecial == "Espirito do guerreiro")
                    {
                        double randomValue = new Random().NextDouble();

                        double cancheDeAumento = 0.25;

                        if (randomValue <= cancheDeAumento)
                        {
                            int aumentoDefesa = 10;
                            jogador2.status.defesa += aumentoDefesa;
                        }
                        else
                        {
                            int aumentoAtaque = 20;
                            jogador2.status.dano += aumentoAtaque;

                        }
                    }
                    if (quantdeult != 0)
                        if (jogador2.status.HabilidadeEspecial == "Malevolencia")
                        {
                            int corte = 50;
                            pgb_vidaJogador1.Value -= corte;

                            pictureBox8.Visible = false;
                            //lbl_ultimate2.Visible = false;

                            pgb_ultimate2.Value -= jogador2.status.carga;
                        }
                    if (jogador2.status.HabilidadeEspecial == "Parar o Tempo")
                    {
                        segundosPassadosJ2 = 0;

                        if (segundosPassadosJ1 == 8)
                        {
                            segundosPassadosJ1 /= 2;
                        }
                        pgb_ultimate2.Value -= jogador2.status.carga;
                    }
                }
            }
            #endregion


        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Jogo_Load_1(object sender, EventArgs e)
        {
            soundControl = new SoundControl("SoundBattle.wav");
            soundControl.SetVolume(0.55f);
            //soundControl.Play();

            #region Tratamendo de Personagem
            // Verificação player1
            string monkey1 = jogador1.nome;

            if (monkey1 == "Dio")
            {
                pb_player1.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\idle_p1.gif");
                pictureBox1.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\atk_p1.gif");
                pictureBox3.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\recarga_p1.gif");
                pictureBox2.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\defesa_p1.gif");
                pictureBox4.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\ult_p1.gif");
                personagem1 = "dio";
            }
            if (monkey1 == "Alucard")
            {
                pb_player1.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\idle_p1.gif");
                pictureBox1.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\atk_p1.gif");
                pictureBox3.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\defesa_p1.gif");
                pictureBox2.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\recarga_p1.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\ult.gif");
                personagem1 = "alucard";
            }
            if (monkey1 == "Guerreiro")
            {
                pb_player1.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\idle_p1.gif");
                pictureBox1.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\atk_p1.gif");
                pictureBox3.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\defesa_p1.gif");
                pictureBox2.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\recarga_p1.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\ult_p1.gif");
                personagem1 = "guerreiro";
            }
            if (monkey1 == "Lutador")
            {
                //pb_player1.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\idle_p1.gif");
                pictureBox1.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\atk_p1.gif");
                pictureBox3.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\defesa_p1.gif");
                //]pictureBox2.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\recarga_p1.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\ult_p1.gif");
                personagem1 = "lutador";
            }
            if (monkey1 == "Vergil")
            {
                pb_player1.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\idle_p1.gif");
                pictureBox1.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\atk_p1.gif");
                pictureBox3.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\defesa_p1.gif");
                pictureBox2.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\recarga_p1.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\ult_p1.gif");
                personagem1 = "vergil";
            }

            // Verificação player2
            string monkey2 = jogador2.nome;

            if (monkey2 == "Dio")
            {
                pb_player2.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\idle_p2.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\atk_p2.gif");
                pictureBox6.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\recarga_p2.gif");
                pictureBox7.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\defesa_p2.gif");
                pictureBox8.Image = Image.FromFile(@"..\..\..\Fotos\animação\dio\ult_p2.gif");
                personagem2 = "dio";
            }
            if (monkey2 == "Alucard")
            {
                pb_player2.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\idle_p2.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\atk_p2.gif");
                pictureBox6.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\defesa_p2.gif");
                pictureBox7.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\recarga_p2.gif");
                pictureBox8.Image = Image.FromFile(@"..\..\..\Fotos\animação\alucard\ult.gif");
                personagem2 = "alucard";
            }
            if (monkey2 == "Guerreiro")
            {
                pb_player2.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\idle_p2.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\atk_p2.gif");
                pictureBox6.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\defesa_p2.gif");
                pictureBox7.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\recarga_p2.gif");
                pictureBox8.Image = Image.FromFile(@"..\..\..\Fotos\animação\guerreiro\ult_p2.gif");
                personagem2 = "guerreiro";
            }
            if (monkey2 == "Lutador")
            {
                //pb_player2.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\idle_p2.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\atk_p2.gif");
                pictureBox6.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\defesa_p2.gif");
                //pictureBox7.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\recarga_p2.gif");
                pictureBox8.Image = Image.FromFile(@"..\..\..\Fotos\animação\lutador\ult_p2.gif");
                personagem2 = "gutador";
            }
            if (monkey2 == "Vergil")
            {
                pb_player2.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\idle_p2.gif");
                pictureBox5.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\atk_p2.gif");
                pictureBox6.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\defesa_p2.gif");
                pictureBox7.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\recarga_p2.gif");
                pictureBox8.Image = Image.FromFile(@"..\..\..\Fotos\animação\vergil\ult_p2.gif");
                personagem2 = "vergil";
            }
            #endregion

            #region Trantamento de fonte e resolução
            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto
            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 20, FontStyle.Regular);
                Font fonteImportada2 = new Font(fontCollection.Families[0], 18, FontStyle.Regular);
                Font fonteImportada3 = new Font(fontCollection.Families[0], 22, FontStyle.Regular);

                lbl_acoes.Font = fonteImportada2;
                lbl_Ready1.Font = fonteImportada3;
                lbl_ready2.Font = fonteImportada3;
                lbl_tempo.Font = fonteImportada;
                lbl_tempo2.Font = fonteImportada;
                lbl_nome1.Font = fonteImportada3;
                lbl_nome2.Font = fonteImportada3;
                fontCollection.AddFontFile(@"..\..\..\Fonts\Moonhouse-yE5M.ttf"); // Substitua pelo caminho correto
            }

            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 30, FontStyle.Regular);

                lbl_Round.Font = fonteImportada;
            }
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            #endregion
        }

        private void tm_TempoDeEscolha_Tick(object sender, EventArgs e)
        {
            bool J1AcaoAusente = false;
            bool J2AcaoAusente = false;

            if (segundosPassadosJ1 == 4 && segundosPassadosJ2 == 4)
            {
                lbl_acoes.Text = "escolha uma ação";
            }

            if (segundosPassadosJ1 > 0 && segundosPassadosJ2 > 0)
            {
                segundosPassadosJ1--;
                segundosPassadosJ2--;
                lbl_tempo.Text = "Timer \n    " + segundosPassadosJ1;
                lbl_tempo2.Text = "Timer \n    " + segundosPassadosJ2;

                if (segundosPassadosJ1 == 0 && segundosPassadosJ2 == 0)
                {
                    try
                    {
                        if (acaoSelecionada[1] != Acao.nulo) segundosPassadosJ1 = 8;
                        if (acaoSelecionada[2] != Acao.nulo) segundosPassadosJ2 = 8;
                        ExecutarAcaoSelecionada(acaoSelecionada[1], acaoSelecionada[2]);
                        acaoSelecionada.Clear();
                        lbl_Ready1.ForeColor = Color.Black;
                        lbl_ready2.ForeColor = Color.Black;
                    }
                    catch
                    {
                        J1AcaoAusente = true;
                        J2AcaoAusente = true;


                        if (segundosPassadosJ1 == 0 && segundosPassadosJ2 == 0)
                        {

                            tm_TempoDeEscolha.Stop();
                            lbl_acoes.Text = "Uma jogada aleatoria acontecera";

                            Random random = new Random();
                            int JogadaAleatoria = random.Next(1, 4);
                            if (JogadaAleatoria == 1)
                            {
                                if (pgb_ultimate2.Value > 0)
                                {
                                    acaoSelecionada[1] = Acao.Atacar;
                                }
                                else
                                {
                                    JogadaAleatoria = random.Next(2, 4);
                                }
                            }
                            if (JogadaAleatoria == 2)
                            {
                                acaoSelecionada[1] = Acao.Defender;

                            }
                            if (JogadaAleatoria == 3)
                            {
                                acaoSelecionada[1] = Acao.Recarregar;

                            }
                            if (JogadaAleatoria == 4)
                            {
                                acaoSelecionada[1] = Acao.Ultimate;

                            }
                            if (J2AcaoAusente == true)
                            {
                                JogadaAleatoria = random.Next(1, 4);
                                if (JogadaAleatoria == 1)
                                {
                                    if (pgb_ultimate2.Value > 0)
                                    {
                                        acaoSelecionada[2] = Acao.Atacar;
                                    }
                                    else
                                    {
                                        JogadaAleatoria = random.Next(2, 4);
                                    }
                                }
                                if (JogadaAleatoria == 2)
                                {
                                    acaoSelecionada[2] = Acao.Defender;

                                }
                                if (JogadaAleatoria == 3)
                                {
                                    acaoSelecionada[2] = Acao.Recarregar;

                                }
                                if (JogadaAleatoria == 4)
                                {
                                    acaoSelecionada[2] = Acao.Ultimate;

                                }
                            }

                            segundosPassadosJ1 = 8;
                            segundosPassadosJ2 = 8;
                            ExecutarAcaoSelecionada(acaoSelecionada[1], acaoSelecionada[2]);
                            acaoSelecionada.Clear();
                            lbl_Ready1.ForeColor = Color.Black;
                            lbl_ready2.ForeColor = Color.Black;
                            tm_TempoDeEscolha.Start();
                        }
                    }
                }

            }
        }

        private void lbl_nome2_Click(object sender, EventArgs e)
        {

        }
    }
}
