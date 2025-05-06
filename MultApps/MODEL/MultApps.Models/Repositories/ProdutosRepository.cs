using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public class ProdutosRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";

        public bool CadastrarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO produto (ulr, nome, categoria_id, preco, quantidade_estoque)
                                   VALUES(@Url, @Nome,@Categoria, @Preco, @Estoque )";

                var parametros = new DynamicParameters();
                parametros.Add("@Url", produto.Url);
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Categoria", produto.CategoriaId);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@Estoque", produto.QuantidadeEmEstoque);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
    }
}
