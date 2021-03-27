
namespace Exercicio10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_fraseOriginal = new System.Windows.Forms.TextBox();
            this.TB_fraseInvertida = new System.Windows.Forms.TextBox();
            this.BT_processar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frase Original";
            // 
            // TB_fraseOriginal
            // 
            this.TB_fraseOriginal.Location = new System.Drawing.Point(12, 72);
            this.TB_fraseOriginal.Name = "TB_fraseOriginal";
            this.TB_fraseOriginal.Size = new System.Drawing.Size(333, 20);
            this.TB_fraseOriginal.TabIndex = 2;
            // 
            // TB_fraseInvertida
            // 
            this.TB_fraseInvertida.Location = new System.Drawing.Point(12, 157);
            this.TB_fraseInvertida.Name = "TB_fraseInvertida";
            this.TB_fraseInvertida.Size = new System.Drawing.Size(333, 20);
            this.TB_fraseInvertida.TabIndex = 4;
            // 
            // BT_processar
            // 
            this.BT_processar.Location = new System.Drawing.Point(49, 254);
            this.BT_processar.Name = "BT_processar";
            this.BT_processar.Size = new System.Drawing.Size(255, 23);
            this.BT_processar.TabIndex = 5;
            this.BT_processar.Text = "Processar";
            this.BT_processar.UseVisualStyleBackColor = true;
            this.BT_processar.Click += new System.EventHandler(this.BT_processar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frase Invertida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_processar);
            this.Controls.Add(this.TB_fraseInvertida);
            this.Controls.Add(this.TB_fraseOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inverter uma frase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_fraseOriginal;
        private System.Windows.Forms.TextBox TB_fraseInvertida;
        private System.Windows.Forms.Button BT_processar;
        private System.Windows.Forms.Label label3;
    }
}

