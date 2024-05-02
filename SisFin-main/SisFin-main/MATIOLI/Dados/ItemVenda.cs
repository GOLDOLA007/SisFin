using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemVenda
    {
        public int quantidade { get; set; }
        public decimal preco { get; set; }
        public decimal desconto { get; set; }

        public ItemVenda(int quantidade, decimal preco, decimal desconto)
        {
            this.quantidade = quantidade;
            this.preco = preco;
            this.desconto = desconto;
        }
    }
}
