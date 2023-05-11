namespace JogoDaForca.WinApp
{
    partial class TelaFinal
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
            btnVoltarParaInicio = new Button();
            lblMensagemFinal = new Label();
            picBoxMostrarEmoji = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxMostrarEmoji).BeginInit();
            SuspendLayout();
            // 
            // btnVoltarParaInicio
            // 
            btnVoltarParaInicio.BackColor = SystemColors.Menu;
            btnVoltarParaInicio.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltarParaInicio.Location = new Point(142, 225);
            btnVoltarParaInicio.Margin = new Padding(5, 4, 5, 4);
            btnVoltarParaInicio.Name = "btnVoltarParaInicio";
            btnVoltarParaInicio.Size = new Size(166, 49);
            btnVoltarParaInicio.TabIndex = 0;
            btnVoltarParaInicio.Text = "VOLTAR";
            btnVoltarParaInicio.UseVisualStyleBackColor = false;
            btnVoltarParaInicio.Click += btnVoltarParaInicio_Click;
            // 
            // lblMensagemFinal
            // 
            lblMensagemFinal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMensagemFinal.AutoSize = true;
            lblMensagemFinal.BackColor = Color.Transparent;
            lblMensagemFinal.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensagemFinal.ForeColor = SystemColors.ControlLightLight;
            lblMensagemFinal.Location = new Point(101, 37);
            lblMensagemFinal.Margin = new Padding(5, 0, 5, 0);
            lblMensagemFinal.Name = "lblMensagemFinal";
            lblMensagemFinal.Size = new Size(222, 29);
            lblMensagemFinal.TabIndex = 1;
            lblMensagemFinal.Text = "MensagemFinal";
            // 
            // picBoxMostrarEmoji
            // 
            picBoxMostrarEmoji.BackColor = Color.Transparent;
            picBoxMostrarEmoji.Image = Properties.Resources.loudly_crying_face_joypixels;
            picBoxMostrarEmoji.Location = new Point(426, 84);
            picBoxMostrarEmoji.Name = "picBoxMostrarEmoji";
            picBoxMostrarEmoji.Size = new Size(213, 209);
            picBoxMostrarEmoji.TabIndex = 2;
            picBoxMostrarEmoji.TabStop = false;
            // 
            // TelaFinal
            // 
            AutoScaleDimensions = new SizeF(11F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.piso_de_madeira_marrom;
            ClientSize = new Size(664, 320);
            Controls.Add(picBoxMostrarEmoji);
            Controls.Add(lblMensagemFinal);
            Controls.Add(btnVoltarParaInicio);
            Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "TelaFinal";
            Text = "TelaFinal";
            ((System.ComponentModel.ISupportInitialize)picBoxMostrarEmoji).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarParaInicio;
        public Label lblMensagemFinal;
        public PictureBox picBoxMostrarEmoji;
    }
}