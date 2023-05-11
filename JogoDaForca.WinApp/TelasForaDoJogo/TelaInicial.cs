using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca.WinApp
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnIniciarJogo_Click_1(object sender, EventArgs e)
        {
            TelaFormForca tl = new();
            tl.Show();
        }

        private void btnSairDoApliactivo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
