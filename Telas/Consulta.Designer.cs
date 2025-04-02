namespace Prova_POO_Abril_Ian_Pereira
{
    partial class Consulta
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
            lblTelaDeConsulta = new Label();
            dgvAcervo = new DataGridView();
            txtFTitulo = new TextBox();
            btnRemover = new Button();
            btnEditar = new Button();
            btnStatus = new Button();
            btnCadastro = new Button();
            lblPesquisar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAcervo).BeginInit();
            SuspendLayout();
            // 
            // lblTelaDeConsulta
            // 
            lblTelaDeConsulta.AutoSize = true;
            lblTelaDeConsulta.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelaDeConsulta.Location = new Point(93, 9);
            lblTelaDeConsulta.Name = "lblTelaDeConsulta";
            lblTelaDeConsulta.Size = new Size(264, 45);
            lblTelaDeConsulta.TabIndex = 12;
            lblTelaDeConsulta.Text = "Tela de Consulta";
            // 
            // dgvAcervo
            // 
            dgvAcervo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcervo.Location = new Point(12, 86);
            dgvAcervo.Name = "dgvAcervo";
            dgvAcervo.RowHeadersWidth = 51;
            dgvAcervo.Size = new Size(420, 295);
            dgvAcervo.TabIndex = 13;
            // 
            // txtFTitulo
            // 
            txtFTitulo.Location = new Point(78, 57);
            txtFTitulo.Name = "txtFTitulo";
            txtFTitulo.Size = new Size(354, 23);
            txtFTitulo.TabIndex = 14;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(181, 387);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 19;
            btnRemover.Text = "Remover Livro";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 387);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar Livro";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(345, 387);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(87, 23);
            btnStatus.TabIndex = 21;
            btnStatus.Text = "Alterar Status";
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.Location = new Point(12, 416);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(419, 68);
            btnCadastro.TabIndex = 22;
            btnCadastro.Text = "Voltar ao Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesquisar.Location = new Point(12, 65);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(60, 15);
            lblPesquisar.TabIndex = 23;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 497);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCadastro);
            Controls.Add(btnStatus);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(txtFTitulo);
            Controls.Add(dgvAcervo);
            Controls.Add(lblTelaDeConsulta);
            Name = "Consulta";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)dgvAcervo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTelaDeConsulta;
        private DataGridView dgvAcervo;
        private TextBox txtFTitulo;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnStatus;
        private Button btnCadastro;
        private Label lblPesquisar;
    }
}