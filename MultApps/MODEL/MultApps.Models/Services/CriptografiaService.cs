using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Services
{
    public class CriptografiaService
    {
        public string Criptografar(string senha)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public string Verificar(string senha, string senhaCriptografada)
        {

        }
    }
}
