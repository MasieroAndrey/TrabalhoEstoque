﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("EmProducao")]
    class EmProducao
    {
        [Key]
        public int EmProducaoID { get; set; }
        public List<Estoque> Estoque { get; set; }
        public Receita Receita { get; set; }
        public DateTime DataProducao { get; set; }
        public int QuantidadeReceitas { get; set; }

    }
}
