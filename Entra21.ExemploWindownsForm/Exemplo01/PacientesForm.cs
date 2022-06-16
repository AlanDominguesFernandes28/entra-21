using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemploWindownsForm.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private int codigo = 1;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //obter as informacaoes do campo
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            //calcular imc
            var imc = peso / (altura * altura);
            if (indiceLinhaSelecionada == -1)
            {
                //Adicionar linha no datagridview de pacientes
                dataGridView1.Rows.Add(new object[] {
             codigo++ , nome, altura, peso, imc
            });
                return;
            }
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um Paciente : ");
                return;
            }

            var OpcaoEscolhida = MessageBox.Show(
                "Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            //verifica se o usuario escolheu realmente apagar o registro
            if (OpcaoEscolhida == DialogResult.Yes)
            {
                //remove a linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um Paciente");
                return;
            }
            //Obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            //obter a informacao da linha selecionada passado a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value); ;

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = ToString();

        }
    }
}
