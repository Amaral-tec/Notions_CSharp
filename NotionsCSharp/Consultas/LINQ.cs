using System;

namespace NotionsCSharp.Consultas {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ {

        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8},
            };

            Console.WriteLine("== Aprovados =================");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada =================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por Idade) ====");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(
                aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = alunos.First(Aluno => Aluno.Nome.Equals("Ana")); //Last ---OrDefault
            Console.WriteLine(ana.Nota);

            // Pular itens da lista
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            var mediaAprovados = alunos.Where(a => a.Nota >= 7).Average(Aluno => Aluno.Nota);
            Console.WriteLine(mediaAprovados);
        }
    }
}
