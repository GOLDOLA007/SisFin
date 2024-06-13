using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaReceber
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataRecebimento { get; set; }
        public decimal valorRecebido { get; set; }
        public MeioPagamento meioPagamento {get; set;}
        public EstadoPagamento situacao { get; set; }

    }
}
