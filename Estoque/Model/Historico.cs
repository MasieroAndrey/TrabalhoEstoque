using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    class Historico
    {
        public int HistoricoID { get; set; }
        public double ValorTotal { get; set; }
        public double ValorGasto { get; set; }
        public double Lucro { get; set; }

    }
}
