namespace Prova_POO_Abril_Ian_Pereira
{
    partial class Cadastrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAno = new TextBox();
            cbxStatus = new ComboBox();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblAnoDaPublicacao = new Label();
            lblStatus = new Label();
            btnLimpar = new Button();
            btnCadastrar = new Button();
            btnConsulta = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(125, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(447, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(125, 42);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(447, 23);
            txtAutor.TabIndex = 1;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(125, 71);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(447, 23);
            txtAno.TabIndex = 2;
            txtAno.KeyPress += txtAno_KeyPress;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Disponível", "Emprestado" });
            cbxStatus.Location = new Point(125, 100);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(447, 23);
            cbxStatus.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(41, 15);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(10, 45);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblAnoDaPublicacao
            // 
            lblAnoDaPublicacao.AutoSize = true;
            lblAnoDaPublicacao.Location = new Point(10, 74);
            lblAnoDaPublicacao.Name = "lblAnoDaPublicacao";
            lblAnoDaPublicacao.Size = new Size(109, 15);
            lblAnoDaPublicacao.TabIndex = 6;
            lblAnoDaPublicacao.Text = "Ano da Publicação:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 103);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(470, 129);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(102, 23);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(362, 129);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(102, 23);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar Livro";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(451, 426);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(121, 23);
            btnConsulta.TabIndex = 38;
            btnConsulta.Text = "Ir Para Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(584, 461);
            Controls.Add(btnConsulta);
            Controls.Add(btnCadastrar);
            Controls.Add(btnLimpar);
            Controls.Add(lblStatus);
            Controls.Add(lblAnoDaPublicacao);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(cbxStatus);
            Controls.Add(txtAno);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão Biblioteca | Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAno;
        private ComboBox cbxStatus;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblAnoDaPublicacao;
        private Label lblStatus;
        private Button btnCadastrar;
        private Button btnLimpar;
        private Button btnConsulta;
    }
}
