using System;
using System.Collections.Generic;

namespace console6
{
    internal class ProdutoServico
    {
      internal static void Cadastro(List<Produto> produtos)
        {
            var produto = new Produto();

            Console.WriteLine("Digite o código do Produto: ");
            produto.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto: ");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            produto.Valor = Convert.ToDouble(Console.ReadLine());
            produtos.Add(produto);
        }
        internal static void Relatorio(List<Produto> produtos)
        {
            //Relatorio Produto
            foreach (var produto in produtos)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Código Produto: " + produto.Codigo);
                Console.WriteLine("Nome Produto: " + produto.Nome);
                Console.WriteLine("Descrição do Produto: " + produto.Descricao);
                Console.WriteLine("Valor do Produto: " + produto.Valor);
                Console.WriteLine(":::::::::::::::::::::::::::::::::");
            }
        }
    }
}