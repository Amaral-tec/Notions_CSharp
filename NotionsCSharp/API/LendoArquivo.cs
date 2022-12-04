using System;
using System.IO;

namespace NotionsCSharp.API {
    class LendoArquivo {

        public static void Executar() {
            var path = @"~/lendo_arquivo_teste.txt".ParseHome();

            if(!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Arquivo Teste");
                    sw.WriteLine("");
                    sw.WriteLine("Lendo arquivo...");
                    sw.WriteLine("");
                    sw.WriteLine("Linha 1: Teste 1");
                    sw.WriteLine("Linha 2: Teste 2");
                    sw.WriteLine("Linha 3: Teste 3");
                }
            } 
            
            try {
                using (StreamReader sr = new StreamReader(path)) { 
                var texto = sr.ReadToEnd();
                Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
