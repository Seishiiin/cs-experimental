using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_learn {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Saisissez un nombre : ");
            string? nb1 = Console.ReadLine();
            
            Console.WriteLine("Saisissez un autre nombre : ");
            string? nb2 = Console.ReadLine();

            // Ajouter une séparation entre les saisies et les résultats
            Console.WriteLine();
            Console.WriteLine("|-------------------- RESULTATS --------------------|");
            
            if (nb1 != null && nb2 != null) {
                int nombre1 = int.Parse(nb1);
                int nombre2 = int.Parse(nb2);
                
                
                Console.WriteLine("La somme de " + nombre1 + " et " + nombre2 + " est égale à " + (nombre1 + nombre2));
                Console.WriteLine("La différence de " + nombre1 + " et " + nombre2 + " est égale à " + (nombre1 - nombre2));
                Console.WriteLine("Le produit de " + nombre1 + " et " + nombre2 + " est égale à " + (nombre1 * nombre2));
                Console.WriteLine("Le quotient de " + nombre1 + " et " + nombre2 + " est égale à " + (nombre1 / nombre2));
                Console.WriteLine("Le reste de la division de " + nombre1 + " par " + nombre2 + " est égale à " + (nombre1 % nombre2));
            }
        }
    }
}

