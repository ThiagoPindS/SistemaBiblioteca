namespace Prova_POO_Abril_Ian_Pereira
{
    partial class Atencao
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
            lblAviso = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(12, 9);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(168, 15);
            lblAviso.TabIndex = 0;
            lblAviso.Text = "Livro cadastrado com sucesso!";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(129, 27);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Atencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 57);
            Controls.Add(btnOk);
            Controls.Add(lblAviso);
            Name = "Atencao";
            Text = "Atencao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblAviso;
        private Button btnOk;
    }
}