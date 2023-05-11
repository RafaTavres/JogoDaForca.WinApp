namespace JogoDaForca.WinApp
{
    partial class TelaInicial
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
            btnIniciarJogo = new Button();
            btnSairDoApliactivo = new Button();
            lblTituloPrincipal = new Label();
            SuspendLayout();
            // 
            // btnIniciarJogo
            // 
            btnIniciarJogo.BackColor = SystemColors.Desktop;
            btnIniciarJogo.ForeColor = SystemColors.Info;
            btnIniciarJogo.Location = new Point(175, 142);
            btnIniciarJogo.Margin = new Padding(4, 3, 4, 3);
            btnIniciarJogo.Name = "btnIniciarJogo";
            btnIniciarJogo.Size = new Size(107, 43);
            btnIniciarJogo.TabIndex = 0;
            btnIniciarJogo.Text = "JOGAR!";
            btnIniciarJogo.UseVisualStyleBackColor = false;
            btnIniciarJogo.Click += btnIniciarJogo_Click_1;
            // 
            // btnSairDoApliactivo
            // 
            btnSairDoApliactivo.BackColor = SystemColors.ControlText;
            btnSairDoApliactivo.ForeColor = SystemColors.Info;
            btnSairDoApliactivo.Location = new Point(175, 205);
            btnSairDoApliactivo.Margin = new Padding(4, 3, 4, 3);
            btnSairDoApliactivo.Name = "btnSairDoApliactivo";
            btnSairDoApliactivo.Size = new Size(107, 43);
            btnSairDoApliactivo.TabIndex = 1;
            btnSairDoApliactivo.Text = "SAIR";
            btnSairDoApliactivo.UseVisualStyleBackColor = false;
            btnSairDoApliactivo.Click += btnSairDoApliactivo_Click;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.BorderStyle = BorderStyle.Fixed3D;
            lblTituloPrincipal.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloPrincipal.ForeColor = SystemColors.Info;
            lblTituloPrincipal.Location = new Point(69, 53);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(339, 44);
            lblTituloPrincipal.TabIndex = 2;
            lblTituloPrincipal.Text = "JOGO DA FORCA";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            BackgroundImage = Properties.Resources.piso_de_madeira_marrom;
            ClientSize = new Size(475, 323);
            Controls.Add(lblTituloPrincipal);
            Controls.Add(btnSairDoApliactivo);
            Controls.Add(btnIniciarJogo);
            Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaInicial";
            Text = "TelaInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarJogo;
        private Button btnSairDoApliactivo;
        private Label lblTituloPrincipal;
    }
}