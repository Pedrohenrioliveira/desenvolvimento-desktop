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
            string textoNascimento = txtNascimento.Text;
            DateTime dataNascimento = DateTime.Parse(textoNascimento);

            DateTime dataAtual = DateTime.Now;

            if (cmbSexo.SelectedItem != null && idade >= 65)
            {
                if (cmbSexo.SelectedItem.ToString() == "Masculino")
                {

                    label3.Text = "Voce pode se aposentar";
                }
            }
        }
    }
}

