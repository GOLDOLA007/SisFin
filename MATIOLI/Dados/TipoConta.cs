using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class TipoConta
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int tipo { get; set; }
        public enum TipoCont {CONTA_A_PAGAR = 1, CONTA_A_RECEBER = 2};
    }
}
