using System;
using System.IO;

namespace NotionsCSharp.API {

    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class CriandoArquivo {

        public static void Executar() {
            var path = @"~/criando_arquivo_teste.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Arquivo teste");
                    sw.WriteLine("");
                    sw.WriteLine("Gerando arquivo...");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("Editando arquivo teste");
            }
            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine("por gentileza, verificar no local defino para arquivamento.");
        }
    }
}
