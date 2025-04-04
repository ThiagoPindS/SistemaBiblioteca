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
            txtTitulo = new TextBox();
            btnRemover = new Button();
            btnEditar = new Button();
            btnAlterarStatus = new Button();
            btnCadastro = new Button();
            lblTitulo = new Label();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            btnConsultar = new Button();
            ID = new DataGridViewTextBoxColumn();
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
            dgvAcervo.Columns.AddRange(new DataGridViewColumn[] { ID });
            dgvAcervo.Location = new Point(12, 115);
            dgvAcervo.Name = "dgvAcervo";
            dgvAcervo.ReadOnly = true;
            dgvAcervo.RowHeadersWidth = 51;
            dgvAcervo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcervo.Size = new Size(442, 266);
            dgvAcervo.TabIndex = 13;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(59, 57);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(220, 23);
            txtTitulo.TabIndex = 14;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(286, 387);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 19;
            btnRemover.Text = "Remover Livro";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(205, 387);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar Livro";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAlterarStatus
            // 
            btnAlterarStatus.Location = new Point(367, 387);
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
            btnCadastro.Location = new Point(12, 416);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(442, 68);
            btnCadastro.TabIndex = 22;
            btnCadastro.Text = "Voltar ao Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(41, 15);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Titulo:";
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
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 497);
            Controls.Add(btnConsultar);
            Controls.Add(cbxStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblTitulo);
            Controls.Add(btnCadastro);
            Controls.Add(btnAlterarStatus);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(txtTitulo);
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
        private TextBox txtTitulo;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnAlterarStatus;
        private Button btnCadastro;
        private Label lblTitulo;
        private Label lblStatus;
        private ComboBox cbxStatus;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn ID;
    }
}