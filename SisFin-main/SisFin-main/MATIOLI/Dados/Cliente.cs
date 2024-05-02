using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        public Cliente(int id, TipoPessoa tipoPessoa, string cpf_cnpj, string razaoSocial, DateTime? dataNascimento, string nome, string rua, 
            int numero, string bairro, string cidade, string complemento, string cep, string telefone, 
            string email, string celular, decimal limite)
        {
            Id = id;
            this.tipoPessoa = tipoPessoa;
            this.cpf_cnpj = cpf_cnpj;
            this.razaoSocial = razaoSocial;
            this.dataNascimento = dataNascimento;
            Nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.complemento = complemento;
            this.cep = cep;
            this.telefone = telefone;
            Email = email;
            this.celular = celular;
            this.limite = limite;
        }

        public int Id { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string cpf_cnpj { get; set; }
        public string razaoSocial { get; set; }
        //DateTime? -> aceita valor nulo
        public DateTime? dataNascimento { get; set; }
        public string Nome { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string Email { get; set; }
        public string celular { get; set; }
        public decimal limite { get;set; }
        

    }
}
