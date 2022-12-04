using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NotionsCSharp.MetodosEFuncoes {
    class DelegateComoParametro {

        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) {
            return x + y;       
        }

        public static string Calculadora(Operacao operacao, int x, int y) {
            var resultado = operacao(x, y);
            return "Resultado: " + resultado;
        }

        public static void Executar() {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3, 2));

            // Usando função pré-existente aderente as caracteristicas do delegate
            Console.WriteLine(Calculadora(Soma, 3, 2));         
        }
    }
}
