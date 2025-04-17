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
    }
}
