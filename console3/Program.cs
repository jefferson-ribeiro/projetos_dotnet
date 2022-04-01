using System;
using System.Collections.Generic;

namespace console3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite o nome do cliente: ");
      String cliente = Console.ReadLine();

      Console.WriteLine("Quantos produtos deseja cadastrar neste pedido?");
      int qtdItens = int.Parse(Console.ReadLine());

      List<dynamic> produtos = new List<dynamic>();

      for (int i = 1; i <= qtdItens; i++)
      {
        Console.WriteLine("Digite o nome do Produto " + i + ": ");
        String produto = Console.ReadLine();

        Console.WriteLine("Qual a quantidade de " + produto + " que o(a) " + cliente + " quer?");
        int qtdProduto = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor unitário da(o) " + produto + " : R$");
        double valorProduto;
        valorProduto = double.Parse(Console.ReadLine());

        produtos.Add(new
        {
          Nome = produto,
          Quantidade = qtdProduto,
          Valor = valorProduto
        });
      }

      Console.Clear();
      Console.WriteLine("-------------------------------");
      Console.WriteLine("CONTROLE PEDIDOS DO JOÃO");
      Console.WriteLine("-------------------------------");
      Console.WriteLine(cliente + " esta é sua lista de pedidos");
      Console.WriteLine("-------------------------------");
      
      double valorTotal = 0;

      foreach (var produto in produtos)
      {
        Console.WriteLine(" - Nome do produto: " + produto.Nome);
        Console.WriteLine(" - Quantidade: " + produto.Quantidade);
        Console.WriteLine(" - Valor Unitário: R$" + produto.Valor);
        double totalProduto = produto.Valor * produto.Quantidade;
        Console.WriteLine(" - Valor total item: R$" + totalProduto);
        Console.WriteLine("-------------------------------");
        valorTotal += totalProduto;
      }
      Console.WriteLine("Deu um total dê: R$" + valorTotal);
      double desconto = valorTotal - (valorTotal * 0.1);
      Console.WriteLine("Com o destonto de pagamento a vista fica R$ " + desconto.ToString("#.##"));
    }
  }
}
