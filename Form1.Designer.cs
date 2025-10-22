namespace ex1Lista
{
    partial class Form1
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btmAdd = new System.Windows.Forms.Button();
            this.btmDeletar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(21, 28);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(250, 20);
            this.txtBox.TabIndex = 0;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btmAdd
            // 
            this.btmAdd.Location = new System.Drawing.Point(277, 26);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(98, 23);
            this.btmAdd.TabIndex = 1;
            this.btmAdd.Text = "adicionar";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmDeletar
            // 
            this.btmDeletar.Location = new System.Drawing.Point(21, 403);
            this.btmDeletar.Name = "btmDeletar";
            this.btmDeletar.Size = new System.Drawing.Size(354, 23);
            this.btmDeletar.TabIndex = 2;
            this.btmDeletar.Text = "deletar";
            this.btmDeletar.UseVisualStyleBackColor = true;
            this.btmDeletar.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 329);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btmDeletar);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.Button btmDeletar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

