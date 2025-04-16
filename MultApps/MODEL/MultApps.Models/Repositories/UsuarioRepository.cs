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

        public bool AtualizarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario
                       SET nome = @Nome,
                           email = @Email,
                           senha = @Senha,
                           cpf = @Cpf
                           status = @Status
                       WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", usuario.Id);
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Email", usuario.Email);
                parametros.Add("@Senha", usuario.Senha);
                parametros.Add("@Cpf", usuario.Cpf);
                parametros.Add("@Status", usuario.Status.ToString().ToLower());

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }

        public bool DeletarUsuario(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM usuario WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;

            }

        }

        public List<Usuario> ListarTodosUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, email, senha, cpf, data_criacao AS DataCadastro, data_alteracao AS DataAlteracao, status
                                   FROM usuario";
                var resultado = db.Query<Usuario>(comandoSql).ToList();
                return resultado;
            }
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, email, senha, cpf, data_criacao, data_alteracao, status
                                   FROM usuario WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Usuario>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }
    }
}
