using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Conta
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public TipoConta.TipoCont tipo { get; set; }
        public bool status { get; set; }

        public Conta(int id, string descricao, TipoConta.TipoCont tipo, bool status)
        {
            this.id = id;
            this.descricao = descricao;
            this.tipo = tipo;
            this.status = status;
        }
    }
}
