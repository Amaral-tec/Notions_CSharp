using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsCSharp.OrientacaoObjetos {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;       
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade <0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);    
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {
        public Uno() : base(200) {

        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(350) {
        
        }

        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        // Oculta o método da classe Pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca {

        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            /* O método Frear atribui o valor definido na classe Carro
             * Porque o método está oculto na classe Ferrari
             * Já o método acelerar mantem o definido na classe Ferrari
             * por ser um método subscrito
             */
            Console.WriteLine("Ferrari com tipo carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear()); 
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
