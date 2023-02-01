using System;

namespace practica_18._2
{
    class Program
    {
        static int[,] create_massiv()
        {
            Random rnd = new Random();
            int[,] salary = new int[5, 12];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    salary[i, j] = rnd.Next(1, 10);
                    Console.Write(salary[i, j] + " ");
                }
                Console.WriteLine();
            }
            return salary;
        }

        static void all_salaru(int[,] massiv)
        {
            int sum = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите номер сотрудника");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number > 5 & number <= 0) Console.WriteLine("Такого работника нет");
                    else
                    {
                        for(int i = number - 1; i < number; i++)
                        {
                            for(int j = 0; j < massiv.GetLength(1); j++)
                            {
                                sum += massiv[i,j];
                            }
                        }
                        Console.WriteLine($"Годовой заработок {number} сотрудника равен {sum}");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }

            }
        }
        

        static void Main(string[] args)
        {
            //13 вариант
            int[,] array = create_massiv();
            all_salaru(array);
            Console.ReadLine();
        }


    }
}
