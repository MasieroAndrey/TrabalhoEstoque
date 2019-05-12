using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("Receita")]
    class Receita
    {
        [Key]
        public int ReceitaID { get; set; }
        public List<Ingrediente> Ingrediente { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
