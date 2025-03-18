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

        private void button1_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            var Cpf = double.Parse(txtCpf.Text);
            var dataNascimento = double.Parse(txtNascimento.Text);

            panel1.Visible = true;
            if()
            {

            }
            lblNome.Text = Nome;

        }
    }
}
