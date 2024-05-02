using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagar
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataPagamento { get; set; }
        public MPagamento.MeioPagamento meioPagamento { get; set; }
        public EstadoPagamento.EstadoPag situacao { get; set; }

        public ContaPagar(int id, decimal valor, DateTime dataCadastro, DateTime dataVencimento, DateTime dataPagamento, MPagamento.MeioPagamento meioPagamento, EstadoPagamento.EstadoPag situacao)
        {
            this.id = id;
            this.valor = valor;
            this.dataCadastro = dataCadastro;
            this.dataVencimento = dataVencimento;
            this.dataPagamento = dataPagamento;
            this.meioPagamento = meioPagamento;
            this.situacao = situacao;
        }
    }
}
