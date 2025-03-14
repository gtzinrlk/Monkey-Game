namespace MonkeyGame
{
    partial class MenuAdicionarPontos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdicionarPontos));
            lbl_aviso = new Label();
            txt_instagram = new TextBox();
            SuspendLayout();
            // 
            // lbl_aviso
            // 
            lbl_aviso.Anchor = AnchorStyles.None;
            lbl_aviso.AutoSize = true;
            lbl_aviso.Location = new Point(228, 125);
            lbl_aviso.Name = "lbl_aviso";
            lbl_aviso.Size = new Size(271, 15);
            lbl_aviso.TabIndex = 0;
            lbl_aviso.Text = "Escreva seu instagram para concorrer a premiação";
            // 
            // txt_instagram
            // 
            txt_instagram.Anchor = AnchorStyles.None;
            txt_instagram.Location = new Point(198, 152);
            txt_instagram.Name = "txt_instagram";
            txt_instagram.PlaceholderText = "Seu Instagram";
            txt_instagram.Size = new Size(326, 23);
            txt_instagram.TabIndex = 1;
            txt_instagram.TextAlign = HorizontalAlignment.Center;
            txt_instagram.KeyUp += txt_instagram_KeyUp;
            // 
            // MenuAdicionarPontos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_instagram);
            Controls.Add(lbl_aviso);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuAdicionarPontos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monkey Game";
            Load += MenuAdicionarPontos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_aviso;
        private TextBox txt_instagram;
    }
}