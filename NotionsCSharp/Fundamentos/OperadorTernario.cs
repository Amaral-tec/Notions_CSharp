using System;

namespace NotionsCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var nota = 7.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

        }
    }
}
