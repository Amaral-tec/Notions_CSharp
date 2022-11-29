using System;

namespace NotionsCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            /* A interrogação garante que Length só será
             * acessado se a variavel valorImportante seja diferente de null
             * --- Conceito de Navegação Segura ---
             */

        }
    }
}
