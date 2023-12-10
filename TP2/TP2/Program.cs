using System;

class Program
{
    static void Main()
    {
        int n;
        int countNegatives = 0;

        Console.Write("Veuillez entrer la longeur : ");
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Entrez un entier #{i + 1} : ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number < 0)
                    {
                        countNegatives++;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un entier valide.");
                    i--;
                }
            }

            Console.WriteLine($"Il y a {countNegatives} nombre négatif dans la série.");
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre valide pour le nombre d'entiers à saisir.");
        }
    }
}