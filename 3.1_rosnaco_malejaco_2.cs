using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_rosnaco_malejaco_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;

            while (true)
            {
                Console.WriteLine("Podaj wielkość tablicy:");

                if (int.TryParse(Console.ReadLine(), out size) && size >= 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Niepoprawna wartość. Wprowadź liczbę całkowitą większą lub równą 1.");
                }
            }

            int[,] tablica = new int[size, size];
            int liczba = 1;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                if (i % 2 == 0) // wiersze parzyste
                {
                    for (int j = 0; j < tablica.GetLength(1); j++)
                    {
                        tablica[i, j] = liczba++;
                    }
                }
                else // wiersze nieparzyste
                {
                    for (int j = tablica.GetLength(1) - 1; j >= 0; j--)
                    {
                        tablica[i, j] = liczba++;
                    }
                }
            }

            // Wypisanie tablicy
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
