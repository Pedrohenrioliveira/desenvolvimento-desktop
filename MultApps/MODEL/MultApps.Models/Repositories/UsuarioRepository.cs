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
    public class UsuarioRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";

        public bool CadastrarUsuario(Usuario usuario )
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario (nome, email, senha, cpf, status)
                   VALUES (@Nome, @Email, @Senha, @Cpf, @Status)";


                var parametros = new DynamicParameters();
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Email", usuario.Email);
                parametros.Add("@Senha", usuario.Senha);
                parametros.Add("@Cpf", usuario.Cpf);
                parametros.Add("@Status", usuario.Status.ToString().ToLower());

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool EmailExistente(string email)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT COUNT(*) FROM usuario WHERE email = @Email";
                var parametro = new DynamicParameters();
                parametro.Add("@Email", email);
                var resultado = db.ExecuteScalar<int>(comandoSql, parametro);
                return resultado > 0;
            }
        }

        public DataTable ListarUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          cpf AS Cpf, 
                                          email AS Email,
                                          data_cadastro AS DataCadastro,
                                          data_alteracao AS DataAlteracao,
                                          data_ultimo_acesso AS DataUltimoAcesso     
                                   FROM usuario";
                var usuarios = db.Query<Usuario>(comandoSql).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Cpf", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Data Cadastro", typeof (DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                dataTable.Columns.Add("Data UltimoAcesso", typeof(DateTime));
                foreach (var usuario in usuarios)
                {
                    dataTable.Rows.Add(usuario.Id,
                        usuario.Nome,
                        usuario.Cpf,
                        usuario.Email,
                        usuario.DataCriacao,
                        usuario.DataAlteracao,
                        usuario.DataUltimoAcesso);
                }
                return dataTable;
            }
   
        }  

        public DataTable ListarUsuarioPorStatus(int status)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          cpf AS Cpf, 
                                          email AS Email, 
                                          data_cadastro AS DataCadastro,
                                          data_alteracao AS DataAlteracao,
                                          data_ultimo_acesso AS DataUltimoAcesso     
                                   FROM usuario
                                   WHERE status = @Status";

                var parametros = new DynamicParameters();
                parametros.Add("@Status", status);

                var usuarios = db.Query<Usuario>(comandoSql, parametros).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Cpf", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                dataTable.Columns.Add("Data Ultimo Acesso", typeof(DateTime));
                foreach (var usuario in usuarios)
                {
                    dataTable.Rows.Add(usuario.Id,
                        usuario.Nome,
                        usuario.Cpf,
                        usuario.Email,
                        usuario.DataCriacao,
                        usuario.DataAlteracao,
                        usuario.DataUltimoAcesso);
                }
                return dataTable;
            }

        }

        public Usuario ObterUsuarioPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          cpf AS Cpf, 
                                          email AS Email, 
                                          data_cadastro AS DataCadastro,
                                          data_alteracao AS DataAlteracao,
                                          data_ultimo_acesso AS DataUltimoAcesso
                                   FROM categoria WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Usuario>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }
    }
}
