using System;

class Program
{
    static void Main()
    {
        int count = 0;
        double sum = 0;

        Console.WriteLine("Entrez une série de nombres non négatifs");

        while (true)
        {
            Console.Write("Entrez un nombre : ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number >= 0)
                {
                    sum += number;
                    count++;
                }
                else
                {
                    break; 
                }
            }
            else
            {
                Console.WriteLine("Veuillez entrer un nombre valide.");
            }
        }

        if (count > 0)
        {
            double moyenne = sum / count;
            Console.WriteLine($"La moyenne des nombres est : {moyenne}");
        }
        else
        {
            Console.WriteLine("Aucun nombre non négatif saisi.");
        }
    }
}