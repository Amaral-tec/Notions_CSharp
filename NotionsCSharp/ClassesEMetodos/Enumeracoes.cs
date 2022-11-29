using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsCSharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class Enumeracoes {

        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);


        }
    }
}
