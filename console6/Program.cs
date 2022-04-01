using System;
using System.Collections.Generic;
using System.Threading;

namespace console6
{
    /*
    O itaú está precisa de um e-commerce para a venda de sus produtos digitais, para este ecomerce, iremos precisar vincular
  os clientes, a os produtos e a os pedidos

  para isso crie um sistema na qual será capturado os 
  - Clientes (Codigo, Nome, Telefone, CPF, Email)
  - Produtos (Codigo, Nome, descricao, valor)
  - Pedidos (Codigo, CodigoCliente, CodigoProduto, QuantidadeProduto, ValorTotal)

  Resultado final, mostre um relatório com os pedidos dos clientes da sequinte forma:

  ::::: Pedidos ::::
  --------------------------
  Pedido Número: 1
  Nome: Danilo
  Produto: Iti
  ValorTotal: R$ 200
  --------------------------
  Pedido Número: 2
  Nome: Jesus
  Produto: Iti
  ValorTotal: R$ 250
  --------------------------
  Pedido Número: 3
  Nome: Maria
  Produto: Iti
  ValorTotal: R$ 300
  --------------------------
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Pedido> pedidos = new List<Pedido>();

            while (true)
            {
                Console.WriteLine(":::::::::::::E-comerce Itaú:::::::::::::");
                Console.WriteLine("-------VENDA DE PRODUTOS DIGITAIS-------");
                Console.WriteLine("========================================");
                Console.WriteLine("Escolha a opção:");
                Console.WriteLine("1 - Cadastro de Clientes");
                Console.WriteLine("2 - Relatório de Clientes");
                Console.WriteLine("3 - Cadastro de Produtos");
                Console.WriteLine("4 - Relatório de Produtos");
                Console.WriteLine("5 - Cadastro de Pedidos");
                Console.WriteLine("6 - Relatório de Pedidos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("========================================");
                int opcao = 0;

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                    switch (opcao)
                    {
                        case 0: //Saída do programa
                            Console.Clear();
                            Console.WriteLine("Muito obrigado por utilizar este programa!");
                            return;
                        case 1: //Cadastro de cliente
                            ClienteServico.Cadastro(clientes);
                            break;
                        case 2: //Relatorio de cliente
                            ClienteServico.Relatorio(clientes);
                            break;
                        case 3://Cadastro de Produto
                            ProdutoServico.Cadastro(produtos);
                            break;
                        case 4:
                            ProdutoServico.Relatorio(produtos);
                            break;

                        case 5:
                            PedidoServico.Cadastro(pedidos, clientes, produtos);
                            break;

                        case 6:
                            PedidoServico.Relatorio(pedidos);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Inválida");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida, digite somente números do menu");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
