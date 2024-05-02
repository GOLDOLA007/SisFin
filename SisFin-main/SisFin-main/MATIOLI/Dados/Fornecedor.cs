using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        public Fornecedor(int id, TipoPessoa tipoForncedor, string cpf_cpnj, string razaoSocial, string nome, string rua, int numero, string bairro, string cidade, string complemento, string cep, string telefone, string celular, string email)
        {
            this.id = id;
            this.tipoFornecedor = tipoFornecedor;
            this.cpf_cpnj = cpf_cpnj;
            this.razaoSocial = razaoSocial;
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.complemento = complemento;
            this.cep = cep;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
        }

        public int id { get; set; }
        public TipoPessoa tipoFornecedor { get; set; }
        public string cpf_cpnj { get; set; }
        public string razaoSocial { get; set; }
        public string nome { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
    }
}
