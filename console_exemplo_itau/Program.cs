using System;

namespace console_exemplo_itau
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Digite uma das opções abaixo: ");
        Console.WriteLine("1 - Cadastrar clientes");
        Console.WriteLine("2 - Listar Clientes");
        Console.WriteLine("3 - Sair");

        var opcao = Convert.ToInt32(Console.ReadLine());
      }
    }
  }
}
