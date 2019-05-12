using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    class Context : DbContext
    {

        public Context() : base("Banco Receitas") { }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
