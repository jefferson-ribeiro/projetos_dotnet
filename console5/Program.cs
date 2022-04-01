using System;
using System.Collections.Generic;

namespace console5
{
  class Program
  {
    /*
Steffani é uma professora de Matemática, ela precisa de um software para 
cadastrar seus alunos Campos Aluno(Nome, Matricula, Notas), (ela decide a quantidade)
cadastrar uma quantidade de notas para cada aluno (Ela informa a quantidade)
no final do programa, mostrar o relatório com os alunos cadastrados
Assim:
-----------------------------
Nome: xxx
Matricula: yyy
Notas: x,x,x,x
Média: xx
Situacao: Aprovado ou Reprovado 
-----------------------------

Critério, o aluno aprovado precisa tirar a média maior que 6
    */
    static void Main(string[] args)
    {
      Console.WriteLine(":::::::::::::CADASTRO DE ALUNOS DA Profª Steffani:::::::::::::");
      Console.WriteLine("--------------------------------------------------------------");
      Console.WriteLine("Informe quantos alunos deseja cadastrar: ");
      int qtdAlunos = Convert.ToInt32(Console.ReadLine());

      List<Aluno> alunos = new List<Aluno>();

      // double qtdnotas = 0;

      for (int i = 1; i <= qtdAlunos; i++)
      {
        var aluno = new Aluno();
        Console.WriteLine("Digite o nome do Aluno " + i + ": ");
        aluno.NomeAluno = Console.ReadLine();

        Console.WriteLine("Informe o número da matricula do aluno: " + aluno.NomeAluno);
        aluno.MatriculaAluno = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de notas do " + aluno.NomeAluno);
        aluno.QtdNotasAluno = Convert.ToInt32(Console.ReadLine());

        for (int n = 1; n <= aluno.QtdNotasAluno; n++)
        {
          Console.WriteLine("Informe a nota " + n + " do aluno " + aluno.NomeAluno);
          aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
        }
        alunos.Add(aluno);
      }

      Console.Clear();
      Console.WriteLine("-----------------------------------");
      Console.WriteLine(":::Alunos da Professora Steffani:::");
      Console.WriteLine("-----------------------------------");

      foreach (var aluno in alunos)
      {
        Console.WriteLine("Aluno: " + aluno.NomeAluno);
        Console.WriteLine("Matricula: " + aluno.MatriculaAluno);
        Console.WriteLine("Quantidade de notas: " + aluno.QtdNotasAluno);
        Console.WriteLine("Notas dos alunos: " + string.Join(",", aluno.Notas.ToArray()));
        Console.WriteLine("-----------------------------------");
        double totalNotas = 0;

        foreach (var nota in aluno.Notas)
        {
          totalNotas += nota;
        }
        double media = totalNotas / aluno.Notas.Count;

        if (media < 6)
        {
          Console.WriteLine(aluno.NomeAluno+" Sua média é " + media + " Você está REPROVADO");
        }
        else if (media >= 6)
        {
          Console.WriteLine(aluno.NomeAluno+" Sua média é " + media + " Você está APROVADO");
        }
        Console.WriteLine("##########################################");
      }
    }
  }
}

