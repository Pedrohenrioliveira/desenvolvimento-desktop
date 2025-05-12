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
 
        ProdutoRepositories produtoRepo = new ProdutoRepositories();

        private void CarregarGrid()
        {
            DataTable dt = produtoRepo.ListarProdutos();

           // Aplicar filtro de Status
            string statusFiltro = cmbStatusFiltro.SelectedItem?.ToString();
            if (statusFiltro != null && statusFiltro != "Todos")
            {
                dt = dt.Select($"Status = '{statusFiltro}'").CopyToDataTable();
            }

            // Aplicar filtro de Categoria
            string categoriaFiltro = cmbCategoriaFiltro.SelectedItem?.ToString();
            if (categoriaFiltro != null && categoriaFiltro != "Todas")
            {
                dt = dt.Select($"CategoriaNome = '{categoriaFiltro}'").CopyToDataTable();
            }

            dgvProdutos.DataSource = dt;
        }




    }
}
