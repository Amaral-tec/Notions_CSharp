using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotionsCSharp.ClassesEMetodos;

namespace NotionsCSharp.Consultas {

    public class Caixa<T> {
        T valorPrivado;
        public T Valor { get; set; }

        public Caixa(T valor) {
            Valor = valor;
            valorPrivado = valor;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Valor : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    class CaixaProduto : Caixa<Produto> {
        public CaixaProduto() : base(new Produto()) {
        }
    }

    class Genericos {

        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(33));      
            Console.WriteLine(caixa1.Valor.GetType());    
            
            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Médoto"));
            Console.WriteLine(caixa2.Valor.GetType());

            // Recebendo um objeto
            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Valor.GetType().Name);
        }   
    }
}
