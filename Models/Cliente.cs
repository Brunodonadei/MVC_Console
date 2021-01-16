using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Cliente
    {
        public float RG { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        private const string PATH = "Database/Cliente.csv";

        public Cliente(){
            string pasta = PATH.Split("/")[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Cliente> Ler(){
            List<Cliente> clientes = new List<Cliente>();

            string[] linhas1 = File.ReadAllLines(PATH);

            foreach (var item in linhas1)
            {
                string[] atributos1 = item.Split(";");

                Cliente cli = new Cliente();
                cli.Nome = atributos1[0];
                cli.RG = float.Parse(atributos1[1]);
                cli.Idade = int.Parse(atributos1[2]);
                clientes.Add(cli);

            }

            return clientes;
        }

        public void Inserir(Cliente cliente)
        {
            string[] linhas1 = {PrepararLinhaCSV(cliente)};
            File.AppendAllLines(PATH, linhas1);
        }

        public string PrepararLinhaCSV(Cliente clie)
        {
            return $"{clie.Nome};{clie.RG};{clie.Idade}";
        }

    }
}