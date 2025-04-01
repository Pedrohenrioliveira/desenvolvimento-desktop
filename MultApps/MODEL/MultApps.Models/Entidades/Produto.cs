﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entidades
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Decimal Preco { get; set; }

        public int QuantidadeEmEstoque { get; set; }
        public Categoria Categoria { get; set; }
    }
}
