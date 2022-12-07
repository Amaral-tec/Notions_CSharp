using System;
using System.Collections;

namespace NotionsCSharp.Colecoes {
    class ColecoesArrayList {

        public static void Executar() {

            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach (var item in arraylist) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
