namespace MonkeyGame
{
    partial class MenuJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuJogo));
            lbl_comecar = new Label();
            lbl_regras = new Label();
            lbl_sair = new Label();
            lbl_extras = new Label();
            lbl_version = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pb_2 = new PictureBox();
            pb_1 = new PictureBox();
            pb_4 = new PictureBox();
            pb_3 = new PictureBox();
            pb_6 = new PictureBox();
            pb_5 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lbl_comecar
            // 
            lbl_comecar.Anchor = AnchorStyles.None;
            lbl_comecar.AutoSize = true;
            lbl_comecar.BackColor = Color.Transparent;
            lbl_comecar.Font = new Font("Segoe UI", 30.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_comecar.ForeColor = Color.White;
            lbl_comecar.Location = new Point(522, 399);
            lbl_comecar.Name = "lbl_comecar";
            lbl_comecar.Size = new Size(297, 55);
            lbl_comecar.TabIndex = 0;
            lbl_comecar.Text = "Começar Jogo";
            lbl_comecar.Click += lbl_comecar_Click;
            lbl_comecar.MouseLeave += lbl_comecar_MouseLeave;
            lbl_comecar.MouseHover += lbl_comecar_MouseHover;
            // 
            // lbl_regras
            // 
            lbl_regras.Anchor = AnchorStyles.None;
            lbl_regras.AutoSize = true;
            lbl_regras.BackColor = Color.Transparent;
            lbl_regras.Font = new Font("Segoe UI", 30.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_regras.ForeColor = SystemColors.ActiveCaptionText;
            lbl_regras.Location = new Point(608, 365);
            lbl_regras.Name = "lbl_regras";
            lbl_regras.Size = new Size(0, 55);
            lbl_regras.TabIndex = 0;
            lbl_regras.Click += lbl_regras_Click;
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.None;
            lbl_sair.AutoSize = true;
            lbl_sair.BackColor = Color.Transparent;
            lbl_sair.Font = new Font("Segoe UI", 30.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(544, 568);
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(262, 55);
            lbl_sair.TabIndex = 0;
            lbl_sair.Text = "Sair do Jogo";
            lbl_sair.Click += lbl_quit_Click;
            lbl_sair.MouseLeave += lbl_quit_MouseLeave;
            lbl_sair.MouseHover += lbl_quit_MouseHover;
            // 
            // lbl_extras
            // 
            lbl_extras.Anchor = AnchorStyles.None;
            lbl_extras.AutoSize = true;
            lbl_extras.BackColor = Color.Transparent;
            lbl_extras.Font = new Font("Segoe UI", 30.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_extras.ForeColor = Color.White;
            lbl_extras.Location = new Point(591, 484);
            lbl_extras.Name = "lbl_extras";
            lbl_extras.Size = new Size(141, 55);
            lbl_extras.TabIndex = 0;
            lbl_extras.Text = "Extras";
            lbl_extras.Click += lbl_extra_Click;
            lbl_extras.MouseLeave += lbl_extra_MouseLeave;
            lbl_extras.MouseHover += lbl_extra_MouseHover;
            // 
            // lbl_version
            // 
            lbl_version.Anchor = AnchorStyles.None;
            lbl_version.AutoSize = true;
            lbl_version.BackColor = Color.Transparent;
            lbl_version.ForeColor = Color.White;
            lbl_version.Location = new Point(134, 651);
            lbl_version.Name = "lbl_version";
            lbl_version.Size = new Size(84, 15);
            lbl_version.TabIndex = 1;
            lbl_version.Text = "version. 0.2.1.1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.monkeyMenu;
            pictureBox1.Location = new Point(113, 627);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.monkeyMenu4;
            pictureBox2.Location = new Point(147, 627);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.monkeyMenu2;
            pictureBox3.Location = new Point(181, 627);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.monkeyMenu3;
            pictureBox4.Location = new Point(215, 627);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pb_2
            // 
            pb_2.Anchor = AnchorStyles.None;
            pb_2.BackColor = Color.Transparent;
            pb_2.Image = Properties.Resources.banana_right;
            pb_2.Location = new Point(859, 415);
            pb_2.Name = "pb_2";
            pb_2.Size = new Size(33, 31);
            pb_2.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_2.TabIndex = 3;
            pb_2.TabStop = false;
            pb_2.Visible = false;
            // 
            // pb_1
            // 
            pb_1.Anchor = AnchorStyles.None;
            pb_1.BackColor = Color.Transparent;
            pb_1.BackgroundImageLayout = ImageLayout.Center;
            pb_1.Image = Properties.Resources.banana_left;
            pb_1.Location = new Point(483, 415);
            pb_1.Name = "pb_1";
            pb_1.Size = new Size(32, 32);
            pb_1.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_1.TabIndex = 3;
            pb_1.TabStop = false;
            pb_1.Visible = false;
            // 
            // pb_4
            // 
            pb_4.Anchor = AnchorStyles.None;
            pb_4.BackColor = Color.Transparent;
            pb_4.Image = Properties.Resources.banana_right;
            pb_4.Location = new Point(786, 497);
            pb_4.Name = "pb_4";
            pb_4.Size = new Size(33, 31);
            pb_4.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_4.TabIndex = 3;
            pb_4.TabStop = false;
            pb_4.Visible = false;
            // 
            // pb_3
            // 
            pb_3.Anchor = AnchorStyles.None;
            pb_3.BackColor = Color.Transparent;
            pb_3.Image = Properties.Resources.banana_left;
            pb_3.Location = new Point(544, 497);
            pb_3.Name = "pb_3";
            pb_3.Size = new Size(33, 31);
            pb_3.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_3.TabIndex = 3;
            pb_3.TabStop = false;
            pb_3.Visible = false;
            // 
            // pb_6
            // 
            pb_6.Anchor = AnchorStyles.None;
            pb_6.BackColor = Color.Transparent;
            pb_6.Image = Properties.Resources.banana_right;
            pb_6.Location = new Point(825, 584);
            pb_6.Name = "pb_6";
            pb_6.Size = new Size(33, 31);
            pb_6.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_6.TabIndex = 3;
            pb_6.TabStop = false;
            pb_6.Visible = false;
            // 
            // pb_5
            // 
            pb_5.Anchor = AnchorStyles.None;
            pb_5.BackColor = Color.Transparent;
            pb_5.Image = Properties.Resources.banana_left;
            pb_5.Location = new Point(505, 584);
            pb_5.Name = "pb_5";
            pb_5.Size = new Size(33, 31);
            pb_5.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_5.TabIndex = 3;
            pb_5.TabStop = false;
            pb_5.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(239, 30);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(911, 366);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // MenuJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 693);
            Controls.Add(pictureBox5);
            Controls.Add(pb_5);
            Controls.Add(pb_3);
            Controls.Add(pb_6);
            Controls.Add(pb_1);
            Controls.Add(pb_4);
            Controls.Add(pb_2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_version);
            Controls.Add(lbl_extras);
            Controls.Add(lbl_sair);
            Controls.Add(lbl_regras);
            Controls.Add(lbl_comecar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monkey Game";
            Load += MenuJogo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_comecar;
        private Label lbl_regras;
        private Label lbl_sair;
        private Label lbl_extras;
        private Label lbl_version;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pb_2;
        private PictureBox pb_1;
        private PictureBox pb_4;
        private PictureBox pb_3;
        private PictureBox pb_6;
        private PictureBox pb_5;
        private PictureBox pictureBox5;
    }
}