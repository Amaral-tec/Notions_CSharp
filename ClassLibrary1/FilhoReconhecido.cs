using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    class FilhoReconhecido : SubCelebridade {

        public new void MeusAcessos() {
            Console.WriteLine("FilhoReconhecido...");


            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);          
        }
    }
}
