using System;

namespace NotionsCSharp.Consultas {
    class Dynamics {

        public static void Executar() {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);
            
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}
