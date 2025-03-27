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
            lblPagina = new Label();
            dataGridView1 = new DataGridView();
            txtFTitulo = new TextBox();
            cbxFStatus = new ComboBox();
            lblFTitulo = new Label();
            label1 = new Label();
            lblFiltro = new Label();
            btnRemover = new Button();
            btnEditar = new Button();
            btnStatus = new Button();
            btnCadastro = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagina.Location = new Point(70, 9);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(264, 45);
            lblPagina.TabIndex = 12;
            lblPagina.Text = "Tela de Consulta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 198);
            dataGridView1.TabIndex = 13;
            // 
            // txtFTitulo
            // 
            txtFTitulo.Location = new Point(160, 101);
            txtFTitulo.Name = "txtFTitulo";
            txtFTitulo.Size = new Size(121, 23);
            txtFTitulo.TabIndex = 14;
            // 
            // cbxFStatus
            // 
            cbxFStatus.FormattingEnabled = true;
            cbxFStatus.Items.AddRange(new object[] { "Disponível", "Emprestado", "Todos" });
            cbxFStatus.Location = new Point(160, 139);
            cbxFStatus.Name = "cbxFStatus";
            cbxFStatus.Size = new Size(121, 23);
            cbxFStatus.TabIndex = 15;
            // 
            // lblFTitulo
            // 
            lblFTitulo.AutoSize = true;
            lblFTitulo.Location = new Point(105, 109);
            lblFTitulo.Name = "lblFTitulo";
            lblFTitulo.Size = new Size(37, 15);
            lblFTitulo.TabIndex = 16;
            lblFTitulo.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 142);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 17;
            label1.Text = "Status";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltro.Location = new Point(165, 63);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(61, 21);
            lblFiltro.TabIndex = 18;
            lblFiltro.Text = "Filtros:";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(141, 398);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(98, 23);
            btnRemover.TabIndex = 19;
            btnRemover.Text = "Remover Livro";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(34, 413);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar Livro";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(269, 413);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(87, 23);
            btnStatus.TabIndex = 21;
            btnStatus.Text = "Alterar Status";
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.Location = new Point(33, 456);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(328, 68);
            btnCadastro.TabIndex = 22;
            btnCadastro.Text = "Voltar ao Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 539);
            Controls.Add(btnCadastro);
            Controls.Add(btnStatus);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(lblFiltro);
            Controls.Add(label1);
            Controls.Add(lblFTitulo);
            Controls.Add(cbxFStatus);
            Controls.Add(txtFTitulo);
            Controls.Add(dataGridView1);
            Controls.Add(lblPagina);
            Name = "Consulta";
            Text = "Consulta";
            Activated += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagina;
        private DataGridView dataGridView1;
        private TextBox txtFTitulo;
        private ComboBox cbxFStatus;
        private Label lblFTitulo;
        private Label label1;
        private Label lblFiltro;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnStatus;
        private Button btnCadastro;
    }
}