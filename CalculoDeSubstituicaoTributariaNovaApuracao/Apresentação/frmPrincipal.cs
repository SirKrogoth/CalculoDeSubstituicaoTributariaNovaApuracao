using CalculoDeSubstituicaoTributariaNovaApuracao.Apresentação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeSubstituicaoTributariaNovaApuracao
{
    public partial class frmPrincipal : Form
    {
        public double valorPresumidoTotal = 0;
        public double valorEfetivoTotal = 0;
        public static double valorEstoque = 0;


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public frmPrincipal()
        {
            InitializeComponent();            
        }
        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarColunaGridST();
        }

        public void AdicionarColunaGridST()
        {
            //Criando instancia da linha no grid
            DataGridViewRow item = new DataGridViewRow();
            item.CreateCells(dgvCompras);

            item.Cells[0].Value = txtQuantidade.Text;
            item.Cells[1].Value = txtBCSTUnit.Text;
            item.Cells[2].Value = txtAliquotaICMSST.Text;
            item.Cells[3].Value = txtICMSPresumido.Text;

            valorPresumidoTotal = valorPresumidoTotal + Convert.ToDouble(txtICMSPresumido.Text) + valorEstoque;

            txtValorPresumido.Text = valorPresumidoTotal.ToString();

            //Adiciona linha no gridView
            dgvCompras.Rows.Add(item);

            txtQuantidade.Focus();
            txtQuantidade.SelectAll();
        }

        private void txtAliquotaICMSST_TextChanged(object sender, EventArgs e)
        {
            if (txtAliquotaICMSST.Text == "")
                txtAliquotaICMSST.Text = "0";
            else
                txtICMSPresumido.Text = ((Convert.ToDouble(txtQuantidade.Text) * Convert.ToDouble(txtBCSTUnit.Text)) * ((Convert.ToDouble(txtAliquotaICMSST.Text)) / 100)).ToString();
        }

        private void txtAliquotaICMSST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                AdicionarColunaGridST();
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
                
        }

        public void LimparValorPresumido()
        {
            txtQuantidade.Text = "0";
            txtBCSTUnit.Text = "0";
            txtAliquotaICMSST.Text = "0";
            txtICMSPresumido.Text = "0";
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQuantidade_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtBCSTUnit.Focus();
                txtBCSTUnit.SelectAll();
            }                
        }

        private void txtBCSTUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtAliquotaICMSST.Focus();
                txtAliquotaICMSST.SelectAll();
            }
                
        }

        private void txtICMSPresumido_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
                AdicionarColunaGridST();
        }

        private void txtQuantidade_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtQuantidade.SelectAll();
        }

        private void txtBCSTUnit_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtBCSTUnit.SelectAll();
        }

        private void txtAliquotaICMSST_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtAliquotaICMSST.SelectAll();
        }

        private void txtICMSPresumido_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtICMSPresumido.SelectAll();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmParcelaST frmParcela = new frmParcelaST();

            frmParcela.ShowDialog();
        }

        private void btnAdicionarVendas_Click(object sender, EventArgs e)
        {
            AdicionarColunasSTVendas();
        }

        public void AdicionarColunasSTVendas()
        {
            //Criando instancia da linha no grid
            DataGridViewRow item = new DataGridViewRow();
            item.CreateCells(dgvVendas);

            item.Cells[0].Value = txtQuantidadeVenda.Text;
            item.Cells[1].Value = txtBCSTUnitVenda.Text;
            item.Cells[2].Value = txtAliquotaICMSSTVenda.Text;
            item.Cells[3].Value = txtICMSEfetivoVenda.Text;

            valorEfetivoTotal = valorEfetivoTotal + Convert.ToDouble(txtICMSEfetivoVenda.Text);

            txtValorEfetivo.Text = valorEfetivoTotal.ToString();

            //Adiciona linha no gridView
            dgvVendas.Rows.Add(item);

            txtQuantidadeVenda.Focus();
            txtQuantidadeVenda.SelectAll();
        }

        private void txtAliquotaICMSSTVenda_TextChanged(object sender, EventArgs e)
        {
            if (txtAliquotaICMSSTVenda.Text == "")
                txtAliquotaICMSSTVenda.Text = "0";
            else
                txtICMSEfetivoVenda.Text = ((Convert.ToDouble(txtQuantidadeVenda.Text) * Convert.ToDouble(txtBCSTUnitVenda.Text)) * ((Convert.ToDouble(txtAliquotaICMSSTVenda.Text)) / 100)).ToString();
        }

        private void txtQuantidadeVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtBCSTUnitVenda.Focus();
                txtBCSTUnitVenda.SelectAll();
            }
        }

        private void txtBCSTUnitVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtAliquotaICMSSTVenda.Focus();
                txtAliquotaICMSSTVenda.SelectAll();
            }
        }

        private void txtAliquotaICMSSTVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                AdicionarColunasSTVendas();
                txtQuantidadeVenda.Focus();
                txtQuantidadeVenda.SelectAll();
            }
        }

        private void txtICMSEfetivoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                AdicionarColunasSTVendas();
        }

        private void txtQuantidadeVenda_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtQuantidadeVenda.SelectAll();
        }

        private void txtBCSTUnitVenda_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtBCSTUnitVenda.SelectAll();
        }

        private void txtAliquotaICMSSTVenda_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtAliquotaICMSSTVenda.SelectAll();
        }

        private void txtICMSEfetivoVenda_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
                txtICMSEfetivoVenda.SelectAll();
        }
    }
}
