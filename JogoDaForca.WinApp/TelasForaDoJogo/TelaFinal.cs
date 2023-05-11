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
    public partial class TelaFinal : Form
    {
        public TelaFinal()
        {
            InitializeComponent();

        }

        private void btnVoltarParaInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
