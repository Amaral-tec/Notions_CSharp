using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsCSharp.ClassesEMetodos {

    public class Produto {

        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto) {
            Nome= nome;
            Preco = preco;
            Desconto = desconto;       
        }

        public Produto() {
        
        }

        public double CalculrDesconto() {
            return Preco - Preco * Desconto; 
        }
    }

    class AtributosEstaticos {

        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
            };

            // Por está em método estático o desconto é aplicado a toda a classe
            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalculrDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalculrDesconto());

            Produto.Desconto = 0.2;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalculrDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalculrDesconto());
        }
    }
}
