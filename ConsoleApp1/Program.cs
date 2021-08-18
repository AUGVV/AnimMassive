using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size = 10;
            int[,] integer = new int[Size, Size];
            Random rand = new Random();
            Console.WriteLine("Massive");
            while (true)
            {
                    for (int i = 0;i<9;i++)
                    {
                        MassiveOp(integer, Size, i, i+1);
                        Thread.Sleep(300);
                        Console.Clear();
                    }
            }

            static  void MassiveOp(int[,] integer, int Size, int Number1 = 0, int Number2 = 1)
            {
                for (int i = 0; i < Size; i++)
                {
                    int sum = 0;
                    Console.WriteLine("");
                    for (int j = 0; j < Size; j++)
                    {
                        if (j == i) //Диагонваль
                        {
                            integer[i, j] = Number1;
                            sum = sum + Number1;
                        }
                        else if (j == Size - 1 - i) //дополнительная диагональ
                        {
                            integer[i, j] = Number1;
                            sum = sum + Number1;
                        }
                        else if (i == i - j) //линия столбец
                        {
                            integer[i, j] = Number1;
                            sum = sum + Number1;
                        }
                        else if (i == Size - 1) //линия строка низ
                        {
                            integer[i, j] = Number1;
                            sum = sum + Number1;
                        }
                        else if (i == 0) //линия строка верх
                        {
                            integer[i, j] = Number1;
                            sum = sum + Number1;
                        }
                        else if (j == Size - 1) //линия последняя колонка
                        {
                            integer[i, j] = Number1;
                            sum = sum + Number1;
                        }
                        else
                        {
                            integer[i, j] = Number2;
                            sum = sum + Number2;
                        }
                        Console.Write(integer[i, j]);
                    }
                    Console.Write($" = {sum}");
                }
            }

        }
    }
}