using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.View
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("  -- CADASTRAR PRODUTO --\n");
            //Console.WriteLine("Digite o nome do produto:");
            //p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto:");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
            if (ProdutoDAO.CadastrarProduto(p))
            {
                Console.WriteLine("\nProduto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nEsse produto já existe!");
            }
        }
    }
}
