namespace dream_game
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxAvaliacao = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxTamanho = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDesenvolvedor = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(504, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(129, 35);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(254, 20);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Avaliação";
            // 
            // maskedTextBoxAvaliacao
            // 
            this.maskedTextBoxAvaliacao.Location = new System.Drawing.Point(129, 61);
            this.maskedTextBoxAvaliacao.Mask = "00";
            this.maskedTextBoxAvaliacao.Name = "maskedTextBoxAvaliacao";
            this.maskedTextBoxAvaliacao.Size = new System.Drawing.Size(44, 20);
            this.maskedTextBoxAvaliacao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tamanho";
            // 
            // maskedTextBoxTamanho
            // 
            this.maskedTextBoxTamanho.Location = new System.Drawing.Point(129, 87);
            this.maskedTextBoxTamanho.Mask = "000GB";
            this.maskedTextBoxTamanho.Name = "maskedTextBoxTamanho";
            this.maskedTextBoxTamanho.Size = new System.Drawing.Size(44, 20);
            this.maskedTextBoxTamanho.TabIndex = 6;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(129, 113);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(254, 198);
            this.richTextBoxDescricao.TabIndex = 7;
            this.richTextBoxDescricao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(129, 317);
            this.maskedTextBoxValor.Mask = "$000.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(57, 20);
            this.maskedTextBoxValor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desenvolvedor";
            // 
            // textBoxDesenvolvedor
            // 
            this.textBoxDesenvolvedor.Location = new System.Drawing.Point(129, 343);
            this.textBoxDesenvolvedor.Name = "textBoxDesenvolvedor";
            this.textBoxDesenvolvedor.Size = new System.Drawing.Size(254, 20);
            this.textBoxDesenvolvedor.TabIndex = 12;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(129, 369);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(254, 20);
            this.textBoxGenero.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gênero";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "Limpar campo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.textBoxDesenvolvedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.maskedTextBoxTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxAvaliacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAvaliacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTamanho;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDesenvolvedor;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

