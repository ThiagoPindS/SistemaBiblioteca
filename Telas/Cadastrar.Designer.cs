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
            btnCadastrarLivro = new Button();
            btnLimparCampos = new Button();
            btnConsultaDeLivros = new Button();
            lblTelaDeCadastro = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(136, 68);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(168, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(136, 93);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(168, 23);
            txtAutor.TabIndex = 1;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(136, 119);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(168, 23);
            txtAno.TabIndex = 2;
            txtAno.KeyPress += txtAno_KeyPress;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Disponível", "Emprestado" });
            cbxStatus.Location = new Point(136, 146);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(168, 23);
            cbxStatus.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 74);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(41, 15);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(11, 98);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblAnoDaPublicacao
            // 
            lblAnoDaPublicacao.AutoSize = true;
            lblAnoDaPublicacao.Location = new Point(11, 124);
            lblAnoDaPublicacao.Name = "lblAnoDaPublicacao";
            lblAnoDaPublicacao.Size = new Size(109, 15);
            lblAnoDaPublicacao.TabIndex = 6;
            lblAnoDaPublicacao.Text = "Ano da Publicação:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(11, 152);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarLivro.Location = new Point(10, 182);
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(222, 56);
            btnCadastrarLivro.TabIndex = 8;
            btnCadastrarLivro.Text = "Cadastrar Livro";
            btnCadastrarLivro.UseVisualStyleBackColor = true;
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Location = new Point(238, 182);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(65, 56);
            btnLimparCampos.TabIndex = 9;
            btnLimparCampos.Text = "Limpar Campos";
            btnLimparCampos.UseVisualStyleBackColor = true;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // btnConsultaDeLivros
            // 
            btnConsultaDeLivros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultaDeLivros.Location = new Point(10, 253);
            btnConsultaDeLivros.Name = "btnConsultaDeLivros";
            btnConsultaDeLivros.Size = new Size(291, 56);
            btnConsultaDeLivros.TabIndex = 10;
            btnConsultaDeLivros.Text = "ConsultaDeLivros";
            btnConsultaDeLivros.UseVisualStyleBackColor = true;
            btnConsultaDeLivros.Click += btnConsulta_Click;
            // 
            // lblTelaDeCadastro
            // 
            lblTelaDeCadastro.AutoSize = true;
            lblTelaDeCadastro.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelaDeCadastro.Location = new Point(21, 9);
            lblTelaDeCadastro.Name = "lblTelaDeCadastro";
            lblTelaDeCadastro.Size = new Size(267, 45);
            lblTelaDeCadastro.TabIndex = 11;
            lblTelaDeCadastro.Text = "Tela de Cadastro";
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 318);
            Controls.Add(lblTelaDeCadastro);
            Controls.Add(btnConsultaDeLivros);
            Controls.Add(btnLimparCampos);
            Controls.Add(btnCadastrarLivro);
            Controls.Add(lblStatus);
            Controls.Add(lblAnoDaPublicacao);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(cbxStatus);
            Controls.Add(txtAno);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "Cadastrar";
            Text = "BiblioSystem";
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
        private Button btnCadastrarLivro;
        private Button btnLimparCampos;
        private Button btnConsultaDeLivros;
        private Label lblTelaDeCadastro;
    }
}
