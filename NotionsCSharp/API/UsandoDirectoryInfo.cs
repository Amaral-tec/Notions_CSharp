using System;

namespace NotionsCSharp.API {
    class UsandoDirectoryInfo {

        public static void Executar() {
            var diretorioProjeto = "D:/CSharp/source/repos/NotionsCSharp/NotionsCSharp";

            var diretorioInfo = new DirectoryInfo(diretorioProjeto);

            if (!diretorioInfo.Exists) { 
                diretorioInfo.Create();
            }

            Console.WriteLine("== Arquivos ======================");
            var arquivos = diretorioInfo.GetFiles();
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n== Diretórios ==================");
            var pastas = diretorioInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(diretorioInfo.CreationTime);
            Console.WriteLine(diretorioInfo.FullName);
            Console.WriteLine(diretorioInfo.Root);
            Console.WriteLine(diretorioInfo.Parent);
        }
    }
}
