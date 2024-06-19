using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Venda
    {
        public int id { get; set; }
        public DateTime instante { get; set; }
        public Double desconto { get; set; }
        public Double valor_total { get; set; }
    }
}
