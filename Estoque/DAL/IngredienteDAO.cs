using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DAL
{
    class IngredienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Busca Ingrediente
        public static Ingrediente BuscarIngrediente(Ingrediente i)
        {
            return ctx.Ingrediente.FirstOrDefault(x => x.Nome.Equals(i.Nome));
        }
        //Metodo de Cadastro de Ingrediente
        public static bool CadastrarUsuario(Ingrediente i)
        {
            if (BuscarIngrediente(i) == null)
            {
                ctx.Ingrediente.Add(i);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        //Remover Receita
        public static bool RemoverReceita(Ingrediente i)
        {
            if (BuscarIngrediente(i) != null)
            {
                ctx.Ingrediente.Remove(i);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
