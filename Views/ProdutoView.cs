using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine();
            }
        }
    }
}