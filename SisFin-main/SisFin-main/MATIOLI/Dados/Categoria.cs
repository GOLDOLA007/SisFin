﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }

        public Categoria(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}