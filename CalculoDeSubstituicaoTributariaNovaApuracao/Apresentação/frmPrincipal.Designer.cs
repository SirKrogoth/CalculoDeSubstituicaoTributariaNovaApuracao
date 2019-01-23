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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gbVendas = new System.Windows.Forms.GroupBox();
            this.txtValorEfetivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.colQuantidadeVendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCSTUnitVendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAliquotaICMSSTVendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colICMSEfetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarVendas = new System.Windows.Forms.Button();
            this.txtICMSEfetivoVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAliquotaICMSSTVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBCSTUnitVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidadeVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).BeginInit();
            this.gbVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
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
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Location = new System.Drawing.Point(559, 44);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Estoque";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
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
            this.txtICMSPresumido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtICMSPresumido_MouseClick);
            this.txtICMSPresumido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtICMSPresumido_KeyDown);
            // 
            // txtAliquotaICMSST
            // 
            this.txtAliquotaICMSST.Location = new System.Drawing.Point(235, 46);
            this.txtAliquotaICMSST.Name = "txtAliquotaICMSST";
            this.txtAliquotaICMSST.Size = new System.Drawing.Size(100, 20);
            this.txtAliquotaICMSST.TabIndex = 3;
            this.txtAliquotaICMSST.Text = "0";
            this.txtAliquotaICMSST.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAliquotaICMSST_MouseClick);
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
            this.txtBCSTUnit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBCSTUnit_MouseClick);
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
            this.txtQuantidade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantidade_MouseClick);
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
            this.pcbLogotipo.Location = new System.Drawing.Point(688, 560);
            this.pcbLogotipo.Name = "pcbLogotipo";
            this.pcbLogotipo.Size = new System.Drawing.Size(100, 50);
            this.pcbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogotipo.TabIndex = 1;
            this.pcbLogotipo.TabStop = false;
            // 
            // gbVendas
            // 
            this.gbVendas.Controls.Add(this.txtValorEfetivo);
            this.gbVendas.Controls.Add(this.label10);
            this.gbVendas.Controls.Add(this.dgvVendas);
            this.gbVendas.Controls.Add(this.btnAdicionarVendas);
            this.gbVendas.Controls.Add(this.txtICMSEfetivoVenda);
            this.gbVendas.Controls.Add(this.label9);
            this.gbVendas.Controls.Add(this.txtAliquotaICMSSTVenda);
            this.gbVendas.Controls.Add(this.label8);
            this.gbVendas.Controls.Add(this.txtBCSTUnitVenda);
            this.gbVendas.Controls.Add(this.label7);
            this.gbVendas.Controls.Add(this.txtQuantidadeVenda);
            this.gbVendas.Controls.Add(this.label6);
            this.gbVendas.Location = new System.Drawing.Point(13, 274);
            this.gbVendas.Name = "gbVendas";
            this.gbVendas.Size = new System.Drawing.Size(775, 260);
            this.gbVendas.TabIndex = 2;
            this.gbVendas.TabStop = false;
            this.gbVendas.Text = "Vendas";
            // 
            // txtValorEfetivo
            // 
            this.txtValorEfetivo.Enabled = false;
            this.txtValorEfetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEfetivo.Location = new System.Drawing.Point(512, 229);
            this.txtValorEfetivo.Name = "txtValorEfetivo";
            this.txtValorEfetivo.Size = new System.Drawing.Size(122, 22);
            this.txtValorEfetivo.TabIndex = 12;
            this.txtValorEfetivo.Text = "0,00";
            this.txtValorEfetivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(405, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Valor Efetivo:";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantidadeVendas,
            this.colBCSTUnitVendas,
            this.colAliquotaICMSSTVendas,
            this.colICMSEfetivo});
            this.dgvVendas.Location = new System.Drawing.Point(38, 75);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(596, 142);
            this.dgvVendas.TabIndex = 9;
            // 
            // colQuantidadeVendas
            // 
            this.colQuantidadeVendas.HeaderText = "Quantidade";
            this.colQuantidadeVendas.Name = "colQuantidadeVendas";
            this.colQuantidadeVendas.ReadOnly = true;
            // 
            // colBCSTUnitVendas
            // 
            this.colBCSTUnitVendas.HeaderText = "BC ST Unit.";
            this.colBCSTUnitVendas.Name = "colBCSTUnitVendas";
            this.colBCSTUnitVendas.ReadOnly = true;
            this.colBCSTUnitVendas.Width = 150;
            // 
            // colAliquotaICMSSTVendas
            // 
            this.colAliquotaICMSSTVendas.HeaderText = "Alíquota ICMS ST";
            this.colAliquotaICMSSTVendas.Name = "colAliquotaICMSSTVendas";
            this.colAliquotaICMSSTVendas.ReadOnly = true;
            this.colAliquotaICMSSTVendas.Width = 150;
            // 
            // colICMSEfetivo
            // 
            this.colICMSEfetivo.HeaderText = "ICMS Efetivo";
            this.colICMSEfetivo.Name = "colICMSEfetivo";
            this.colICMSEfetivo.ReadOnly = true;
            this.colICMSEfetivo.Width = 150;
            // 
            // btnAdicionarVendas
            // 
            this.btnAdicionarVendas.Location = new System.Drawing.Point(478, 45);
            this.btnAdicionarVendas.Name = "btnAdicionarVendas";
            this.btnAdicionarVendas.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarVendas.TabIndex = 8;
            this.btnAdicionarVendas.Text = "Adicionar";
            this.btnAdicionarVendas.UseVisualStyleBackColor = true;
            this.btnAdicionarVendas.Click += new System.EventHandler(this.btnAdicionarVendas_Click);
            // 
            // txtICMSEfetivoVenda
            // 
            this.txtICMSEfetivoVenda.Location = new System.Drawing.Point(348, 48);
            this.txtICMSEfetivoVenda.Name = "txtICMSEfetivoVenda";
            this.txtICMSEfetivoVenda.Size = new System.Drawing.Size(94, 20);
            this.txtICMSEfetivoVenda.TabIndex = 7;
            this.txtICMSEfetivoVenda.Text = "0";
            this.txtICMSEfetivoVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtICMSEfetivoVenda_MouseClick);
            this.txtICMSEfetivoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtICMSEfetivoVenda_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "ICMS Efetivo";
            // 
            // txtAliquotaICMSSTVenda
            // 
            this.txtAliquotaICMSSTVenda.Location = new System.Drawing.Point(238, 48);
            this.txtAliquotaICMSSTVenda.Name = "txtAliquotaICMSSTVenda";
            this.txtAliquotaICMSSTVenda.Size = new System.Drawing.Size(97, 20);
            this.txtAliquotaICMSSTVenda.TabIndex = 5;
            this.txtAliquotaICMSSTVenda.Text = "0";
            this.txtAliquotaICMSSTVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAliquotaICMSSTVenda_MouseClick);
            this.txtAliquotaICMSSTVenda.TextChanged += new System.EventHandler(this.txtAliquotaICMSSTVenda_TextChanged);
            this.txtAliquotaICMSSTVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAliquotaICMSSTVenda_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Alíquota ICMS ST";
            // 
            // txtBCSTUnitVenda
            // 
            this.txtBCSTUnitVenda.Location = new System.Drawing.Point(132, 48);
            this.txtBCSTUnitVenda.Name = "txtBCSTUnitVenda";
            this.txtBCSTUnitVenda.Size = new System.Drawing.Size(97, 20);
            this.txtBCSTUnitVenda.TabIndex = 3;
            this.txtBCSTUnitVenda.Text = "0";
            this.txtBCSTUnitVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBCSTUnitVenda_MouseClick);
            this.txtBCSTUnitVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBCSTUnitVenda_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "BC ST Unit.";
            // 
            // txtQuantidadeVenda
            // 
            this.txtQuantidadeVenda.Location = new System.Drawing.Point(38, 48);
            this.txtQuantidadeVenda.Name = "txtQuantidadeVenda";
            this.txtQuantidadeVenda.Size = new System.Drawing.Size(72, 20);
            this.txtQuantidadeVenda.TabIndex = 1;
            this.txtQuantidadeVenda.Text = "0";
            this.txtQuantidadeVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantidadeVenda_MouseClick);
            this.txtQuantidadeVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidadeVenda_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantidade";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.gbVendas);
            this.Controls.Add(this.pcbLogotipo);
            this.Controls.Add(this.gbCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cálculo Substituição Tributária";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbCompras.ResumeLayout(false);
            this.gbCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).EndInit();
            this.gbVendas.ResumeLayout(false);
            this.gbVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
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
        private System.Windows.Forms.GroupBox gbVendas;
        private System.Windows.Forms.TextBox txtValorEfetivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btnAdicionarVendas;
        private System.Windows.Forms.TextBox txtICMSEfetivoVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAliquotaICMSSTVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBCSTUnitVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidadeVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCSTUnitVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAliquotaICMSSTVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colICMSEfetivo;
    }
}

