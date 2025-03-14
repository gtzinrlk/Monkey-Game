using System;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace MonkeyGame
{
    public partial class Introdução : Form
    {
        private int Opacity = 255; // Opacidade inicial (sólida)
        public SoundControl soundControl;
        int volta;
        int menu;
        int musica;
        float i = 0.0f;
        int sec = 4;

        public Introdução()
        {
            InitializeComponent();


            if (musica == 0)
            soundControl = new SoundControl("FateofSixtyYears.wav");
            soundControl.SetVolume(0.55f);
            soundControl.PlayLooping();
            /*SoundManager.Initialize("FateofSixtyYears.wav");
            SoundManager.PlayLooping();*/
            musica++;
        }

        private void Introdução_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            timer4.Start();
        }



        private void FadeOutAnimation()
        {
            // Aguarda por mais 4 segundos (4000 ms)
            if (Opacity > 0)
            {
                Opacity -= 10; // Ajuste o valor para controlar a velocidade do fade
                if (Opacity < 0)

                    Opacity = 0;
                Opacity--;

                // Define a opacidade da PictureBox
                pictureBox1.Image = ChangeImageOpacity(pictureBox1.Image, Opacity);
            }
            else
            {
                // Abre o próximo formulário
                if (menu == 0)
                    AbrirMenuJogo();
                menu++;
            }
        }
        private void AbrirMenuJogo()
        {
            MenuJogo menuJogo = new MenuJogo();
            menuJogo.Show();
            this.Hide();
        }

        // Função para alterar a opacidade de uma imagem
        private Image ChangeImageOpacity(Image img, int Opacity)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = Opacity / 255f;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
                this.Close();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                sec--;
                if (sec == 0)
                {
                    timer4.Stop();

                    // Configuração do Timer para controlar a animação de fade
                    timer3.Interval = 100; // Intervalo de tempo (100 ms, pode ser ajustado)
                    timer3.Tick += (s, args) => FadeOutAnimation();
                    timer3.Start();
                }
            }
        }
    }
}
