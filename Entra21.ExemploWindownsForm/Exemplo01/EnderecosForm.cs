using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        // Construtor: construir o objeto que está sendo instanciado com as devidas
        // informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            // Instanciado o objeto de PacienteServico o permitirá listar os
            // pacientes no ComboBox e decorrente disso será possível o usuário selecionar o mesmo
            pacienteServico = new PacienteServico();

            // Deve apresentar os dados quando a tela for carregada
            PreencherDataGridViewComEnderecos();

            // Irá preencher o ComboBox(campo de selação) com os pacientes
            PreencherComboBoxComOsNomesDosPacientes();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            // Obter lista dos pacientes, que foram cadastrados, ou seja, armazenados no JSON
            var pacientes = pacienteServico.ObterTodos();

            // Percorrer todos os pacientes adicionando no ComboBox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuário armazenando em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            // Executa o método ValidarDados que retornará um bool
            // Sendo true quando os dados forem válidos
            // False quando os dados forem inválidos
            var dadosValidos = ValidarDados(cep, enderecoCompleto, nomePaciente);

            // Verifica se os dados são inválidos para n dar continuidade no cadastro do endereço
            if (dadosValidos == false)
            {
                return;
            }

            // Construir o objeto de endereço com as variáveis
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereço na lista de endereços e no arquivo JSON
            enderecoServico.Adicionar(endereco);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private void PreencherDataGridViewComEnderecos()
        {
            // Obter todos os endereços da lista de endereços
            var enderecos = enderecoServico.ObterTodos();

            // Remover todas as linhas do dataGridView
            dataGridView1.Rows.Clear();

            // Remover a seleção do dataGridView
            dataGridView1.ClearSelection();

            // Percorrer cada um dos endereços adicionado uma nova linha na tabela
            for (var i = 0; i < enderecos.Count; i++)
            {
                // Obter endereço percorrido
                var endereco = enderecos[i];

                // Cria uma nova linha no DataGridView com os dados referentes ao endereço

                dataGridView1.Rows.Add(new object[] {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                return;
            }

            // HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisição para o Site ViaCep para obter os dados do endereço do cep
            var resultado = httpClient.GetAsync(
                $"https://viacep.com.br/ws/{cep}/json/").Result;

            // Verificar se a requisição deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter a responsta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text =
                    $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }

        // Será executado este método quando o usuário sair do campo de cep
        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve conter no mínimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }

            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um paciente");

                comboBoxPaciente.DroppedDown = true;

                return false;
            }

            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Verificar se algum item do DataGridView está selecionado
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }

            // Questionar se o usuário realmente deseja apagar
            var resposta = MessageBox.Show(
                "Deseja realmente apagar o endereço?", "Aviso",
                MessageBoxButtons.YesNo);

            // Validar que o usuário não escolheu Sim, pq n deverá continuar executando o código abaixo
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa teu registro ta ali salvo");

                return;
            }

            // Qual item será apagado
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter o código da linha selecionada na primeira coluna, que não está sendo apresentada para o usuário, que é referente ao código do endereço
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // ✓ Apagar o item da lista de itens no serviço
            // ✓ Atualizar o arquivo JSON
            // Buscar o endereço da lista de endereços filtrando por código
            var endereco = enderecoServico.ObterPorCodigo(codigo);
            // Apagar o endereço encontrado da lista de endereços e atualizar o arquivo JSON
            enderecoServico.Apagar(endereco);

            // Atualizar o DataGridView
            PreencherDataGridViewComEnderecos();

            // Remover a seleção do DataGridView
            dataGridView1.ClearSelection();
        }
    }
}
