using System;

namespace NotionsCSharp.ClassesEMetodos {
    class Pessoa {

        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        
        }
    }
}
