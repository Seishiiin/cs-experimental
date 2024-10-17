using System;

namespace cs_learn {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Saisissez un nombre : ");
            int nb = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Saisissez un deuxième nombre : ");
            int nb2 = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("|-- Choisissez une option --|");
            Console.WriteLine("|  1 - Addition            |");
            Console.WriteLine("|  2 - Soustraction        |");
            Console.WriteLine("|  3 - Multiplication      |");
            Console.WriteLine("|  4 - Division            |");
            Console.WriteLine("|  5 - Modulo              |");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("Votre choix : ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice) {
                case 1:
                    Console.WriteLine((nb) + " + " + (nb2) + " = " + (nb + nb2));
                    break;
                case 2:
                    Console.WriteLine((nb) + " - " + (nb2) + " = " + (nb - nb2));
                    break;
                case 3:
                    Console.WriteLine((nb) + " * " + (nb2) + " = " + (nb * nb2));
                    break;
                case 4:
                    Console.WriteLine((nb) + " / " + (nb2) + " = " + (nb / nb2));
                    break;
                case 5:
                    Console.WriteLine((nb) + " % " + (nb2) + " = " + (nb % nb2));
                    break;
                default:
                    Console.WriteLine("Veuillez choisir une option valide.");
                    break;
            }
        }
    }
}

