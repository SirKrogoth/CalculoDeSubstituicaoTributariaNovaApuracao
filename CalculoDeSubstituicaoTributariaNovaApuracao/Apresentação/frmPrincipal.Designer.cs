namespace CalculoDeSubstituicaoTributariaNovaApuracao
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gbCompras = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.txtValorPresumido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCSTUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAliquotaST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colICMSPresumido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtICMSPresumido = new System.Windows.Forms.TextBox();
            this.txtAliquotaICMSST = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBCSTUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbLogotipo = new System.Windows.Forms.PictureBox();
            this.gbCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompras
            // 
            this.gbCompras.Controls.Add(this.btn);
            this.gbCompras.Controls.Add(this.txtValorPresumido);
            this.gbCompras.Controls.Add(this.label5);
            this.gbCompras.Controls.Add(this.dgvCompras);
            this.gbCompras.Controls.Add(this.btnAdicionar);
            this.gbCompras.Controls.Add(this.label4);
            this.gbCompras.Controls.Add(this.txtICMSPresumido);
            this.gbCompras.Controls.Add(this.txtAliquotaICMSST);
            this.gbCompras.Controls.Add(this.label3);
            this.gbCompras.Controls.Add(this.txtBCSTUnit);
            this.gbCompras.Controls.Add(this.label2);
            this.gbCompras.Controls.Add(this.txtQuantidade);
            this.gbCompras.Controls.Add(this.label1);
            this.gbCompras.Location = new System.Drawing.Point(13, 13);
            this.gbCompras.Name = "gbCompras";
            this.gbCompras.Size = new System.Drawing.Size(775, 254);
            this.gbCompras.TabIndex = 0;
            this.gbCompras.TabStop = false;
            this.gbCompras.Text = "Compras";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(559, 44);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Estoque";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // txtValorPresumido
            // 
            this.txtValorPresumido.Enabled = false;
            this.txtValorPresumido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPresumido.Location = new System.Drawing.Point(512, 226);
            this.txtValorPresumido.Name = "txtValorPresumido";
            this.txtValorPresumido.Size = new System.Drawing.Size(122, 22);
            this.txtValorPresumido.TabIndex = 10;
            this.txtValorPresumido.Text = "0,00";
            this.txtValorPresumido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(375, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Presumido: ";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantidade,
            this.colBCSTUnit,
            this.colAliquotaST,
            this.colICMSPresumido});
            this.dgvCompras.Location = new System.Drawing.Point(35, 73);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(599, 147);
            this.dgvCompras.TabIndex = 8;
            // 
            // colQuantidade
            // 
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            // 
            // colBCSTUnit
            // 
            this.colBCSTUnit.HeaderText = "BC ST Unit.";
            this.colBCSTUnit.Name = "colBCSTUnit";
            this.colBCSTUnit.ReadOnly = true;
            this.colBCSTUnit.Width = 150;
            // 
            // colAliquotaST
            // 
            this.colAliquotaST.HeaderText = "Alíquota ICMS ST";
            this.colAliquotaST.Name = "colAliquotaST";
            this.colAliquotaST.ReadOnly = true;
            this.colAliquotaST.Width = 150;
            // 
            // colICMSPresumido
            // 
            this.colICMSPresumido.HeaderText = "ICMS Presumido";
            this.colICMSPresumido.Name = "colICMSPresumido";
            this.colICMSPresumido.ReadOnly = true;
            this.colICMSPresumido.Width = 150;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Location = new System.Drawing.Point(478, 44);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ICMS Presumido";
            // 
            // txtICMSPresumido
            // 
            this.txtICMSPresumido.Location = new System.Drawing.Point(342, 46);
            this.txtICMSPresumido.Name = "txtICMSPresumido";
            this.txtICMSPresumido.Size = new System.Drawing.Size(100, 20);
            this.txtICMSPresumido.TabIndex = 4;
            this.txtICMSPresumido.Text = "0";
            this.txtICMSPresumido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtICMSPresumido_KeyDown);
            // 
            // txtAliquotaICMSST
            // 
            this.txtAliquotaICMSST.Location = new System.Drawing.Point(235, 46);
            this.txtAliquotaICMSST.Name = "txtAliquotaICMSST";
            this.txtAliquotaICMSST.Size = new System.Drawing.Size(100, 20);
            this.txtAliquotaICMSST.TabIndex = 3;
            this.txtAliquotaICMSST.Text = "0";
            this.txtAliquotaICMSST.TextChanged += new System.EventHandler(this.txtAliquotaICMSST_TextChanged);
            this.txtAliquotaICMSST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAliquotaICMSST_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alíquota ICMS ST";
            // 
            // txtBCSTUnit
            // 
            this.txtBCSTUnit.Location = new System.Drawing.Point(129, 46);
            this.txtBCSTUnit.Name = "txtBCSTUnit";
            this.txtBCSTUnit.Size = new System.Drawing.Size(100, 20);
            this.txtBCSTUnit.TabIndex = 2;
            this.txtBCSTUnit.Text = "0";
            this.txtBCSTUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBCSTUnit_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BC ST Unit.";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(35, 46);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(75, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtQuantidade_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade";
            // 
            // pcbLogotipo
            // 
            this.pcbLogotipo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogotipo.Image")));
            this.pcbLogotipo.Location = new System.Drawing.Point(688, 540);
            this.pcbLogotipo.Name = "pcbLogotipo";
            this.pcbLogotipo.Size = new System.Drawing.Size(100, 50);
            this.pcbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogotipo.TabIndex = 1;
            this.pcbLogotipo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.pcbLogotipo);
            this.Controls.Add(this.gbCompras);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cálculo Substituição Tributária";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbCompras.ResumeLayout(false);
            this.gbCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCSTUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAliquotaST;
        private System.Windows.Forms.DataGridViewTextBoxColumn colICMSPresumido;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtICMSPresumido;
        private System.Windows.Forms.TextBox txtAliquotaICMSST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBCSTUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorPresumido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pcbLogotipo;
    }
}

