using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Compra
    {
        public int id { get; set; }
        public DateTime instante { get; set; }
        public String descricao { get; set; }
        public Double desconto { get; set; }
        public Double valor_total { get; set; }
    }
}
