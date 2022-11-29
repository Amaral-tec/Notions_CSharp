using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsCSharp.Colecoes {

    class ColecoesSet {

        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("5ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho) {
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            // O método Set é uma estrutura NÃO INDEXADA e que NÃO ACEITA itens duplicados
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
