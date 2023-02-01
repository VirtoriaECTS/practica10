using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
	class Program
	{

		static string input(string text) //масив для быстрого ввода строки
		{
			Console.WriteLine(text);
			string user = Console.ReadLine();
			return user;
		}
		static string[,] size_table() //размеры таблицы с работника
		{
			int n = 0, m = 0;
			while (n == 0)
			{
				n = Convert.ToInt32(input("Введите количество работников"));
				if (n == 0) Console.WriteLine("Количесвто работников не может быть равно нулю");
			}

			while (m == 0)
			{
				m = Convert.ToInt32(input("Введите количество месяцев"));
				if (m == 0) Console.WriteLine("Количесвто месяцев не может быть равно нулю");
			}
			string[,] work = new string[n + 1, m + 2];
			return work;
		}

		static string[,] create_table(string[,] work) //создание таблицы
		{
			for (int n = 0; n < work.GetLength(0); n++)
			{
				for (int m = 0; m < work.GetLength(1); m++)
				{
					if (n == 0)
					{
						if (m == 0) work[n, m] = "            ";
						else if (m == 1) work[n, m] = "Дата рождения  ";
						else work[n, m] = $"{m - 1} месяц     ";

					}
					if (n > 0 & m == 0) work[n, m] = $"{n} работник  ";
					if (m == 1 & n > 0)
					{

						while (true)
						{
							try
							{
								DateTime dt;
								Console.WriteLine($"Введите дату рождение {n} работника. Пример: 8/09/1980");
								dt = DateTime.Parse(Console.ReadLine());
								work[n, m] = dt.ToString("d MMM yyyy") + "      ";
								break;
							}
							catch
							{
								Console.WriteLine("Вы вели дату неправильно");
							}
						}
					}
					if (m > 1 & n > 0)
					{
						while (true)
						{
							try
							{
								Console.WriteLine($"Введите зароботную плату {n} сотрудника за {m - 1} месяц");
								int z = Convert.ToInt32(Console.ReadLine());
								work[n, m] = Convert.ToString(z + "         ");
								break;
							}
							catch
							{
								Console.WriteLine("Вы вели зарплату неверно");
							}
						}
					}
				}

			}
			return work;
		}

		static void print(string[,] work) //вывод масива
		{
			for (int n = 0; n < work.GetLength(0); n++)
			{
				for (int m = 0; m < work.GetLength(1); m++)
				{
					Console.Write(work[n, m]);
				}
				Console.WriteLine();
			}
		}

		static void big_salary(string[,] work) //наибольшая зарплата n сотрудника
		{
			while (true)
			{
				try
				{
					int human = Convert.ToInt32(input("Введите номер сотрудника что бы узнать его наибольшую зарплату"));
					int max = Convert.ToInt32(work[human, 2]);

					for (int n = human; n < human + 1; n++)
					{
						for (int m = 2; m < work.GetLength(1); m++)
						{
							if (max < Convert.ToInt32(work[n, m])) max = Convert.ToInt32(work[n, m]);
						}
						Console.WriteLine();
					}
					Console.WriteLine($"Наибольшя зарплата {human} сотрудника равна {max}");
					break;
				}
				catch
				{
					Console.WriteLine("Ошибка");
				}
			}

		}
		static string[,] working_tabel(string[,] table) //табель рабочих и выходных дней
		{
			string[,] day_off_on = new string[table.GetLength(0), table.GetLength(1) - 1];
			for (int n = 0; n < day_off_on.GetLength(0); n++)
			{
				for (int m = 0; m < day_off_on.GetLength(1); m++)
				{
					if (n == 0)
					{
						if (m == 0) table[n, m] = "\t\t\t\t";
						else table[n, m] = $"{m} месяц\t\t\t\t\t\t\t\t\t";

					}
					if (n > 0 & m == 0) table[n, m] = $"{n} работник  ";
					
					if (m > 0 & n > 0)
					{
						while (true)
						{
							try
							{
                                Console.WriteLine($"Введите количество выходных {n} сотрудника за {m} месяц");
                                int work_day = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine($"Введите количество выходных {n} сотрудника за {m} месяц");
								int vh_day = Convert.ToInt32(Console.ReadLine());

								table[n, m] = Convert.ToString($"\t\t\t{work_day} рабочих дней и {vh_day} выходных\t\t");
								break;
							}
							catch
							{
								Console.WriteLine("Ошибка. Пожалуйста, введите число");
							}
						}
					}
				}

			}
			return table;
		}

		static void age() //задание 5.1
		{
			int years = Convert.ToInt32(input("Введите возраст"));
			string text = "";
			if (years >= 11 & years <= 15) text = "лет";
			else if (years % 10 == 1) text = "год";
			else if (years % 10 >= 2 & years % 10 <= 4) text = "года";
			else text = "лет";
			Console.WriteLine($"{years} {text}");

        }

		static void date()
		{
			while (true)
			{
				try
				{
                    DateTime dt;
                    string day = Convert.ToString(input("Введите день"));

                    dt = DateTime.Parse(day + "/" + input("Введите месяц"));
                    string anwers = Convert.ToString(dt.ToString("d MMMM"));
                    Console.WriteLine($"{anwers}");
                }
				catch
				{
					Console.WriteLine("Ошибка");
				}
			}
            
        }
		static void Main(string[] args)
		{
			/*string[,] table = size_table();
			table = create_table(table);
			print(table);
			big_salary(table);
			string[,] work_tabl = working_tabel(table);
			print(work_tabl);*/
			age();
			date();
			Console.ReadKey();
		}
	}
}