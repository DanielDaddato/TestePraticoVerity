﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public IList<Produtos> Produtos { get; set; }

    }
}
