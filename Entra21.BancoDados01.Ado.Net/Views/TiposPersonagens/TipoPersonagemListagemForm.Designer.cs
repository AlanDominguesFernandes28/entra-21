namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    partial class TipoPersonagemListagemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cadastrar1 = new System.Windows.Forms.Button();
            this.Apagar2 = new System.Windows.Forms.Button();
            this.Editar3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadastrar1
            // 
            this.Cadastrar1.Location = new System.Drawing.Point(694, 12);
            this.Cadastrar1.Name = "Cadastrar1";
            this.Cadastrar1.Size = new System.Drawing.Size(94, 29);
            this.Cadastrar1.TabIndex = 0;
            this.Cadastrar1.Text = "Cadastrar";
            this.Cadastrar1.UseVisualStyleBackColor = true;
            this.Cadastrar1.Click += new System.EventHandler(this.Cadastrar1_Click);
            // 
            // Apagar2
            // 
            this.Apagar2.Location = new System.Drawing.Point(450, 12);
            this.Apagar2.Name = "Apagar2";
            this.Apagar2.Size = new System.Drawing.Size(94, 29);
            this.Apagar2.TabIndex = 1;
            this.Apagar2.Text = "Apagar";
            this.Apagar2.UseVisualStyleBackColor = true;
            this.Apagar2.Click += new System.EventHandler(this.Salvar2_Click);
            // 
            // Editar3
            // 
            this.Editar3.Location = new System.Drawing.Point(573, 12);
            this.Editar3.Name = "Editar3";
            this.Editar3.Size = new System.Drawing.Size(94, 29);
            this.Editar3.TabIndex = 2;
            this.Editar3.Text = "Editar";
            this.Editar3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTipo});
            this.dataGridView1.Location = new System.Drawing.Point(3, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(785, 391);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Codigo";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.MinimumWidth = 6;
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            this.ColumnTipo.Width = 125;
            // 
            // TipoPersonagemListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Editar3);
            this.Controls.Add(this.Apagar2);
            this.Controls.Add(this.Cadastrar1);
            this.Name = "TipoPersonagemListagemForm";
            this.Text = "Tipos de Personagens";
            this.Load += new System.EventHandler(this.TipoPersonagemListaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Cadastrar1;
        private Button Apagar2;
        private Button Editar3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTipo;
    }
}