using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultApps.Windows
{
    public partial class FrmGestaoProdutos : Form
    {
        public FrmGestaoProdutos()
        {
            InitializeComponent();
        }

        private void bntNovoProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            int Estoque = int.Parse(txtEstoque.Text);
            produto.Nome = txtNome.Text;
            produto.Preco = txtPreco.Text;
            produto.Url = txtUrl.Text;
            produto.QuantidadeEmEstoque = Estoque;
            produto.Status = (StatusEnum)cmbStatus.SelectedIndex;

            var produtoRepository = new ProdutosRepository();

          

            }
        }
    }
}
