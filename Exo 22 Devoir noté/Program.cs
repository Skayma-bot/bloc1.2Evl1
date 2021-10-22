using System;

namespace Exo_22_Devoir_noté
{
    class Program
    {
        static void Main(string[] args)
        {
            int notes, sommes = 0, superieur = 0, inférieur = 0;
            notes = 0;
            for (int a = 0; a < 10; a++)

            {
                bool correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.WriteLine("Donner 10 notes de 0 à 20 =");
                        notes = int.Parse(Console.ReadLine());
                        correct = true;


                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie : Donner un nombre entre 0 et 20");
                    }
 
                }
                if (notes < 10 && notes >= 0)
                {
                    inférieur++;
                    Console.WriteLine($"La notes est inférieur à 10 : Il y a {inférieur} notes inférieur à 10");
                    sommes = notes + sommes;

                }
                if (notes >= 10 && notes <= 20)
                {
                    superieur++;
                    Console.WriteLine($"La notes est supérieur à 10: Il y a {superieur} notes supérieur à 10");
                    sommes = notes + sommes;


                }

                



            }
            Console.WriteLine("La moyenne est :" + sommes / 10);
            Console.WriteLine($"Le nombre de notes supérieur est {superieur} et le nombre de notes inférieur est de {inférieur} ");
            Console.ReadLine();
        }
    }
}
