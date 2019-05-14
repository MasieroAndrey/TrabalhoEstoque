using Estoque.Model;
using Estoque.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.View
{
    class FazerLogin
    {
        public static void Renderiazar()
        {
            Usuario u = new Usuario();

            Console.WriteLine("--Fazer LOGiN--");
            Console.WriteLine("Digite o nome de usuario:");
            u.Login = Console.ReadLine();
            // No  site da para pedir verificação dupla de senha
            Console.WriteLine("Digite a senha do usuario:");
            u.Password = Console.ReadLine();
            if (ValidaLogin.ValidarLogin(u) != null)
            {
                Console.WriteLine("\nLogin bem sucedido");
            }
            else
            {
                Console.WriteLine("\nUsuario ou senha incorretos ou não cadastrados");
            }
        }
    }
}
