using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        public int id { get; set; }
        public Fornecedor TipoPessoa { get; set; }
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
