using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsCSharp.Excecoes {

    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }

    class UsandoExcecoes {

        public static void Executar() {
            var conta = new Conta(1_223.45);

            try {
                conta.Sacar(1900);
                Console.WriteLine("Retirada com sucesso!");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally { 
                Console.WriteLine("Obrigado!");
            }
        }
    }
}

