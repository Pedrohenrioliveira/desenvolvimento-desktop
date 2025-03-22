using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmSistemaDePedidos : Form
    {
        public FrmSistemaDePedidos()
        {
            InitializeComponent();
        }

        private List<PedidoItem> itensPedido = new List<PedidoItem>();

        public class PedidoItem
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }

            public PedidoItem(string nome, int quantidade, decimal preco)
            {
                Nome = nome;
                Quantidade = quantidade;
                Preco = preco;
            }

            public override string ToString()
            {
                return $"{Nome} (x{Quantidade}) - R$ {Preco * Quantidade:F2}";
            }
        }

        private decimal CalcularTotal()
        {
            return itensPedido.Sum(item => item.Preco * item.Quantidade);
        }

        private void AtualizarTotal()
        {
            lblTotal.Text = $"Total: R$ {CalcularTotal():F2}";
        }

        private void AdicionarItem(PedidoItem item)
        {
            itensPedido.Add(item);
            listBoxPedidos.Items.Add(item);
            AtualizarTotal();
            MessageBox.Show($"Item Adicionado: {item}");
        }

        private void btnPequeno_Click(object sender, EventArgs e)
        {
            AdicionarItem(new PedidoItem("Açaí Pequeno (300ml)", 1, 15.00m));
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            AdicionarItem(new PedidoItem("Açaí Médio (500ml)", 1, 20.00m));
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            AdicionarItem(new PedidoItem("Açaí Grande (700ml)", 1, 25.00m));
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            AdicionarItem(new PedidoItem("Açaí Família (1L)", 1, 35.00m));
        }

        private void AdicionarComplemento(string nome, NumericUpDown numericUpDown, decimal preco)
        {
            int quantidade = (int)numericUpDown.Value;
            if (quantidade > 0)
            {
                AdicionarItem(new PedidoItem(nome, quantidade, preco));
            }
        }

        private void button1_Click(object sender, EventArgs e) => AdicionarComplemento("Granola", numericUpDown1, 2.00m);
        private void button2_Click(object sender, EventArgs e) => AdicionarComplemento("Banana", numericUpDown2, 2.50m);
        private void button3_Click(object sender, EventArgs e) => AdicionarComplemento("Morango", numericUpDown3, 3.00m);
        private void button4_Click(object sender, EventArgs e) => AdicionarComplemento("Leite Condensado", numericUpDown4, 3.00m);
        private void button5_Click(object sender, EventArgs e) => AdicionarComplemento("Paçoca", numericUpDown5, 3.00m);
        private void button6_Click(object sender, EventArgs e) => AdicionarComplemento("Kiwi", numericUpDown6, 3.00m);
        private void button7_Click(object sender, EventArgs e) => AdicionarItem(new PedidoItem("C. Chocolate", 1, 1.00m));
        private void button8_Click(object sender, EventArgs e) => AdicionarItem(new PedidoItem("C. Blue Ice", 1, 1.00m));
        private void button9_Click(object sender, EventArgs e) => AdicionarItem(new PedidoItem("C. Morango", 1, 1.00m));
        private void button10_Click(object sender, EventArgs e) => AdicionarItem(new PedidoItem("C. Leite Condensado", 1, 1.00m));

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem != null)
            {
                PedidoItem itemSelecionado = listBoxPedidos.SelectedItem as PedidoItem;
                if (itemSelecionado != null)
                {
                    itensPedido.Remove(itemSelecionado);
                    listBoxPedidos.Items.Remove(itemSelecionado);
                    AtualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            decimal total = CalcularTotal();
            lblTotal.Text = $"Total do Pedido: R$ {total:F2}";
            lblTotal.Visible = true;
        }
    }
}

