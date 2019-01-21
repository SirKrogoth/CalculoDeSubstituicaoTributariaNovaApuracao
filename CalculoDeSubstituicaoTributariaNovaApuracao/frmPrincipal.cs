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

            valorPresumidoTotal = valorPresumidoTotal + Convert.ToDouble(txtICMSPresumido.Text);

            txtValorPresumido.Text = valorPresumidoTotal.ToString();

            //Adiciona linha no gridView
            dgvCompras.Rows.Add(item);

            txtQuantidade.Focus();
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

        
    }
}
