using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;

namespace Apresentacao
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCliente());

            Cliente cl1 = new Cliente(
                1, 
                TipoPessoa.PESSOA_FISICA, 
                "123456789", 
                "José Alberto Matioli",
                new DateTime(1994, 10, 10, 17, 30, 55),
                "Matioli", 
                "Braga", 
                10, 
                "Laranjeiras", 
                "Lima", 
                "obs...", 
                "7490321432", 
                "2345678",
                "jwfjew@gmail.com", 
                "9875323", 
                10
                );

            Venda vd1 = new Venda(
                1,
                new DateTime(2024, 04, 11, 12, 35, 00),
                "",
                0.00,
                1225
                );

            Venda vd2 = new Venda(
                3,
                new DateTime(2024, 04, 11, 16, 06, 00),
                "",
                0,
                50
                );
            
            ItemVenda iv1 = new ItemVenda(
                1,
                25,
                0
                );

            ItemVenda iv2 = new ItemVenda(
                1,
                1245,
                45
                );

            ItemVenda iv3 = new ItemVenda(
                2,
                50,
                0
                );

            Produto pd1 = new Produto(
                1,
                "Papel Sulfite",
                25.50m
                );

            Produto pd2 = new Produto(
               2,
               "Monitor LG Flatron",
               1245.00m
               );

            Compra cp1 = new Compra(
                1,
                new DateTime(2024, 04, 03, 10, 31, 00),
                "",
                0,
                25.50
                );

            Compra cp2 = new Compra(
                2,
                new DateTime(2024, 04, 03, 10, 31, 00),
                "",
                25.00,
                1270.00
                );

            Fornecedor fn1 = new Fornecedor(
                1,
                TipoPessoa.PESSOA_FISICA,
                "112233445566",
                "Loja do Turco",
                "Loja da Galera",
                "Rua simples",
                45,
                "Padaria das maçãs",
                "Verne",
                " ",
                "4987423",
                "3894654",
                "5499748",
                "FranboesaForneceAqui@gmail.com"
                );



            ContaPagar cpg1 = new ContaPagar(
                1,
                31.75m,
                new DateTime(2024, 04, 03, 00, 00, 00),
                new DateTime(2024, 04, 03, 00, 00, 00),
                new DateTime(2024, 04, 03, 00, 00, 00),
                MPagamento.MeioPagamento.BOLETO,
                EstadoPagamento.EstadoPag.QUITADO
              );

            ContaPagar cpg2 = new ContaPagar(
                2,
                1270,
                new DateTime(2024, 04, 03, 10, 31, 00),
                new DateTime(2024, 04, 03, 10, 31, 00),
                new DateTime(2024, 04, 03, 10, 31, 00),
                MPagamento.MeioPagamento.PIX,
                EstadoPagamento.EstadoPag.QUITADO
                );

            Conta cta3 = new Conta(
                2,
                "Produtos de informática",
                TipoConta.TipoCont.CONTA_A_PAGAR,
                true
                );

            Conta cta4 = new Conta(
                4,
                "Material de Escritório",
                TipoConta.TipoCont.CONTA_A_PAGAR,
                true
                );

            Categoria ctg2 = new Categoria(
                2,
                "Estoque"
                );

            Categoria ctg3 = new Categoria(
                3,
                "Custeiro"
                );


        }
    }
}
