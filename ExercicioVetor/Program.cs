using System;
using System.Globalization;

namespace ExercicioVetor {
    class Program {
        static void Main(string[] args) {

            /* A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados de 0 a 9.
             * Quando um estudante deseja alugar um quarto, deve-se registrar o nome e e-mail deste estudante.
             * 
             * Fazer um programa que inicie com todos os dez quartos vazios, e depois leia a quantidade N representando o número de 
             * estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. Para cada
             * registro de aluguel, informar o nome e e-mail do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
             * que seja escolhido um quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato,
             * por ordem de quarto.
             */

            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine("Quarto #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);        
                }
            }


        }
    }
}