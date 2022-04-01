using System;
using System.Collections.Generic;
using System.Threading;

namespace console4
{
  class Fazenda
  {
    public static void Executa()
    {
      /*

        Joaquin Feliz tem uma fazenda de gados, ele precisa de um sistema para
        1 cadastrar suas vacas (Nome, Litros de leite)
        2 cadastrar a quantidade de leite que cada vaga suporta
        3 mostrar o total de vagas e o total de litros de leite ele pode ter em poder de vendas na sua fazenda
        4 mostre no relatorio também os nomes das vacas e a quantidade de litros de cada uma.

      */
      List<Vaca> vacas = new List<Vaca>();

      while(true)
      {
        Console.WriteLine("::::: Fazenda você bem forte :::::");
        Console.WriteLine("Qual opção você deseja:");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Cadastrar vacas");
        Console.WriteLine("2 - Mostrar a quantidade de vacas e litros de leite");
        Console.WriteLine("3 - Relatório de vacas");

        int opcao = -1;
        
        try
        {
          opcao = Convert.ToInt32(Console.ReadLine());

          switch(opcao)
          {
            case 0:
              return;
            case 1:
              VacaServico.Cadastrar(vacas);
              break;
            case 2:
              VacaServico.QuantidadeDeVacasLitros(vacas);
              break;
            case 3:
              VacaServico.Mostrar(vacas);
              break;
            default:
              Console.Clear();
              Console.WriteLine("Opção inváida");
              Thread.Sleep(2000);
              break;
          }
        }
        catch
        {
          Console.Clear();
          Console.WriteLine("Opção inváida, digite somente os números do menu");
          Thread.Sleep(2000);
        }

      }
    }
  }
}
