using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;

        public TipoPersonagemListagemForm()
        {
            InitializeComponent();
            //instanciado objeto da classe tipopersonagemservico para permitir listar,editar,apagar

             tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListaForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void Cadastrar1_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastrarEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastrarEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            //obter todos os tipos de personagens cadastrados na tebla tipos_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void Apagar2_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Registro apagado com sucesso");
        }

    }
}
