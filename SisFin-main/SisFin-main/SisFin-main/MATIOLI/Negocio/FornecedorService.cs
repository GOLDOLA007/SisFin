using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class FornecedorService
    {
        private readonly FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public void CadastrarFornecedor(int id, TipoPessoa tipoPessoa, string nome, string email)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado


            var fornecedor = new Fornecedor
            {
                id = id,
                //TipoPessoa = tipoPessoa,
                nome = nome,
                email = email
            };

            _repository.Adicionar(fornecedor);
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }


}
