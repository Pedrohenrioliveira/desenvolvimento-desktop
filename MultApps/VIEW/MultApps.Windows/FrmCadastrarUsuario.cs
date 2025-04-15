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

namespace MultApps.Windows
{
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

            var usuarioRepository = new UsuarioRepository();

            if (string.IsNullOrEmpty(txtId.Text))
            {
                var resultado = categoriaRepository.CadastrarCategoria(categoria);
                if (resultado)
                {
                    MessageBox.Show("Categoria cadastra com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar categoria");
                }
            }
            else
            {
                categoria.Id = int.Parse(txtId.Text);
                var resultado = categoriaRepository.AtualizarCategoria(categoria);

                if (resultado)
                {
                    MessageBox.Show("Categoria atualizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar categoria");
                }

            }


            CarregarTodasCategorias();
        }
    }
}
