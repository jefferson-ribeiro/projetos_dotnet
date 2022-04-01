using System;
using System.Collections.Generic;
using System.Threading;

namespace console6
{
    internal class PedidoServico
    {
        internal static void Cadastro(List<Pedido> pedidos, List<Cliente> clientes, List<Produto> produtos)
        {

            if (clientes.Count == 0)
            {
                Console.WriteLine("Não existe cliente cadastrado!");
                Thread.Sleep(2000);

                ClienteServico.Cadastro(clientes);
            }
            Console.Clear();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Não existe produto cadastrado!");
                Thread.Sleep(2000);

                ProdutoServico.Cadastro(produtos);
            }
            Console.Clear();

            var pedido = new Pedido();

            pedido.Codigo = pedidos.Count + 1;

            Console.WriteLine("Digite o código do cliente para este pedido: ");
            foreach (var cliente in clientes)
            {
                Console.WriteLine("(" + cliente.Codigo + ") - " + cliente.Nome);
            }

            var codigoCliente = Convert.ToInt32(Console.ReadLine());

            //Verifica se esse codigo é valido
            if (clientes.Find(c => c.Codigo == codigoCliente) == null)
            {
                Console.WriteLine("Pedido inválido você digitou o código errado!");
                Thread.Sleep(2000);
                return;
            }

            pedido.Cliente.Codigo = codigoCliente;

            Console.WriteLine("Digite o código do produto para este pedido: ");
            foreach (var produto in produtos)
            {
                Console.WriteLine("(" + produto.Codigo + ") - " + produto.Nome);
            }

            var codigoProduto = Convert.ToInt32(Console.ReadLine());

            //Verifica se esse codigo é valido
            if (produtos.Find(c => c.Codigo == codigoProduto) == null)
            {
                Console.WriteLine("Produto inválido você digitou o código errado!");
                Thread.Sleep(2000);
                return;
            }

            pedido.Produto.Codigo = codigoProduto;

            Console.WriteLine("Digite a quantide deste produto: ");
            pedido.Quantidade = Convert.ToInt32(Console.ReadLine());

            pedido.ValorTotal = pedido.Quantidade * pedido.Produto.Valor;

            pedidos.Add(pedido);

            Console.Clear();
            Console.WriteLine("Pedido cadastrado com sucesso!");
            Thread.Sleep(2000);
        }

        internal static void Relatorio(List<Pedido> pedidos)
        {
            if (pedidos.Count == 0)
            {
                Console.WriteLine("Não existe pedido cadastrado!");
                Thread.Sleep(2000);
                return;
            }
            foreach (var pedido in pedidos)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Codigo Pedido: "+ pedido.Codigo);
                Console.WriteLine("Valor Total: "+ pedido.ValorTotal);
                Console.WriteLine("Quantidade: "+ pedido.Quantidade);
                Console.WriteLine("Produto: "+ pedido.Produto.Nome);
                Console.WriteLine("Cliente: "+ pedido.Cliente.Nome);
            }

        }
    }
}
