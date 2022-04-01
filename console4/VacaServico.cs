using System;
using System.Collections.Generic;
using System.Threading;

namespace console4
{
    internal class VacaServico
    {
        public static void Cadastrar(List<Vaca> vacas)
        {
            Console.WriteLine("Digite a quantidade de Vacas");
            int qtd = 1;
            string sQtd = Console.ReadLine();
            if(!int.TryParse(sQtd, out qtd))
            {
                Console.Clear();
                Console.WriteLine("Você a quantidade de vacas inválido, digite somente números");
                Thread.Sleep(2000);
                VacaServico.Cadastrar(vacas);
                return;
            }

            for(int i=0;i<qtd;i++)
            {
                Console.Clear();
                var vaca = new Vaca();
                Console.WriteLine("Digite o nome da vaca de número " + (i+1));
                vaca.Nome = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de leite que a vaca " + vaca.Nome + " suporta ");
                vaca.QuantidadeDeLitrosTotal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de leite atual da vaca " + vaca.Nome);
                vaca.QuantidadeDeLitrosAtual = Convert.ToInt32(Console.ReadLine());

                vacas.Add(vaca);
                
                Console.WriteLine("Vaca cadastrado com sucesso !!!");
                Thread.Sleep(2000);
            }
        }

        public static void Mostrar(List<Vaca> vacas)
        {
            Console.Clear();
            
            if(vacas.Count == 0)
            {
                Console.WriteLine("Não há vacas cadastradas, primeiro cadastre a sua vaca");
                Thread.Sleep(2000);

                VacaServico.Cadastrar(vacas);
            }

            Console.Clear();

            foreach(var vaca in vacas)
            {
                Console.WriteLine("Nome: " + vaca.Nome);
                Console.WriteLine("Quantidade total de leite: " + vaca.QuantidadeDeLitrosTotal);
                Console.WriteLine("Quantidade atual de leite: " + vaca.QuantidadeDeLitrosAtual);
                Console.WriteLine("Capacidade: " + (vaca.QuantidadeDeLitrosAtual /vaca.QuantidadeDeLitrosTotal*100) + "%");
                Console.WriteLine("-----------------------------");
            }
        
            Thread.Sleep(5000);
        }

        public static void QuantidadeDeVacasLitros(List<Vaca> vacas)
        {
            Console.Clear();
            
            if(vacas.Count == 0)
            {
                Console.WriteLine("Não há vacas cadastradas, primeiro cadastre a sua vaca");
                Thread.Sleep(2000);

                VacaServico.Cadastrar(vacas);
            }

            Console.Clear();

            double quantidadeTotalDeLitros = 0;
            foreach(var vaca in vacas)
            {
                quantidadeTotalDeLitros += vaca.QuantidadeDeLitrosAtual;
            }

            Console.WriteLine("Quantidade total de vacas é de: " + vacas.Count);
            Console.WriteLine("A quantidade total de litros é: " + quantidadeTotalDeLitros);
        
            Thread.Sleep(5000);
        }

    }
}
