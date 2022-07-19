using Entra21.BancoDados01.Ado.Net.Views.Personagens;
using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cadastroPersonagem = new PersonagemListagemForm();
            cadastroPersonagem.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tipoPersonagem = new TipoPersonagemListagemForm();
            tipoPersonagem.ShowDialog();
        }
    }
}
