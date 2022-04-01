using System;
using System.Collections.Generic;
using System.Threading;

namespace console6
{
    internal class ClienteServico
    {
        internal static void Cadastro(List<Cliente> clientes)
        {
            var cliente = new Cliente();
            Console.WriteLine("Digite o código do cliente: ");
            cliente.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente: ");
            cliente.Telefone = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            cliente.CPF = Console.ReadLine();
            Console.WriteLine("Digite o E-mail do cliente: ");
            cliente.Email = Console.ReadLine();

            clientes.Add(cliente);

            Console.Clear();
            Console.WriteLine("Cliente cadastrado com sucesso!");
            Thread.Sleep(2000);
        }

        internal static void Relatorio(List<Cliente> clientes)
        {
            //Relatorio Cliente
            foreach (var cliente in clientes)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Código Cliente: " + cliente.Codigo);
                Console.WriteLine("Cliente: " + cliente.Nome);
                Console.WriteLine("Telefone: " + cliente.Telefone);
                Console.WriteLine("CPF " + cliente.CPF);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine(":::::::::::::::::::::::::::::::::");
            }
        }
    }
}