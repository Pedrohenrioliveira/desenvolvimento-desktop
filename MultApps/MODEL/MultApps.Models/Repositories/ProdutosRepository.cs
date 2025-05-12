using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public class ProdutoRepositories
    {
        private readonly string _connectionString;

        public ProdutoRepositories()
        {
            _connectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root;";
        }


        public DataTable ListarProdutos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT p.id AS Id, 
                                  p.url AS Url, 
                                  c.nome AS CategoriaNome,
                                  p.nome AS Nome, 
                                  p.descricao AS Descricao, 
                                  p.preco AS Preco, 
                                  p.quantidade_estoque AS QuantidadeEstoque,
                                  p.status AS Status
                           FROM produto p
                           INNER JOIN categoria c ON p.categoria_id = c.id";

                var produtos = db.Query<Produto>(comandoSql).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Url", typeof(string));
                dataTable.Columns.Add("CategoriaNome", typeof(string));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Descricao", typeof(string));
                dataTable.Columns.Add("Preco", typeof(decimal));
                dataTable.Columns.Add("QuantidadeEstoque", typeof(int));
                dataTable.Columns.Add("Status", typeof(string));

                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                                       produto.Url,
                                       produto.Categoria,
                                       produto.Nome,
                                       produto.Descricao,
                                       produto.Preco,
                                       produto.QuantidadeEmEstoque,
                                       produto.Status);
                }
                return dataTable;
            }
        }
        public bool CadastrarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO produto 
                           (url, categoria_id, nome, descricao, preco, quantidade_estoque, status)
                           VALUES (@Url, @CategoriaId, @Nome, @Descricao, @Preco, @QuantidadeEstoque, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Url", produto.Url);
                parametros.Add("@CategoriaId", produto.Categoria);
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Descricao", produto.Descricao);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@QuantidadeEstoque", produto.QuantidadeEmEstoque);
                parametros.Add("@Status", produto.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }


        public bool AdicionarProduto(Produto produto)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Produtos 
                (Nome, Descricao, Categoria, Preco, Estoque, UrlImagem, Status)
                VALUES (@Nome, @Descricao, @Categoria, @Preco, @Estoque, @UrlImagem, @Status);"
                    ;

                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                    command.Parameters.AddWithValue("@Categoria", produto.Categoria);
                    command.Parameters.AddWithValue("@Preco", produto.Preco);
                    command.Parameters.AddWithValue("@Estoque", produto.QuantidadeEmEstoque);
                    command.Parameters.AddWithValue("@UrlImagem", produto.Url);
                    command.Parameters.AddWithValue("@Status", produto.Status);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar produto: " + ex.Message);
                return false;
            }
        }
        public bool AtualizarProduto(Produto produtoAtualizado)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "UPDATE Produto SET Nome = @Nome, Descricao = @Descricao, Categoria = @Categoria, " +
                                "Preco = @Preco, Estoque = @Estoque, Status = @Status WHERE Id = @Id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", produtoAtualizado.Id);
                        command.Parameters.AddWithValue("@Nome", produtoAtualizado.Nome);
                        command.Parameters.AddWithValue("@Descricao", produtoAtualizado.Descricao);
                        command.Parameters.AddWithValue("@Categoria", produtoAtualizado.Categoria);
                        command.Parameters.AddWithValue("@Preco", produtoAtualizado.Preco);
                        command.Parameters.AddWithValue("@Estoque", produtoAtualizado.QuantidadeEmEstoque);
                        command.Parameters.AddWithValue("@Status", produtoAtualizado.Status);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletarProduto(int id)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM Produto WHERE Id = @Id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}