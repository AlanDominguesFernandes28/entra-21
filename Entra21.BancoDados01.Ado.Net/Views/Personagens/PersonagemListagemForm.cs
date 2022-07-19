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

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemListagemForm : Form
    {
        // definindo como readolny sera permitida a criacao da instancia somente no contrutor
        private readonly PersonagemService _personagemService;


        //aqui fica o contrutor tem como objetivo construir o objeto com 
        //prioridades necessarios e execucao de metodos obrigatorios
        //ou seja neste cenario desenhar a tela e instanciar o objeto do servico
        // que permitirs gerenciar os dados referente ao personagem
        public PersonagemListagemForm()
        {
            InitializeComponent();
            
            _personagemService = new PersonagemService();

            

            PreencherDataGridviewComPersonagens();
        }
        private void PreencherDataGridviewComPersonagens()
        {
            var personagens = _personagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < personagens.Count; i++)
            {
                var personagem = personagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    personagem.Id,
                    personagem.Nome,
                    personagem.TipoPersonagem.Tipo,
                    personagem.Editora.Nome

                });

            }
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemCadastroEdicaoForm();
            personagemForm.ShowDialog();

            PreencherDataGridviewComPersonagens();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            _personagemService.Apagar(id);
            PreencherDataGridviewComPersonagens();
            MessageBox.Show("Registro reovido com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum personagem");
                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var personagem = _personagemService.ObterPorId(id);

            var personagemCadastroForm = new PersonagemCadastroEdicaoForm(personagem);
            personagemCadastroForm.ShowDialog();

            PreencherDataGridviewComPersonagens();


            
          
        }
    }
}
