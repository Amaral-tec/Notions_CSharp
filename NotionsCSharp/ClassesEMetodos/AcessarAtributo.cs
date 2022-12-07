using System;

namespace NotionsCSharp.ClassesEMetodos {
    class AcessarAtributo {

        int a = 10;

        public static void Executar() {
            // Acessar variável 'a' dentro do método Executar!

            AcessarAtributo atributo = new AcessarAtributo();
            Console.WriteLine(atributo.a);

            
        }
    }
}
