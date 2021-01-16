using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ClienteView
    {
        public void Listar(List<Cliente> clientes)
        {
            foreach (var item in clientes)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"RG: {item.RG}");
                Console.WriteLine($"Idade: {item.Idade}");
                Console.WriteLine();
                
            }

        }
            public Cliente CadastrarCliente()
            {
                Cliente cliente = new Cliente();

                Console.WriteLine($"Insira o nome do cliente: ");
                cliente.Nome = Console.ReadLine();

                Console.WriteLine($"Insira o RG do cliente: ");
                cliente.RG = float.Parse(Console.ReadLine());

                Console.WriteLine($"Insira a idade do cliente: ");
                cliente.Idade = int.Parse(Console.ReadLine());

                return cliente;
            }
    }
}