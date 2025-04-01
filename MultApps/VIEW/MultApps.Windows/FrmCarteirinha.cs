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
    public partial class FrmCarteirinha : Form
    {
        public FrmCarteirinha()
        {
            InitializeComponent();
        }

        public string OfuscarCPF(string cpf)
        {
            if (cpf.Length != 11)
                return "CPF inválido";

            string parte1 = cpf.Substring(3, 3);
            string parte2 = cpf.Substring(6, 3);

            return $"***.{parte1}.{parte2}.***";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Cpf = (txtCpf.Text);


            var data = dtpNascimento.Value.ToString();
            DateTime dataNascimento = DateTime.Parse(data);
            DateTime dataAtual = DateTime.Now;

            int idadeRecebida = dataAtual.Year - dataNascimento.Year;
            string Idade = idadeRecebida.ToString();


            lblNome.Text = "Nome:" + Nome;
            lblCpf.Text = "Cpf: " + OfuscarCPF(Cpf);
            lblIdade.Text = "Idade: " + Idade;

            panel1.Visible = true;

            if (idadeRecebida >= 60)
            {
                panel1.BackColor = Color.Green;
                pcbImagem.Load(ImcImagem.Idoso);
            }
            else if (idadeRecebida >= 19)
            {
                panel1.BackColor = Color.Purple;
                pcbImagem.Load(ImcImagem.Adulto);
            }
            else if (idadeRecebida >= 17)
            {
                panel1.BackColor = Color.Yellow;
                pcbImagem.Load(ImcImagem.jovem);
            }
            else if (idadeRecebida >= 12)
            {
                panel1.BackColor = Color.Blue;
                pcbImagem.Load(ImcImagem.crianca);
            }
        }
    }
}
