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
    public partial class EnderecosForm : Form
    {
        public partial class EnderecosForm : Form
        {
            private EnderecoServico enderecoServico;

            // Construtor: construir o objeto que está sendo instanciado com as devidas
            // informações ou rotinas
            public EnderecosForm()
            {
                InitializeComponent();

                enderecoServico = new EnderecoServico();

                // Deve apresentar os dados quando a tela for carregada
                PreencherDataGridViewComEnderecos();
            }

            private void buttonCancelar_Click(object sender, EventArgs e)
            {
                maskedTextBoxCep.Text = "";
                textBoxEnderecoCompleto.Text = "";
                comboBoxPaciente.SelectedIndex = -1;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                //Obter os dados preenchidos pelo usuario armazenando em variaveis

                var cep = maskedTextBoxCep.Text;
                var enderecoCompleto = textBoxEnderecoCompleto.Text;
                var paciente = comboBoxPaciente.SelectedIndex;

                //Construir o objeto de endereço com as variaveis
                var endereco = new Endereco();
                endereco.Cep = cep;
                endereco.EnderecoCompleto = enderecoCompleto;
                //endereco.Paciente = paciente;

                //Salvar este endereco na lista de endereços e no arquivo JSON
                enderecoServico.Adicionar(endereco);

                // Apresentar o registro novo no DataGridView
                PreencherDataGridViewComEnderecos();

            }


            private void buttonSalvar_Click(object sender, EventArgs e)
            {

                var cep = MaskedTextBoxCep.Text;
                var enderecoCompleto = textBoxEnderecoCompleto.Text;
                var paciente = comboBoxPaciente.SelectedItem;

                var endereco = new Endereco();
                endereco.Cep = cep;
                endereco.

            }

            private void buttonEditar_Click(object sender, EventArgs e)
            {
                EnderecoServico enderecoServico = new EnderecoServico();

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void dataGridViewEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {


            }
            private void PreencherDataGridViewComEnderecos()
            {
                // Obter todos os endereçoes da lista de endereços
                var enderecos = enderecoServico.ObterTodos();

                // Remover todas as linhas do dataGradView
                dataGridView1.Rows.Clear();

                //Remover a seleção do dataGradView
                dataGridView1.ClearSelection();

                // Percorrer cada um dos enderecos adicionado uma nova linha na tabela
                for (var i = 0; i < enderecos.Count; i++)
                {
                    //Obter endereco percorrido
                    var endereco = enderecos[i];

                    dataGridView1.Rows.Add(new object[] {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep, });
                    "" //endereco.Paciente.Nome

                
                }

            }
        }
    }
