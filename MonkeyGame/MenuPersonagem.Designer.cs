namespace MonkeyGame
{
    partial class MenuPersonagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPersonagem));
            pb_demo = new PictureBox();
            lbl_nome = new Label();
            lbl_ult = new Label();
            lbl_carga = new Label();
            lbl_def = new Label();
            lbl_atk = new Label();
            pnl_alucard = new Panel();
            pnl_lutador = new Panel();
            pictureBox3 = new PictureBox();
            pnl_guerreiro = new Panel();
            gb_status = new GroupBox();
            pnl_vergil = new Panel();
            pictureBox11 = new PictureBox();
            pnl_6 = new Panel();
            lbl_descPersonagem = new Label();
            gb_macacos = new GroupBox();
            panel6 = new Panel();
            pictureBox7 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnl_dio = new Panel();
            lbl_player = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_demo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            gb_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            pnl_6.SuspendLayout();
            gb_macacos.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pb_demo
            // 
            pb_demo.Anchor = AnchorStyles.None;
            pb_demo.BackColor = Color.Transparent;
            pb_demo.BackgroundImageLayout = ImageLayout.Stretch;
            pb_demo.Location = new Point(724, 286);
            pb_demo.Name = "pb_demo";
            pb_demo.Size = new Size(262, 136);
            pb_demo.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_demo.TabIndex = 16;
            pb_demo.TabStop = false;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(80, 36);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(104, 38);
            lbl_nome.TabIndex = 4;
            lbl_nome.Text = "Nome";
            // 
            // lbl_ult
            // 
            lbl_ult.Anchor = AnchorStyles.None;
            lbl_ult.AutoSize = true;
            lbl_ult.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ult.Location = new Point(15, 173);
            lbl_ult.Name = "lbl_ult";
            lbl_ult.Size = new Size(93, 25);
            lbl_ult.TabIndex = 3;
            lbl_ult.Text = "Ultimate: ";
            // 
            // lbl_carga
            // 
            lbl_carga.Anchor = AnchorStyles.None;
            lbl_carga.AutoSize = true;
            lbl_carga.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_carga.Location = new Point(15, 141);
            lbl_carga.Name = "lbl_carga";
            lbl_carga.Size = new Size(77, 25);
            lbl_carga.TabIndex = 2;
            lbl_carga.Text = "Carga: ";
            // 
            // lbl_def
            // 
            lbl_def.Anchor = AnchorStyles.None;
            lbl_def.AutoSize = true;
            lbl_def.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_def.Location = new Point(15, 111);
            lbl_def.Name = "lbl_def";
            lbl_def.Size = new Size(85, 25);
            lbl_def.TabIndex = 1;
            lbl_def.Text = "Defesa: ";
            // 
            // lbl_atk
            // 
            lbl_atk.Anchor = AnchorStyles.None;
            lbl_atk.AutoSize = true;
            lbl_atk.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_atk.Location = new Point(15, 80);
            lbl_atk.Name = "lbl_atk";
            lbl_atk.Size = new Size(86, 25);
            lbl_atk.TabIndex = 0;
            lbl_atk.Text = "Ataque: ";
            // 
            // pnl_alucard
            // 
            pnl_alucard.Anchor = AnchorStyles.None;
            pnl_alucard.BackColor = Color.Transparent;
            pnl_alucard.BackgroundImage = (Image)resources.GetObject("pnl_alucard.BackgroundImage");
            pnl_alucard.BackgroundImageLayout = ImageLayout.Zoom;
            pnl_alucard.BorderStyle = BorderStyle.FixedSingle;
            pnl_alucard.Location = new Point(365, 78);
            pnl_alucard.Margin = new Padding(4, 3, 4, 3);
            pnl_alucard.Name = "pnl_alucard";
            pnl_alucard.Size = new Size(69, 69);
            pnl_alucard.TabIndex = 1;
            pnl_alucard.MouseLeave += pnl_mafioso_MouseLeave;
            pnl_alucard.MouseHover += pnl_mafioso_MouseHover;
            // 
            // pnl_lutador
            // 
            pnl_lutador.Anchor = AnchorStyles.None;
            pnl_lutador.BackColor = Color.Transparent;
            pnl_lutador.BackgroundImage = (Image)resources.GetObject("pnl_lutador.BackgroundImage");
            pnl_lutador.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_lutador.BorderStyle = BorderStyle.FixedSingle;
            pnl_lutador.Location = new Point(259, 78);
            pnl_lutador.Margin = new Padding(4, 3, 4, 3);
            pnl_lutador.Name = "pnl_lutador";
            pnl_lutador.Size = new Size(69, 69);
            pnl_lutador.TabIndex = 0;
            pnl_lutador.MouseLeave += pnl_lutador_MouseLeave;
            pnl_lutador.MouseHover += pnl_lutador_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(499, 71);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(641, 195);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pnl_guerreiro
            // 
            pnl_guerreiro.Anchor = AnchorStyles.None;
            pnl_guerreiro.BackColor = Color.Transparent;
            pnl_guerreiro.BackgroundImage = (Image)resources.GetObject("pnl_guerreiro.BackgroundImage");
            pnl_guerreiro.BackgroundImageLayout = ImageLayout.Zoom;
            pnl_guerreiro.BorderStyle = BorderStyle.FixedSingle;
            pnl_guerreiro.Location = new Point(38, 78);
            pnl_guerreiro.Margin = new Padding(4, 3, 4, 3);
            pnl_guerreiro.Name = "pnl_guerreiro";
            pnl_guerreiro.Size = new Size(69, 69);
            pnl_guerreiro.TabIndex = 2;
            pnl_guerreiro.MouseLeave += pnl_guerreiro_MouseLeave;
            pnl_guerreiro.MouseHover += pnl_guerreiro_MouseHover;
            // 
            // gb_status
            // 
            gb_status.Anchor = AnchorStyles.None;
            gb_status.BackColor = Color.Transparent;
            gb_status.Controls.Add(lbl_nome);
            gb_status.Controls.Add(lbl_ult);
            gb_status.Controls.Add(lbl_carga);
            gb_status.Controls.Add(lbl_def);
            gb_status.Controls.Add(lbl_atk);
            gb_status.Font = new Font("Microsoft Sans Serif", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            gb_status.ForeColor = Color.White;
            gb_status.Location = new Point(724, 428);
            gb_status.Name = "gb_status";
            gb_status.Size = new Size(262, 266);
            gb_status.TabIndex = 15;
            gb_status.TabStop = false;
            gb_status.Text = "STATUS";
            // 
            // pnl_vergil
            // 
            pnl_vergil.Anchor = AnchorStyles.None;
            pnl_vergil.BackColor = Color.Transparent;
            pnl_vergil.BackgroundImage = (Image)resources.GetObject("pnl_vergil.BackgroundImage");
            pnl_vergil.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_vergil.BorderStyle = BorderStyle.FixedSingle;
            pnl_vergil.Location = new Point(38, 180);
            pnl_vergil.Margin = new Padding(4, 3, 4, 3);
            pnl_vergil.Name = "pnl_vergil";
            pnl_vergil.Size = new Size(69, 69);
            pnl_vergil.TabIndex = 3;
            pnl_vergil.MouseLeave += pnl_soldado_MouseLeave;
            pnl_vergil.MouseHover += pnl_soldado_MouseHover;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.None;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.InitialImage = (Image)resources.GetObject("pictureBox11.InitialImage");
            pictureBox11.Location = new Point(-61, -10);
            pictureBox11.Margin = new Padding(4, 3, 4, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(58, 55);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 10;
            pictureBox11.TabStop = false;
            // 
            // pnl_6
            // 
            pnl_6.Anchor = AnchorStyles.None;
            pnl_6.BackColor = Color.White;
            pnl_6.BackgroundImage = Properties.Resources.Cadeado;
            pnl_6.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_6.BorderStyle = BorderStyle.FixedSingle;
            pnl_6.Controls.Add(pictureBox11);
            pnl_6.Location = new Point(151, 180);
            pnl_6.Margin = new Padding(4, 3, 4, 3);
            pnl_6.Name = "pnl_6";
            pnl_6.Size = new Size(69, 69);
            pnl_6.TabIndex = 8;
            // 
            // lbl_descPersonagem
            // 
            lbl_descPersonagem.Anchor = AnchorStyles.None;
            lbl_descPersonagem.AutoSize = true;
            lbl_descPersonagem.BorderStyle = BorderStyle.Fixed3D;
            lbl_descPersonagem.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_descPersonagem.Location = new Point(1224, 444);
            lbl_descPersonagem.Margin = new Padding(4, 0, 4, 0);
            lbl_descPersonagem.Name = "lbl_descPersonagem";
            lbl_descPersonagem.Size = new Size(29, 27);
            lbl_descPersonagem.TabIndex = 13;
            lbl_descPersonagem.Text = "A";
            lbl_descPersonagem.Visible = false;
            // 
            // gb_macacos
            // 
            gb_macacos.Anchor = AnchorStyles.None;
            gb_macacos.AutoSize = true;
            gb_macacos.BackColor = Color.Transparent;
            gb_macacos.Controls.Add(panel6);
            gb_macacos.Controls.Add(panel4);
            gb_macacos.Controls.Add(panel5);
            gb_macacos.Controls.Add(panel3);
            gb_macacos.Controls.Add(panel2);
            gb_macacos.Controls.Add(panel1);
            gb_macacos.Controls.Add(pnl_6);
            gb_macacos.Controls.Add(pnl_vergil);
            gb_macacos.Controls.Add(pnl_guerreiro);
            gb_macacos.Controls.Add(pnl_dio);
            gb_macacos.Controls.Add(pnl_alucard);
            gb_macacos.Controls.Add(pnl_lutador);
            gb_macacos.FlatStyle = FlatStyle.Flat;
            gb_macacos.ImeMode = ImeMode.NoControl;
            gb_macacos.Location = new Point(240, 286);
            gb_macacos.Margin = new Padding(4, 3, 4, 3);
            gb_macacos.Name = "gb_macacos";
            gb_macacos.Padding = new Padding(4, 3, 4, 3);
            gb_macacos.Size = new Size(465, 408);
            gb_macacos.TabIndex = 12;
            gb_macacos.TabStop = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.White;
            panel6.BackgroundImage = Properties.Resources.Cadeado;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox7);
            panel6.Location = new Point(365, 288);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(69, 69);
            panel6.TabIndex = 12;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(-195, -44);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 55);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.Cadeado;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(259, 288);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(69, 69);
            panel4.TabIndex = 11;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(-128, -27);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 55);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.White;
            panel5.BackgroundImage = Properties.Resources.Cadeado;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox6);
            panel5.Location = new Point(151, 288);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(69, 69);
            panel5.TabIndex = 11;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.InitialImage = (Image)resources.GetObject("pictureBox6.InitialImage");
            pictureBox6.Location = new Point(-128, -27);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.Cadeado;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(38, 288);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(69, 69);
            panel3.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(-128, -27);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.Cadeado;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(365, 178);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(69, 69);
            panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(-128, -27);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.Cadeado;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(259, 180);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(69, 69);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-128, -27);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pnl_dio
            // 
            pnl_dio.Anchor = AnchorStyles.None;
            pnl_dio.BackColor = Color.Transparent;
            pnl_dio.BackgroundImage = (Image)resources.GetObject("pnl_dio.BackgroundImage");
            pnl_dio.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_dio.BorderStyle = BorderStyle.FixedSingle;
            pnl_dio.Location = new Point(151, 78);
            pnl_dio.Margin = new Padding(4, 3, 4, 3);
            pnl_dio.Name = "pnl_dio";
            pnl_dio.Size = new Size(69, 69);
            pnl_dio.TabIndex = 4;
            pnl_dio.MouseLeave += pnl_Apostador_MouseLeave;
            pnl_dio.MouseHover += pnl_Apostador_MouseHover;
            // 
            // lbl_player
            // 
            lbl_player.Anchor = AnchorStyles.None;
            lbl_player.AutoSize = true;
            lbl_player.BackColor = Color.Transparent;
            lbl_player.FlatStyle = FlatStyle.Flat;
            lbl_player.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_player.ForeColor = Color.Red;
            lbl_player.Location = new Point(240, 241);
            lbl_player.Margin = new Padding(4, 0, 4, 0);
            lbl_player.Name = "lbl_player";
            lbl_player.Size = new Size(91, 25);
            lbl_player.TabIndex = 14;
            lbl_player.Text = "Player 1";
            // 
            // MenuPersonagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1460, 920);
            ControlBox = false;
            Controls.Add(pb_demo);
            Controls.Add(pictureBox3);
            Controls.Add(gb_status);
            Controls.Add(lbl_descPersonagem);
            Controls.Add(gb_macacos);
            Controls.Add(lbl_player);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPersonagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monkey Game";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pb_demo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            gb_status.ResumeLayout(false);
            gb_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            pnl_6.ResumeLayout(false);
            gb_macacos.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_demo;
        private Label lbl_nome;
        private Label lbl_ult;
        private Label lbl_carga;
        private Label lbl_def;
        private Label lbl_atk;
        private Panel pnl_alucard;
        private Panel pnl_lutador;
        private PictureBox pictureBox3;
        private Panel pnl_guerreiro;
        private GroupBox gb_status;
        private Panel pnl_vergil;
        private PictureBox pictureBox11;
        private Panel pnl_6;
        private Label lbl_descPersonagem;
        private GroupBox gb_macacos;
        private Panel pnl_dio;
        private Label lbl_player;
        private Panel panel6;
        private PictureBox pictureBox7;
        private Panel panel4;
        private PictureBox pictureBox5;
        private Panel panel5;
        private PictureBox pictureBox6;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}