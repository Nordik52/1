using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите количество элементов N:");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Масив:");
                int[] a = new int[N];
                Random r = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = r.Next(-10, 11);
                    Console.Write(a[i] + "\t");
                }
                Console.WriteLine("\t");
                int x = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0)
                    {
                        x++;
                    }
                }
                Console.WriteLine("Количество положительных чисел:" + x);
                int y = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < 0)
                    {
                        y++;
                    }
                }
                Console.WriteLine("Количество отрицательных чисел:" + y);
                int z = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 0)
                    {
                        z++;
                    }
                }
                Console.WriteLine("Количество нулей:" + z);
        }
    }
}
