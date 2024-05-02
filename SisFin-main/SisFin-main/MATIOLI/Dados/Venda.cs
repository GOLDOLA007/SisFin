using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Venda
    {
        public int id { get; set; }
        public DateTime? instante { get; set; }
        public string descricao { get; set; }
        public double desconto { get; set; }
        public double valor_total { get; set; }

        public Venda(int id, DateTime? instante, string descricao, double desconto, double valor_total)
        {
            this.id = id;
            this.instante = instante;
            this.descricao = descricao;
            this.desconto = desconto;
            this.valor_total = valor_total;
        }
    }
}
