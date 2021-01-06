using System.IO;

namespace MVC_Console.Models
{
    public class Cliente
    {
        public float RG { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        private const string PATH1 = "Database/Cliente.csv";

        public Cliente(){
            string pasta = PATH1.Split("/")[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH1))
            {
                File.Create(PATH1);
            }
        }

    }
}