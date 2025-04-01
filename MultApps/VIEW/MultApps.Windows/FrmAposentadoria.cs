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
    public partial class FrmAposentadoria : Form
    {
        public FrmAposentadoria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var data = dtpNascimento.Value.ToString();
            DateTime dataNascimento = DateTime.Parse(data);
            DateTime dataAtual = DateTime.Now;

            label3.Visible = true;

            int idade = dataAtual.Year - dataNascimento.Year;

            var tempoContricuicao = int.Parse(txtContribuicao.Text);
            int pntContribuicao = idade + tempoContricuicao;

            if (pntContribuicao >= 100)
            {
                label3.Text = "Você pode se aposentar";
            }
            else if (cmbSexo.SelectedItem.ToString() == "Masculino")
            {
                if (cmbSexo.SelectedItem != null && idade >= 65)
                {

                    label3.Text = "Você pode se aposentar";
                }
                else
                {
                    label3.Text = "Você não pode se aposentar";

                }
      
            }
            else if (cmbSexo.SelectedItem.ToString() == "Feminino")
            {
                if (cmbSexo.SelectedItem != null && idade >= 62)
                {

                    label3.Text = "Você pode se aposentar";
                }
                else
                {
                    label3.Text = "Você não pode se aposentar";

                }
            }
        }
    }
}

