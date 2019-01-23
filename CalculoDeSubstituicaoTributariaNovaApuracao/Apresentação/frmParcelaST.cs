using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeSubstituicaoTributariaNovaApuracao.Apresentação
{
    public partial class frmParcelaST : Form
    {
        public frmParcelaST()
        {
            InitializeComponent();
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValorTotalProdutosST.Text.Equals("0") || txtValorTotalProdutosST.Text.Equals(""))
                MessageBox.Show("Por Favor, informe um valor válido para o crédito do estoque.");
            else
            {
                //fp.Tag = txtParcelaST.Text;
                frmPrincipal.valorEstoque = Convert.ToDouble(txtParcelaST.Text);
            }
        }

        public void SalvarParcela()
        {
            txtParcelaST.Text = string.Format("{0:f}", (Convert.ToDouble(txtValorTotalProdutosST.Text) / 6));
        }

        private void txtValorTotalProdutosST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                SalvarParcela();
        }
    }
}
