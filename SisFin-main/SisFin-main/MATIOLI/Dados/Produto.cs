using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get;set; }
        public decimal preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }
    }
}
