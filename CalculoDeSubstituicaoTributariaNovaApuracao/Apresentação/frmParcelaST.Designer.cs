namespace CalculoDeSubstituicaoTributariaNovaApuracao.Apresentação
{
    partial class frmParcelaST
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorTotalProdutosST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParcelaST = new System.Windows.Forms.TextBox();
            this.tbnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor total de produtos ST";
            // 
            // txtValorTotalProdutosST
            // 
            this.txtValorTotalProdutosST.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalProdutosST.ForeColor = System.Drawing.Color.Blue;
            this.txtValorTotalProdutosST.Location = new System.Drawing.Point(28, 41);
            this.txtValorTotalProdutosST.Name = "txtValorTotalProdutosST";
            this.txtValorTotalProdutosST.Size = new System.Drawing.Size(327, 62);
            this.txtValorTotalProdutosST.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor da Parcela";
            // 
            // txtParcelaST
            // 
            this.txtParcelaST.Enabled = false;
            this.txtParcelaST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcelaST.ForeColor = System.Drawing.Color.Blue;
            this.txtParcelaST.Location = new System.Drawing.Point(31, 158);
            this.txtParcelaST.Name = "txtParcelaST";
            this.txtParcelaST.Size = new System.Drawing.Size(324, 31);
            this.txtParcelaST.TabIndex = 3;
            // 
            // tbnSalvar
            // 
            this.tbnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSalvar.Location = new System.Drawing.Point(139, 220);
            this.tbnSalvar.Name = "tbnSalvar";
            this.tbnSalvar.Size = new System.Drawing.Size(126, 44);
            this.tbnSalvar.TabIndex = 4;
            this.tbnSalvar.Text = "Salvar";
            this.tbnSalvar.UseVisualStyleBackColor = true;
            this.tbnSalvar.Click += new System.EventHandler(this.tbnSalvar_Click);
            // 
            // frmParcelaST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 294);
            this.Controls.Add(this.tbnSalvar);
            this.Controls.Add(this.txtParcelaST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorTotalProdutosST);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmParcelaST";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcela ST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorTotalProdutosST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParcelaST;
        private System.Windows.Forms.Button tbnSalvar;
    }
}