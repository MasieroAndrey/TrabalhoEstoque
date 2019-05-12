using Estoque.DAL;
using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Utils
{
    class ValidaLogin
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Recebe um Usuario e verifica se a senha é igual
        public static Usuario ValidaSenha(Usuario u)
        {
            return ctx.Usuario.FirstOrDefault(x => x.Password.Equals(u.Password));
        }

        //Recebe um Usuario verifica login e senha
        public static Usuario ValidarLogin(Usuario u)
        {
            //Verifica se o Login do Usuario Existe
            if (UsuarioDAO.BuscarUsuarioPorLogin(u) != null)
            { 
                //Vefirica a Senha se existir retorna o Usuario
                if (ValidaSenha(u) != null) 
                {
                    return u;
                }
            }
            return null;

        }
    }
}
