using System;
using System.Collections.Generic;

namespace console2
{
  class Program
  {
    //for (int i = 0; i<5; i++) {  }
    //String nome[i] = Console.ReadLine();

    static void Main(string[] args)

    {
      //  Console.WriteLine("Digite o seu nome: ");
      // string nome = Console.ReadLine();
      // Console.WriteLine("O nome digitado é: " + nome);

      Console.WriteLine("João quantos clientes vc precisa cadastrar ?");
      int qtd = Convert.ToInt32(Console.ReadLine());

      List<dynamic> clientes = new List<dynamic>();

      for (int i = 1; i <= qtd; i++)
      {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o seu cpf: ");
        string cpf = Console.ReadLine();

        clientes.Add(new
        {
          Nome = nome,
          CPF = cpf
        });
      }

      //IMPRESSÃO DA LISTA 
      Console.Clear();
      Console.WriteLine("-------------------------------");
      Console.WriteLine("A LISTA DE CLIENTES DE JOÃO É: ");
      Console.WriteLine("-------------------------------");

      foreach (var cliente in clientes)
      {
        Console.WriteLine("NOME: " + cliente.Nome);
        Console.WriteLine("CPF: " + cliente.CPF);
        Console.WriteLine("-------------------------------");
      }
    }

    /* {
       Console.WriteLine("Digite nome: ");
       String nome1 = Console.ReadLine();
       Console.WriteLine("Digite CPF: ");
       String cpf1 = Console.ReadLine();

       Console.WriteLine("Digite nome: ");
       String nome2 = Console.ReadLine();
       Console.WriteLine("Digite CPF: ");
       String cpf2 = Console.ReadLine();

       Console.WriteLine("Digite nome: ");
       String nome3 = Console.ReadLine();
       Console.WriteLine("Digite CPF: ");
       String cpf3 = Console.ReadLine();

       Console.WriteLine("Digite nome: ");
       String nome4 = Console.ReadLine();
       Console.WriteLine("Digite CPF: ");
       String cpf4 = Console.ReadLine();

       Console.WriteLine("Digite nome: ");
       String nome5 = Console.ReadLine();
       Console.WriteLine("Digite CPF: ");
       String cpf5 = Console.ReadLine();

       Console.WriteLine("nome: A Lista de clientes é: ");
       Console.WriteLine("nome: "+nome1 + " CPF: "+cpf1);
       Console.WriteLine("nome: "+nome2 + " CPF: "+cpf2);
       Console.WriteLine("nome: "+nome3 + " CPF: "+cpf3);
       Console.WriteLine("nome: "+nome4 + " CPF: "+cpf4);
       Console.WriteLine("nome: "+nome5 + " CPF: "+cpf5);
     } */
  }
}
