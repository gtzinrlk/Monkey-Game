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
    public partial class MenuCredito : Form
    {
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        public MenuCredito()
        {
            InitializeComponent();

        }

        private void MenuCredito_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            // Carregue a fonte importada
            fontCollection.AddFontFile(@"..\..\..\Fonts\PixelifySans-Bold.ttf"); // Substitua pelo caminho correto

            // Verifique se a fonte foi carregada com sucesso
            if (fontCollection.Families.Length > 0)
            {
                // Crie uma fonte com a fonte importada
                Font fonteImportada = new Font(fontCollection.Families[0], 32, FontStyle.Regular);

                // Atribua a fonte importada à sua Label
                lbl_dznGuti.Font = fonteImportada;
                lbl_devVictor.Font = fonteImportada;
                lbl_devPedro.Font = fonteImportada;
                lbl_devGuti.Font = fonteImportada;
                lbl_dzn2Gusta.Font = fonteImportada;
                lbl_bdGuti.Font = fonteImportada;
                lbl_webgu.Font = fonteImportada;

            }
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            MenuExtras menuExtras = new MenuExtras();
            menuExtras.Show();
            this.Close();
        }

        private void lbl_voltar_MouseHover(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.White;
            lbl_voltar.Cursor = Cursors.Hand;
            pb_1.Visible = true;
            pb_2.Visible = true;
        }

        private void lbl_voltar_MouseLeave(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.White;
            lbl_voltar.Cursor = Cursors.Hand;
            pb_1.Visible = false;
            pb_2.Visible = false;
        }
    }
}
