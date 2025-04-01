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
            // lblTelaDeConsulta
            // 
            lblTelaDeConsulta.AutoSize = true;
            lblTelaDeConsulta.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelaDeConsulta.Location = new Point(80, 12);
            lblTelaDeConsulta.Name = "lblTelaDeConsulta";
            lblTelaDeConsulta.Size = new Size(330, 54);
            lblTelaDeConsulta.TabIndex = 12;
            lblTelaDeConsulta.Text = "Tela de Consulta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 244);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(415, 264);
            dataGridView1.TabIndex = 13;
            // 
            // txtFTitulo
            // 
            txtFTitulo.Location = new Point(183, 135);
            txtFTitulo.Margin = new Padding(3, 4, 3, 4);
            txtFTitulo.Name = "txtFTitulo";
            txtFTitulo.Size = new Size(138, 27);
            txtFTitulo.TabIndex = 14;
            // 
            // cbxFStatus
            // 
            cbxFStatus.FormattingEnabled = true;
            cbxFStatus.Items.AddRange(new object[] { "Disponível", "Emprestado", "Todos" });
            cbxFStatus.Location = new Point(183, 185);
            cbxFStatus.Margin = new Padding(3, 4, 3, 4);
            cbxFStatus.Name = "cbxFStatus";
            cbxFStatus.Size = new Size(138, 28);
            cbxFStatus.TabIndex = 15;
            // 
            // lblFTitulo
            // 
            lblFTitulo.AutoSize = true;
            lblFTitulo.Location = new Point(120, 145);
            lblFTitulo.Name = "lblFTitulo";
            lblFTitulo.Size = new Size(47, 20);
            lblFTitulo.TabIndex = 16;
            lblFTitulo.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 189);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 17;
            label1.Text = "Status";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltro.Location = new Point(189, 84);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(76, 28);
            lblFiltro.TabIndex = 18;
            lblFiltro.Text = "Filtros:";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(161, 531);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(112, 31);
            btnRemover.TabIndex = 19;
            btnRemover.Text = "Remover Livro";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(39, 551);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar Livro";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(307, 551);
            btnStatus.Margin = new Padding(3, 4, 3, 4);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(99, 31);
            btnStatus.TabIndex = 21;
            btnStatus.Text = "Alterar Status";
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.Location = new Point(38, 608);
            btnCadastro.Margin = new Padding(3, 4, 3, 4);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(375, 91);
            btnCadastro.TabIndex = 22;
            btnCadastro.Text = "Voltar ao Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 719);
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
            Controls.Add(lblTelaDeConsulta);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Consulta";
            Text = "Consulta";
            Activated += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTelaDeConsulta;
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