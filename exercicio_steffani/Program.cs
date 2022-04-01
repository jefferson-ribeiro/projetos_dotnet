using System;
using System.Collections.Generic;

namespace exercicio_steffani
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Maca> sacolaDeMacas = new List<Maca>();
            Console.WriteLine("Quantas maças você deseja Steffani");
            int qtdAlunos = Convert.ToInt32(Console.ReadLine());

            for(int x=0;x<qtdAlunos;x++){

                //Console.Clear();
                Maca maca = new Maca();
                Console.WriteLine("Digite a cor da maça " + (x + 1));
                maca.Cor = Console.ReadLine();

                Console.WriteLine("Digite a forma da maça");
                maca.Forma = Console.ReadLine();

                maca.Sementes = new List<string>();
                for(int i=0; i<3;i++){
                    Console.WriteLine("Digite o tipo de semente " + (i+1) + " da maça " + maca.Cor);
                    maca.Sementes.Add(Console.ReadLine());
                }

                sacolaDeMacas.Add(maca);
            }

            foreach(var maca in sacolaDeMacas){
                Console.WriteLine("Cor: " + maca.Cor);
                Console.WriteLine("Forma: " + maca.Forma);
                Console.WriteLine("Sementes: " + string.Join(", ", maca.Sementes));
                Console.WriteLine("--------------------");
            }

        }
    }
}


