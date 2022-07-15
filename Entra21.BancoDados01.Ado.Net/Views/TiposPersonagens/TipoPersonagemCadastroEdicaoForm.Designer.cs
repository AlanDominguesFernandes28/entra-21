namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    partial class TipoPersonagemCadastroEdicaoForm
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
            this.Cancelar1 = new System.Windows.Forms.Button();
            this.Salvar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancelar1
            // 
            this.Cancelar1.Location = new System.Drawing.Point(434, 157);
            this.Cancelar1.Name = "Cancelar1";
            this.Cancelar1.Size = new System.Drawing.Size(94, 29);
            this.Cancelar1.TabIndex = 0;
            this.Cancelar1.Text = "Cancelar";
            this.Cancelar1.UseVisualStyleBackColor = true;
            // 
            // Salvar1
            // 
            this.Salvar1.Location = new System.Drawing.Point(315, 157);
            this.Salvar1.Name = "Salvar1";
            this.Salvar1.Size = new System.Drawing.Size(94, 29);
            this.Salvar1.TabIndex = 1;
            this.Salvar1.Text = "Salvar";
            this.Salvar1.UseVisualStyleBackColor = true;
            this.Salvar1.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(12, 48);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(298, 27);
            this.textBoxTipo.TabIndex = 3;
            // 
            // TipoPersonagemCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 198);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salvar1);
            this.Controls.Add(this.Cancelar1);
            this.Name = "TipoPersonagemCadastroEdicaoForm";
            this.Text = "Tipo de Personagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancelar1;
        private Button Salvar1;
        private Label label1;
        private TextBox textBoxTipo;
    }
}