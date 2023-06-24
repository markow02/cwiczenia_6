﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_slimak_2
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
            int dol = 0, gora = tablica.GetLength(0) - 1, lewo = 0, prawo = tablica.GetLength(1) - 1;

            while (liczba <= tablica.GetLength(0) * tablica.GetLength(1))
            {
                for (int j = lewo; j <= prawo; j++)
                {
                    tablica[dol, j] = liczba++;
                }
                dol++;

                for (int i = dol; i <= gora; i++)
                {
                    tablica[i, prawo] = liczba++;
                }
                prawo--;

                for (int j = prawo; j >= lewo; j--)
                {
                    tablica[gora, j] = liczba++;
                }
                gora--;

                for (int i = gora; i >= dol; i--)
                {
                    tablica[i, lewo] = liczba++;
                }
                lewo++;
            }

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
