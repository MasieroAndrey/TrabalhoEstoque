using Estoque.DAL;
using Estoque.Model;
using Estoque.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.View
{
    class CadastrarUsuario
    {
        public static void Renderizar()
        {
            Usuario u = new Usuario();
            Console.WriteLine("  -- CADASTRAR CLIENTE --\n");
            Console.WriteLine("Digite seu nome completo:");
            u.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do usuario:");
            u.Cpf = Console.ReadLine();
            // API para validar cpf
            if (Validacao.ValidarCpf(u.Cpf))
            {
                Console.WriteLine("Digite seu nome de usuario:");
                u.Login = Console.ReadLine();
                Console.WriteLine("Digite a senha:");
                u.Password = Console.ReadLine();
                Console.WriteLine("informe seu saldo:");
                u.SaldoConta = Convert.ToDouble(Console.ReadLine());
                u.DataCadastro = DateTime.Now;
                if (UsuarioDAO.CadastrarUsuario(u))
                {
                    Console.WriteLine("\nUsuario cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nEsse usuario já existe!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
    }
}
