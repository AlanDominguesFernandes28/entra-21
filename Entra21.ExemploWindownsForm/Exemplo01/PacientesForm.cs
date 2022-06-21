using Newtonsoft.Json;
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
        private List<Paciente> pacientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();
            //cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();
            //ler do arquivo json os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //obter as informacaoes do campo
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            //calcular imc
            var imc = CalcularImc(peso, altura);
            //verifica se sta em modo adicao
            if (indiceLinhaSelecionada == -1)
            {
                //Adicionar linha no datagridview de pacientes
                dataGridView1.Rows.Add(new object[] {
             ++codigo , nome, altura, peso, imc});

                AdicionarPacienteSalvandoNoArquivo(codigo, nome, peso, altura);
                return;
            }


            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

            indiceLinhaSelecionada = -1;

        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNome.Text = "";
            textBoxAltura.Text = "";

            indiceLinhaSelecionada = -1;
            dataGridView1.ClearSelection();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0 )
            {
                MessageBox.Show("Selecione um Paciente : ");
                return;
            }

            var OpcaoEscolhida = MessageBox.Show(
                "Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            //verifica se o usuario escolheu realmente apagar o registro
            if (OpcaoEscolhida == DialogResult.Yes)
            {
                var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;
                //remove a linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(quantidadeLinhasSelecionadas);
                //remove o pacinete da lista de pacientes
                pacientes.RemoveAt(quantidadeLinhasSelecionadas);
                //atualiza o arquivo com lista de pacientes sem o paciente removido
                SalvarEmArquivo();
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

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();
            LimparCampos();
        }

        private void AdicionarPacienteSalvandoNoArquivo(
            int codigo,string nome,double peso,double altura)
        {
            var paciente = new Paciente()
            {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };     

            pacientes.Add(paciente);

            SalvarEmArquivo();
            LimparCampos();
        }
        private void SalvarEmArquivo()
        {
            //converter uma lista de objetos em uma string contendo o Json
            var pacientesEmJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.Json";
            //Salvar a string contendo o json em um raquivo no formato json
            File.WriteAllText(caminho, pacientesEmJson);
        }
        private void LerArquivoApresentandoPacientes()
        {
            if (File.Exists("pacientes.json") == false)
                return;
            //ler arquivo json e armazenar os poacinets na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            //cria uma variavel para armazenar o codigo do ultimo produto para quando
            //cadstrar um novo armazenar com o codigo correto

            var maiorCodigo = int.MinValue;

            //percorre a lista de pacientes
            for (int i = 0; i < pacientes.Count; i++)
            {
                //obtem o  paciente que esta sendo percorrido
                var paciente = pacientes[i];

                //adiciona o paciente que estava no arquivo json no datagridview
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome,
                    paciente.Altura,paciente.Peso,
                    CalcularImc(paciente.Peso,paciente.Altura)
                });
                //rotina para descobrir o paciente com o maior codigo
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;

            }
            //validar se descobriru encontrar algum codigo algum codigo,caso contrario nao
            //deve atualizar o codigo do novo paciente
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;
        }

        private double CalcularImc(double peso,double altura)
        {
            return peso / Math.Pow(altura, 2);
        }
    }

}
