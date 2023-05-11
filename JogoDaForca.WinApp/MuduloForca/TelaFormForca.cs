using JogoDaForca.WinApp.MuduloForca;
using JogoDaForca.WinApp.Properties;
using System.Resources;

namespace JogoDaForca.WinApp
{
    public partial class TelaFormForca : Form
    {
        public char palpite;
        Forca jogo = new Forca();
        char charComErro = '?';


        public TelaFormForca()
        {
            InitializeComponent();
            ConfigurarClickDosBotoes();
            lblPalavraParcial.Text = jogo.PalavraParcial;
            DesenharForca(jogo.Erros);
        }

        private void ConfigurarClickDosBotoes()
        {
            foreach (Button botao in tableLayoutPanel1.Controls)
            {
                botao.Click += AtribuirLetra;
            }
        }

        private char ObterPalpite()
        {
            try
            {
                palpite = Convert.ToChar(txtObterPalpite.Text.ToUpper());
            }
            catch (FormatException)
            {
                MessageBox.Show("Deve ser informado apenas uma letra..", "LETRA INVÁLIDA");
                return '?';
            }
            return palpite;
        }




        private void AtribuirLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            txtObterPalpite.Text += botaoClicado.Text;
        }



        private void btnChutar_Click_1(object sender, EventArgs e)
        {
            RodaOJogo();
        }


        private void RodaOJogo()
        {
            palpite = ObterPalpite();
            if (palpite != charComErro)
            {
                if (jogo.JogadorAcertou(palpite) || jogo.JogadorPerdeu())
                {
                    TelaFinal tl = new TelaFinal();
                    tl.lblMensagemFinal.Text = jogo.mensagemFinal;
                    if (jogo.JogadorAcertou(palpite))
                    {
                        tl.picBoxMostrarEmoji.Image = Resources.diwali_sparkles_stars;
                    }
                    lblPalavraParcial.Text = jogo.PalavraParcial;
                    Close();
                    tl.ShowDialog();
                }
                lblPalavraParcial.Text = jogo.PalavraParcial;
                DesenharForca(jogo.Erros);
                txtObterPalpite.Text = "";
            }
        }





        void DesenharForca(int quantidadeErros)
        {
            if (quantidadeErros == 1)
            {
                picBoxBoneco.Image = Resources._2;
            }
            if (quantidadeErros == 2)
            {
                picBoxBoneco.Image = Resources._3;
            }
            if (quantidadeErros == 3)
            {
                picBoxBoneco.Image = Resources._5;
            }
            if (quantidadeErros == 4)
            {
                picBoxBoneco.Image = Resources._7;
            }
            if (quantidadeErros == 5)
            {
                picBoxBoneco.Image = Resources._8;
            }

        }

    }
}