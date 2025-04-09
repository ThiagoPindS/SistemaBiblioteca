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
            dgvAcervo = new DataGridView();
            txtPesquisar = new TextBox();
            btnRemover = new Button();
            btnEditar = new Button();
            btnAlterarStatus = new Button();
            lblPesquisar = new Label();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblAnoDaPublicacao = new Label();
            txtAnoDaPublicacao = new TextBox();
            btnCadastro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAcervo).BeginInit();
            SuspendLayout();
            // 
            // dgvAcervo
            // 
            dgvAcervo.AllowUserToAddRows = false;
            dgvAcervo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcervo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAcervo.Location = new Point(12, 41);
            dgvAcervo.Name = "dgvAcervo";
            dgvAcervo.ReadOnly = true;
            dgvAcervo.RowHeadersVisible = false;
            dgvAcervo.RowHeadersWidth = 51;
            dgvAcervo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAcervo.Size = new Size(560, 292);
            dgvAcervo.TabIndex = 13;
            dgvAcervo.CellClick += dgvAcervo_CellClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(78, 12);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(319, 23);
            txtPesquisar.TabIndex = 14;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(14, 426);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(89, 23);
            btnRemover.TabIndex = 19;
            btnRemover.Text = "Excluir Livro";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(16, 368);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(89, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar Livro";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAlterarStatus
            // 
            btnAlterarStatus.Location = new Point(16, 397);
            btnAlterarStatus.Name = "btnAlterarStatus";
            btnAlterarStatus.Size = new Size(87, 23);
            btnAlterarStatus.TabIndex = 21;
            btnAlterarStatus.Text = "Alterar Status";
            btnAlterarStatus.UseVisualStyleBackColor = true;
            btnAlterarStatus.Click += btnAlterarStatus_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesquisar.Location = new Point(12, 15);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(60, 15);
            lblPesquisar.TabIndex = 23;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(403, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "Status:";
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Todos", "Disponível", "Emprestado" });
            cbxStatus.Location = new Point(451, 12);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(121, 23);
            cbxStatus.TabIndex = 25;
            cbxStatus.Text = "Todos";
            cbxStatus.SelectedIndexChanged += cbxStatus_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 342);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(41, 15);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(62, 339);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(136, 23);
            txtTitulo.TabIndex = 29;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(204, 342);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 30;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(250, 339);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(136, 23);
            txtAutor.TabIndex = 34;
            // 
            // lblAnoDaPublicacao
            // 
            lblAnoDaPublicacao.AutoSize = true;
            lblAnoDaPublicacao.Location = new Point(392, 342);
            lblAnoDaPublicacao.Name = "lblAnoDaPublicacao";
            lblAnoDaPublicacao.Size = new Size(109, 15);
            lblAnoDaPublicacao.TabIndex = 35;
            lblAnoDaPublicacao.Text = "Ano da Publicação:";
            // 
            // txtAnoDaPublicacao
            // 
            txtAnoDaPublicacao.Location = new Point(507, 339);
            txtAnoDaPublicacao.Name = "txtAnoDaPublicacao";
            txtAnoDaPublicacao.Size = new Size(68, 23);
            txtAnoDaPublicacao.TabIndex = 36;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(451, 426);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(121, 23);
            btnCadastro.TabIndex = 37;
            btnCadastro.Text = "Voltar ao Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(btnCadastro);
            Controls.Add(txtAnoDaPublicacao);
            Controls.Add(lblAnoDaPublicacao);
            Controls.Add(txtAutor);
            Controls.Add(lblAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(cbxStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblPesquisar);
            Controls.Add(btnAlterarStatus);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvAcervo);
            Name = "Consulta";
            Text = "Gestão Biblioteca | Consulta";
            Click += btnCadastro_Click;
            ((System.ComponentModel.ISupportInitialize)dgvAcervo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dgvAcervo;
        public TextBox txtPesquisar;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnAlterarStatus;
        private Label lblPesquisar;
        private Label lblStatus;
        private ComboBox cbxStatus;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblAutor;
        private TextBox txtAutor;
        private Label lblAnoDaPublicacao;
        private TextBox txtAnoDaPublicacao;
        private Button btnCadastro;
    }
}