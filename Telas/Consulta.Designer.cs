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
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            AnoDePublicação = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            txtPesquisar = new TextBox();
            btnRemover = new Button();
            btnEditar = new Button();
            btnAlterarStatus = new Button();
            btnCadastro = new Button();
            lblPesquisar = new Label();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            btnConsultar = new Button();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblAnoDaPublicacao = new Label();
            txtAnoDaPublicacao = new TextBox();
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
            dgvAcervo.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, Autor, AnoDePublicação, Status });
            dgvAcervo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAcervo.Location = new Point(12, 115);
            dgvAcervo.Name = "dgvAcervo";
            dgvAcervo.ReadOnly = true;
            dgvAcervo.RowHeadersWidth = 51;
            dgvAcervo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAcervo.Size = new Size(442, 266);
            dgvAcervo.TabIndex = 13;
            dgvAcervo.CellClick += dgvAcervo_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            // 
            // AnoDePublicação
            // 
            AnoDePublicação.HeaderText = "Ano de Publicação";
            AnoDePublicação.Name = "AnoDePublicação";
            AnoDePublicação.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(78, 57);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(201, 23);
            txtPesquisar.TabIndex = 14;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(299, 416);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 19;
            btnRemover.Text = "Remover Livro";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(379, 416);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar Livro";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAlterarStatus
            // 
            btnAlterarStatus.Location = new Point(206, 416);
            btnAlterarStatus.Name = "btnAlterarStatus";
            btnAlterarStatus.Size = new Size(87, 23);
            btnAlterarStatus.TabIndex = 21;
            btnAlterarStatus.Text = "Alterar Status";
            btnAlterarStatus.UseVisualStyleBackColor = true;
            btnAlterarStatus.Click += btnAlterarStatus_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.Location = new Point(12, 445);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(442, 68);
            btnCadastro.TabIndex = 22;
            btnCadastro.Text = "Voltar ao Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
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
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(285, 65);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "Status:";
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Todos", "Disponível", "Emprestado" });
            cbxStatus.Location = new Point(333, 57);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(121, 23);
            cbxStatus.TabIndex = 25;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(285, 86);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(170, 23);
            btnConsultar.TabIndex = 26;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(13, 395);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(41, 15);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(59, 387);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(74, 23);
            txtTitulo.TabIndex = 29;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(139, 395);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 30;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(185, 387);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(74, 23);
            txtAutor.TabIndex = 34;
            // 
            // lblAnoDaPublicacao
            // 
            lblAnoDaPublicacao.AutoSize = true;
            lblAnoDaPublicacao.Location = new Point(265, 395);
            lblAnoDaPublicacao.Name = "lblAnoDaPublicacao";
            lblAnoDaPublicacao.Size = new Size(109, 15);
            lblAnoDaPublicacao.TabIndex = 35;
            lblAnoDaPublicacao.Text = "Ano da Publicação:";
            // 
            // txtAnoDaPublicacao
            // 
            txtAnoDaPublicacao.Location = new Point(380, 387);
            txtAnoDaPublicacao.Name = "txtAnoDaPublicacao";
            txtAnoDaPublicacao.Size = new Size(74, 23);
            txtAnoDaPublicacao.TabIndex = 36;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 523);
            Controls.Add(txtAnoDaPublicacao);
            Controls.Add(lblAnoDaPublicacao);
            Controls.Add(txtAutor);
            Controls.Add(lblAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(btnConsultar);
            Controls.Add(cbxStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCadastro);
            Controls.Add(btnAlterarStatus);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(txtPesquisar);
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
        private TextBox txtPesquisar;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnAlterarStatus;
        private Button btnCadastro;
        private Label lblPesquisar;
        private Label lblStatus;
        private ComboBox cbxStatus;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn AnoDePublicação;
        private DataGridViewTextBoxColumn Status;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblAutor;
        private TextBox txtAutor;
        private Label lblAnoDaPublicacao;
        private TextBox txtAnoDaPublicacao;
    }
}