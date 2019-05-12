using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("Estoque")]
    class Estoque
    {
        [Key]
        public int EstoqueID { get; set; }
        public List<Ingrediente> Ingrediente { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double Preco { get; set; }
    }
}
