namespace Jogo_do_macaco___feira
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            pgb_vidaJogador1 = new ProgressBar();
            pgb_vidaJogador2 = new ProgressBar();
            lbl_nome1 = new Label();
            lbl_nome2 = new Label();
            lbl_titleultimate1 = new Label();
            pgb_ultimate1 = new ProgressBar();
            pgb_ultimate2 = new ProgressBar();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Ready1 = new Label();
            lbl_ready2 = new Label();
            lbl_acoes = new Label();
            lbl_Round = new Label();
            tm_TempoDeEscolha = new System.Windows.Forms.Timer(components);
            lbl_tempo = new Label();
            lbl_tempo2 = new Label();
            lbl_pontos1 = new Label();
            lbl_pontos2 = new Label();
            lbl_pontosadd2 = new Label();
            lbl_pontosadd1 = new Label();
            lbl_vidaJogador1 = new Label();
            lbl_vidaJogador2 = new Label();
            pb_player1 = new PictureBox();
            pb_player2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            SuspendLayout();
            // 
            // pgb_vidaJogador1
            // 
            pgb_vidaJogador1.Anchor = AnchorStyles.None;
            pgb_vidaJogador1.BackColor = Color.Red;
            pgb_vidaJogador1.Location = new Point(108, 85);
            pgb_vidaJogador1.Margin = new Padding(4, 3, 4, 3);
            pgb_vidaJogador1.Name = "pgb_vidaJogador1";
            pgb_vidaJogador1.Size = new Size(335, 27);
            pgb_vidaJogador1.TabIndex = 0;
            pgb_vidaJogador1.Value = 100;
            // 
            // pgb_vidaJogador2
            // 
            pgb_vidaJogador2.Anchor = AnchorStyles.None;
            pgb_vidaJogador2.Location = new Point(1005, 85);
            pgb_vidaJogador2.Margin = new Padding(4, 3, 4, 3);
            pgb_vidaJogador2.Name = "pgb_vidaJogador2";
            pgb_vidaJogador2.Size = new Size(335, 27);
            pgb_vidaJogador2.TabIndex = 1;
            pgb_vidaJogador2.Tag = "";
            pgb_vidaJogador2.Value = 100;
            // 
            // lbl_nome1
            // 
            lbl_nome1.Anchor = AnchorStyles.None;
            lbl_nome1.AutoSize = true;
            lbl_nome1.BackColor = Color.Transparent;
            lbl_nome1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome1.ForeColor = Color.White;
            lbl_nome1.Location = new Point(228, 25);
            lbl_nome1.Margin = new Padding(2, 0, 2, 0);
            lbl_nome1.Name = "lbl_nome1";
            lbl_nome1.Size = new Size(89, 20);
            lbl_nome1.TabIndex = 5;
            lbl_nome1.Text = "Jogador 1";
            // 
            // lbl_nome2
            // 
            lbl_nome2.Anchor = AnchorStyles.None;
            lbl_nome2.AutoSize = true;
            lbl_nome2.BackColor = Color.Transparent;
            lbl_nome2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome2.ForeColor = Color.White;
            lbl_nome2.Location = new Point(1125, 25);
            lbl_nome2.Margin = new Padding(2, 0, 2, 0);
            lbl_nome2.Name = "lbl_nome2";
            lbl_nome2.Size = new Size(84, 20);
            lbl_nome2.TabIndex = 6;
            lbl_nome2.Text = "jogador 2";
            lbl_nome2.Click += lbl_nome2_Click;
            // 
            // lbl_titleultimate1
            // 
            lbl_titleultimate1.Anchor = AnchorStyles.None;
            lbl_titleultimate1.AutoSize = true;
            lbl_titleultimate1.BackColor = Color.Transparent;
            lbl_titleultimate1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titleultimate1.ForeColor = Color.White;
            lbl_titleultimate1.Location = new Point(-464, 1091);
            lbl_titleultimate1.Margin = new Padding(2, 0, 2, 0);
            lbl_titleultimate1.Name = "lbl_titleultimate1";
            lbl_titleultimate1.Size = new Size(67, 18);
            lbl_titleultimate1.TabIndex = 7;
            lbl_titleultimate1.Text = "ultimate";
            // 
            // pgb_ultimate1
            // 
            pgb_ultimate1.Anchor = AnchorStyles.None;
            pgb_ultimate1.Location = new Point(178, 720);
            pgb_ultimate1.Margin = new Padding(4, 3, 4, 3);
            pgb_ultimate1.Maximum = 5;
            pgb_ultimate1.Name = "pgb_ultimate1";
            pgb_ultimate1.Size = new Size(217, 27);
            pgb_ultimate1.TabIndex = 10;
            // 
            // pgb_ultimate2
            // 
            pgb_ultimate2.Anchor = AnchorStyles.None;
            pgb_ultimate2.BackColor = Color.Gray;
            pgb_ultimate2.Location = new Point(1054, 720);
            pgb_ultimate2.Margin = new Padding(4, 3, 4, 3);
            pgb_ultimate2.Maximum = 5;
            pgb_ultimate2.Name = "pgb_ultimate2";
            pgb_ultimate2.Size = new Size(217, 27);
            pgb_ultimate2.TabIndex = 11;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.ErrorImage = (Image)resources.GetObject("pictureBox8.ErrorImage");
            pictureBox8.Image = MonkeyGame.Properties.Resources.Keybind_Down;
            pictureBox8.InitialImage = (Image)resources.GetObject("pictureBox8.InitialImage");
            pictureBox8.Location = new Point(1283, 171);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(58, 58);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.ErrorImage = (Image)resources.GetObject("pictureBox7.ErrorImage");
            pictureBox7.Image = MonkeyGame.Properties.Resources.Keybind_Right;
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(1097, 171);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 58);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.ErrorImage = (Image)resources.GetObject("pictureBox6.ErrorImage");
            pictureBox6.Image = MonkeyGame.Properties.Resources.Keybind_Left;
            pictureBox6.InitialImage = (Image)resources.GetObject("pictureBox6.InitialImage");
            pictureBox6.Location = new Point(1191, 171);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 58);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.ErrorImage = (Image)resources.GetObject("pictureBox5.ErrorImage");
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(1005, 171);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = (Image)resources.GetObject("pictureBox4.ErrorImage");
            pictureBox4.Image = MonkeyGame.Properties.Resources.Keybind_V;
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(387, 171);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = MonkeyGame.Properties.Resources.Keybind_X;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(298, 171);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = MonkeyGame.Properties.Resources.Keybind_Z;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(110, 171);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lbl_Ready1
            // 
            lbl_Ready1.Anchor = AnchorStyles.None;
            lbl_Ready1.AutoSize = true;
            lbl_Ready1.BackColor = Color.Transparent;
            lbl_Ready1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ready1.ForeColor = Color.White;
            lbl_Ready1.Location = new Point(241, 264);
            lbl_Ready1.Name = "lbl_Ready1";
            lbl_Ready1.Size = new Size(70, 28);
            lbl_Ready1.TabIndex = 28;
            lbl_Ready1.Text = "Ready";
            // 
            // lbl_ready2
            // 
            lbl_ready2.Anchor = AnchorStyles.None;
            lbl_ready2.AutoSize = true;
            lbl_ready2.BackColor = Color.Transparent;
            lbl_ready2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ready2.ForeColor = Color.White;
            lbl_ready2.Location = new Point(1140, 264);
            lbl_ready2.Name = "lbl_ready2";
            lbl_ready2.Size = new Size(70, 28);
            lbl_ready2.TabIndex = 29;
            lbl_ready2.Text = "Ready";
            // 
            // lbl_acoes
            // 
            lbl_acoes.Anchor = AnchorStyles.None;
            lbl_acoes.AutoSize = true;
            lbl_acoes.BackColor = Color.Transparent;
            lbl_acoes.Font = new Font("Microsoft Sans Serif", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_acoes.ForeColor = Color.White;
            lbl_acoes.Location = new Point(409, 765);
            lbl_acoes.Name = "lbl_acoes";
            lbl_acoes.Size = new Size(407, 39);
            lbl_acoes.TabIndex = 30;
            lbl_acoes.Text = "                                       ";
            // 
            // lbl_Round
            // 
            lbl_Round.Anchor = AnchorStyles.None;
            lbl_Round.AutoSize = true;
            lbl_Round.BackColor = Color.Transparent;
            lbl_Round.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Round.ForeColor = Color.White;
            lbl_Round.Location = new Point(653, 9);
            lbl_Round.Name = "lbl_Round";
            lbl_Round.Size = new Size(168, 54);
            lbl_Round.TabIndex = 31;
            lbl_Round.Text = "Round 1";
            // 
            // tm_TempoDeEscolha
            // 
            tm_TempoDeEscolha.Interval = 1000;
            tm_TempoDeEscolha.Tick += tm_TempoDeEscolha_Tick;
            // 
            // lbl_tempo
            // 
            lbl_tempo.Anchor = AnchorStyles.None;
            lbl_tempo.AutoSize = true;
            lbl_tempo.BackColor = Color.Transparent;
            lbl_tempo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tempo.ForeColor = Color.White;
            lbl_tempo.Location = new Point(491, 79);
            lbl_tempo.Name = "lbl_tempo";
            lbl_tempo.Size = new Size(84, 37);
            lbl_tempo.TabIndex = 32;
            lbl_tempo.Text = "Timer";
            // 
            // lbl_tempo2
            // 
            lbl_tempo2.Anchor = AnchorStyles.None;
            lbl_tempo2.AutoSize = true;
            lbl_tempo2.BackColor = Color.Transparent;
            lbl_tempo2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tempo2.ForeColor = Color.White;
            lbl_tempo2.Location = new Point(859, 79);
            lbl_tempo2.Name = "lbl_tempo2";
            lbl_tempo2.Size = new Size(84, 37);
            lbl_tempo2.TabIndex = 33;
            lbl_tempo2.Text = "Timer";
            // 
            // lbl_pontos1
            // 
            lbl_pontos1.Anchor = AnchorStyles.None;
            lbl_pontos1.AutoSize = true;
            lbl_pontos1.BackColor = Color.Transparent;
            lbl_pontos1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pontos1.ForeColor = Color.White;
            lbl_pontos1.Location = new Point(114, 125);
            lbl_pontos1.Margin = new Padding(2, 0, 2, 0);
            lbl_pontos1.Name = "lbl_pontos1";
            lbl_pontos1.Size = new Size(64, 20);
            lbl_pontos1.TabIndex = 34;
            lbl_pontos1.Text = "pontos";
            // 
            // lbl_pontos2
            // 
            lbl_pontos2.Anchor = AnchorStyles.None;
            lbl_pontos2.AutoSize = true;
            lbl_pontos2.BackColor = Color.Transparent;
            lbl_pontos2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pontos2.ForeColor = Color.White;
            lbl_pontos2.Location = new Point(1265, 125);
            lbl_pontos2.Margin = new Padding(2, 0, 2, 0);
            lbl_pontos2.Name = "lbl_pontos2";
            lbl_pontos2.Size = new Size(65, 20);
            lbl_pontos2.TabIndex = 34;
            lbl_pontos2.Text = "Pontos";
            // 
            // lbl_pontosadd2
            // 
            lbl_pontosadd2.Anchor = AnchorStyles.None;
            lbl_pontosadd2.AutoSize = true;
            lbl_pontosadd2.BackColor = Color.Transparent;
            lbl_pontosadd2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pontosadd2.ForeColor = Color.White;
            lbl_pontosadd2.Location = new Point(1166, 125);
            lbl_pontosadd2.Margin = new Padding(2, 0, 2, 0);
            lbl_pontosadd2.Name = "lbl_pontosadd2";
            lbl_pontosadd2.Size = new Size(75, 20);
            lbl_pontosadd2.TabIndex = 34;
            lbl_pontosadd2.Text = "+Pontos";
            lbl_pontosadd2.Visible = false;
            // 
            // lbl_pontosadd1
            // 
            lbl_pontosadd1.Anchor = AnchorStyles.None;
            lbl_pontosadd1.AutoSize = true;
            lbl_pontosadd1.BackColor = Color.Transparent;
            lbl_pontosadd1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pontosadd1.ForeColor = Color.White;
            lbl_pontosadd1.Location = new Point(202, 125);
            lbl_pontosadd1.Margin = new Padding(2, 0, 2, 0);
            lbl_pontosadd1.Name = "lbl_pontosadd1";
            lbl_pontosadd1.Size = new Size(74, 20);
            lbl_pontosadd1.TabIndex = 34;
            lbl_pontosadd1.Text = "+pontos";
            lbl_pontosadd1.Visible = false;
            // 
            // lbl_vidaJogador1
            // 
            lbl_vidaJogador1.AutoSize = true;
            lbl_vidaJogador1.Location = new Point(241, 785);
            lbl_vidaJogador1.Name = "lbl_vidaJogador1";
            lbl_vidaJogador1.Size = new Size(95, 15);
            lbl_vidaJogador1.TabIndex = 35;
            lbl_vidaJogador1.Text = "lbl_vidaJogador1";
            lbl_vidaJogador1.Visible = false;
            // 
            // lbl_vidaJogador2
            // 
            lbl_vidaJogador2.AutoSize = true;
            lbl_vidaJogador2.Location = new Point(1127, 785);
            lbl_vidaJogador2.Name = "lbl_vidaJogador2";
            lbl_vidaJogador2.Size = new Size(95, 15);
            lbl_vidaJogador2.TabIndex = 35;
            lbl_vidaJogador2.Text = "lbl_vidaJogador1";
            lbl_vidaJogador2.Visible = false;
            // 
            // pb_player1
            // 
            pb_player1.Anchor = AnchorStyles.None;
            pb_player1.BackColor = Color.Transparent;
            pb_player1.BackgroundImageLayout = ImageLayout.Stretch;
            pb_player1.Location = new Point(108, 317);
            pb_player1.Name = "pb_player1";
            pb_player1.Size = new Size(452, 375);
            pb_player1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_player1.TabIndex = 36;
            pb_player1.TabStop = false;
            // 
            // pb_player2
            // 
            pb_player2.Anchor = AnchorStyles.None;
            pb_player2.BackColor = Color.Transparent;
            pb_player2.BackgroundImageLayout = ImageLayout.Stretch;
            pb_player2.Location = new Point(888, 326);
            pb_player2.Name = "pb_player2";
            pb_player2.Size = new Size(452, 375);
            pb_player2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_player2.TabIndex = 36;
            pb_player2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = MonkeyGame.Properties.Resources.Keybind_C;
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(202, 171);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.None;
            pictureBox9.BackColor = Color.White;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.ErrorImage = (Image)resources.GetObject("pictureBox9.ErrorImage");
            pictureBox9.Image = MonkeyGame.Properties.Resources.Keybind_Z;
            pictureBox9.InitialImage = (Image)resources.GetObject("pictureBox9.InitialImage");
            pictureBox9.Location = new Point(110, 209);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(20, 20);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 12;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.None;
            pictureBox10.BackColor = Color.White;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.ErrorImage = (Image)resources.GetObject("pictureBox10.ErrorImage");
            pictureBox10.Image = MonkeyGame.Properties.Resources.Keybind_C;
            pictureBox10.InitialImage = (Image)resources.GetObject("pictureBox10.InitialImage");
            pictureBox10.Location = new Point(202, 209);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(20, 20);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 12;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.None;
            pictureBox11.BackColor = Color.White;
            pictureBox11.ErrorImage = (Image)resources.GetObject("pictureBox11.ErrorImage");
            pictureBox11.Image = MonkeyGame.Properties.Resources.Keybind_X;
            pictureBox11.InitialImage = (Image)resources.GetObject("pictureBox11.InitialImage");
            pictureBox11.Location = new Point(297, 209);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(20, 20);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 14;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Anchor = AnchorStyles.None;
            pictureBox12.BackColor = Color.White;
            pictureBox12.ErrorImage = (Image)resources.GetObject("pictureBox12.ErrorImage");
            pictureBox12.Image = MonkeyGame.Properties.Resources.Keybind_V;
            pictureBox12.InitialImage = (Image)resources.GetObject("pictureBox12.InitialImage");
            pictureBox12.Location = new Point(387, 209);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(20, 20);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 19;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Anchor = AnchorStyles.None;
            pictureBox13.BackColor = Color.White;
            pictureBox13.ErrorImage = (Image)resources.GetObject("pictureBox13.ErrorImage");
            pictureBox13.Image = MonkeyGame.Properties.Resources.Keybind_Up;
            pictureBox13.InitialImage = (Image)resources.GetObject("pictureBox13.InitialImage");
            pictureBox13.Location = new Point(1005, 209);
            pictureBox13.Margin = new Padding(2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(20, 20);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 24;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Anchor = AnchorStyles.None;
            pictureBox14.BackColor = Color.White;
            pictureBox14.ErrorImage = (Image)resources.GetObject("pictureBox14.ErrorImage");
            pictureBox14.Image = MonkeyGame.Properties.Resources.Keybind_Right;
            pictureBox14.InitialImage = (Image)resources.GetObject("pictureBox14.InitialImage");
            pictureBox14.Location = new Point(1097, 209);
            pictureBox14.Margin = new Padding(2);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(20, 20);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 26;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox7_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.None;
            pictureBox15.BackColor = Color.White;
            pictureBox15.ErrorImage = (Image)resources.GetObject("pictureBox15.ErrorImage");
            pictureBox15.Image = MonkeyGame.Properties.Resources.Keybind_Left;
            pictureBox15.InitialImage = (Image)resources.GetObject("pictureBox15.InitialImage");
            pictureBox15.Location = new Point(1191, 209);
            pictureBox15.Margin = new Padding(2);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(20, 20);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 25;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Anchor = AnchorStyles.None;
            pictureBox16.BackColor = Color.White;
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox16.ErrorImage = (Image)resources.GetObject("pictureBox16.ErrorImage");
            pictureBox16.Image = MonkeyGame.Properties.Resources.Keybind_Down;
            pictureBox16.InitialImage = (Image)resources.GetObject("pictureBox16.InitialImage");
            pictureBox16.Location = new Point(1282, 209);
            pictureBox16.Margin = new Padding(2);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(20, 20);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 27;
            pictureBox16.TabStop = false;
            // 
            // Jogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1460, 920);
            Controls.Add(pb_player2);
            Controls.Add(pb_player1);
            Controls.Add(lbl_vidaJogador2);
            Controls.Add(lbl_vidaJogador1);
            Controls.Add(lbl_pontosadd2);
            Controls.Add(lbl_pontos2);
            Controls.Add(lbl_pontosadd1);
            Controls.Add(lbl_pontos1);
            Controls.Add(lbl_tempo2);
            Controls.Add(lbl_tempo);
            Controls.Add(lbl_Round);
            Controls.Add(lbl_acoes);
            Controls.Add(lbl_ready2);
            Controls.Add(lbl_Ready1);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox1);
            Controls.Add(pgb_ultimate2);
            Controls.Add(pgb_ultimate1);
            Controls.Add(lbl_titleultimate1);
            Controls.Add(lbl_nome2);
            Controls.Add(lbl_nome1);
            Controls.Add(pgb_vidaJogador1);
            Controls.Add(pgb_vidaJogador2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Jogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monkey Game";
            Load += Jogo_Load_1;
            KeyDown += Jogo_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgb_vidaJogador1;
        private ProgressBar pgb_vidaJogador2;
        private Label lbl_nome1;
        private Label lbl_nome2;
        private Label lbl_titleultimate1;
        private ProgressBar pgb_ultimate1;
        private ProgressBar pgb_ultimate2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label lbl_Ready1;
        private Label lbl_ready2;
        private Label lbl_acoes;
        private Label lbl_Round;
        private System.Windows.Forms.Timer tm_TempoDeEscolha;
        private Label lbl_tempo;
        private Label lbl_tempo2;
        private Label lbl_pontos1;
        private Label lbl_pontos2;
        private Label lbl_pontosadd2;
        private Label lbl_pontosadd1;
        private Label lbl_vidaJogador1;
        private Label lbl_vidaJogador2;
        private PictureBox pb_player1;
        private PictureBox pb_player2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
    }
}