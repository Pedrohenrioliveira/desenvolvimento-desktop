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
using System.Security.Cryptography;
using System.Text;
using MultApps.Models.Services;

namespace MultApps.Windows
{
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
            CarregarTodosUsuario();

            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cmbStatus.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 1;
            cmbFiltro.SelectedIndex = 0;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = txtCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = CriptografiaService.Criptografar(txtSenha.Text);              
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                var usuarioRepository = new UsuarioRepository();
                
                var emailJaExiste = usuarioRepository.EmailExistente(usuario.Email);
                if(emailJaExiste)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado.");
                    txtEmail.Focus();
                    return;
                }
                var sucesso = usuarioRepository.CadastrarUsuario(usuario);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");
                    CarregarTodosUsuario();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o usuário {usuario.Nome}");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("Campo Cpf é obrigatório");
                txtCpf.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha é obrigatório");
                txtSenha.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Status é obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            CarregarTodosUsuario();
        }

        private void CarregarTodosUsuario()
        {
            var usuarioRepository = new UsuarioRepository();

            var listaUsuario = usuarioRepository.ListarUsuarios();
            dataGridView1.DataSource = listaUsuario;
        }
        private void LimparCampos()
        {
            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtDataCriacao.Clear();
            txtUltimoAcesso.Clear();
            cmbStatus.SelectedIndex = 1;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usuarioRepositorio = new UsuarioRepository();
            switch (cmbFiltro.SelectedIndex)
            {
                case 0:
                    CarregarTodosUsuario();
                    break;
                case 1:
                    var usuariosAtivos = usuarioRepositorio.ListarUsuarioPorStatus(1);
                    dataGridView1.DataSource = usuariosAtivos;
                    break;
                case 2:
                    var usuariosInativos = usuarioRepositorio.ListarUsuarioPorStatus(0);
                    dataGridView1.DataSource = usuariosInativos;
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var usuarioId = (int)row.Cells[0].Value;

            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.ObterUsuarioPorId(2);

            if (usuario == null)
            {
                MessageBox.Show($"Categoria: #{usuarioId} não encontrada");
                return;
            }

            txtNome.Text = usuario.Nome;
            cmbStatus.SelectedIndex = (int)usuario.Status;
            txtDataCriacao.Text = usuario.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = categoria.DataAlteracao.ToString("dd/MM/yyyy HH:mm");

            btnLimpar.Enabled = true;
            btnSalvar.Text = "Salvar alterações";
        }
    }
}
