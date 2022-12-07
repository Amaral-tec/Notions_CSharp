using System;

namespace Encapsulamento {
    public class SubCelebridade {

        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herança
        protected string CorDoOlho = "Verde";

        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511999999999;

        // Herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "uso muitas gírias";

        // Mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        // Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
