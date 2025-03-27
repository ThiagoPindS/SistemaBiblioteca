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
            lblAno = new Label();
            lblStatus = new Label();
            btnCadastra = new Button();
            btnLimpa = new Button();
            btnConsulta = new Button();
            lblPagina = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(162, 116);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(162, 174);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(125, 23);
            txtAutor.TabIndex = 1;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(162, 237);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(125, 23);
            txtAno.TabIndex = 2;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Disponível", "Emprestado" });
            cbxStatus.Location = new Point(162, 293);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(125, 23);
            cbxStatus.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(116, 116);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(116, 177);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(47, 240);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(109, 15);
            lblAno.TabIndex = 6;
            lblAno.Text = "Ano da Publicação:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(116, 296);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // btnCadastra
            // 
            btnCadastra.Location = new Point(24, 352);
            btnCadastra.Name = "btnCadastra";
            btnCadastra.Size = new Size(132, 56);
            btnCadastra.TabIndex = 8;
            btnCadastra.Text = "Cadastrar Livro";
            btnCadastra.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            btnLimpa.Location = new Point(214, 352);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(138, 56);
            btnLimpa.TabIndex = 9;
            btnLimpa.Text = "Limpar Campos";
            btnLimpa.UseVisualStyleBackColor = true;
            btnLimpa.Click += btnLimpa_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsulta.Location = new Point(24, 442);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(328, 68);
            btnConsulta.TabIndex = 10;
            btnConsulta.Text = "Ir para Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagina.Location = new Point(64, 18);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(267, 45);
            lblPagina.TabIndex = 11;
            lblPagina.Text = "Tela de Cadastro";
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 539);
            Controls.Add(lblPagina);
            Controls.Add(btnConsulta);
            Controls.Add(btnLimpa);
            Controls.Add(btnCadastra);
            Controls.Add(lblStatus);
            Controls.Add(lblAno);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(cbxStatus);
            Controls.Add(txtAno);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "Cadastrar";
            Text = "Form1";
            Activated += Cadastrar_Load_1;
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
        private Label lblAno;
        private Label lblStatus;
        private Button btnCadastra;
        private Button btnLimpa;
        private Button btnConsulta;
        private Label lblPagina;
    }
}
