using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("Veuillez entrer la longeur  : ");
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            double max = double.MinValue;
            double min = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"number #{i + 1} : ");
                if (double.TryParse(Console.ReadLine(), out double number) && number >= 0)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre non négatif valide.");
                    i--;
                }
            }

            Console.WriteLine($"Le maximum est : {max}");
            Console.WriteLine($"Le minimum est : {min}");
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre valide pour le nombre de valeurs à saisir.");
        }
    }
}