using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NotionsCSharp.MetodosEFuncoes {
    class DelegateFuncaoAnonima {

        delegate string StringOperacao(string str);

        public static void Executar() {
            StringOperacao inverter = delegate (string str) {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }; 
            Console.WriteLine(inverter("C# é show!!!"));
        }
    }
}
