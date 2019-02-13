namespace EditorDeTexto
{
    partial class EditorDeTexto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoEditorDeTexto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoEditorDeTexto
            // 
            this.textoEditorDeTexto.Location = new System.Drawing.Point(-1, 0);
            this.textoEditorDeTexto.Multiline = true;
            this.textoEditorDeTexto.Name = "textoEditorDeTexto";
            this.textoEditorDeTexto.Size = new System.Drawing.Size(1122, 657);
            this.textoEditorDeTexto.TabIndex = 0;
            this.textoEditorDeTexto.TextChanged += new System.EventHandler(this.textoEditorDeTexto_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditorDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 758);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoEditorDeTexto);
            this.Name = "EditorDeTexto";
            this.Text = "Editor De Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoEditorDeTexto;
        private System.Windows.Forms.Button button1;
    }
}

