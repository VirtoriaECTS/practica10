using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10_zad3
{
    class Program
    {
        
        static double[,] create_masiv()
        {
            Random rnd = new Random();
            double[,] array = new double[2, 12];
            for(int i = 0; i < 12; i++)
            {
                array[0, i] = rnd.Next(0, 100);
            }
            return array;
        }
        static double[,] division_by_seven(double [,] array)
        {
            for(int i = 0; i < 12; i++)
            {
                array[1, i] = array[0, i] / 7;
            }
            return array;
        }
        static void print(double[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Задание 3
            double[,] array = create_masiv();
            array = division_by_seven(array);
           print(array);
            Console.ReadLine();
        }
    }
}
