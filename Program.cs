using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            ClienteController cli = new ClienteController();

            cli.Cadastrar();
            cli.ListarClientes();

            prod.Cadastrar();
            prod.ListarProdutos();
            
            

            
        }
    }
}
