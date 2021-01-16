using MVC_Console.Models;
using MVC_Console.Views;
using System;

namespace MVC_Console.Controllers
{
    public class ClienteController
    {
        Cliente cliente = new Cliente();

        ClienteView clienteView = new ClienteView();

        public void ListarClientes()
        {
            clienteView.Listar(cliente.Ler());
        }

        public void Cadastrar()
        {
            cliente.Inserir(clienteView.CadastrarCliente());
        }
    }
}