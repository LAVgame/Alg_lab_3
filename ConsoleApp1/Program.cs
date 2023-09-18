using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            sw.Start();
            Console.WriteLine("Введи размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            Random rnd = new Random();
            Console.Write("Какое число желаете найти?: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i< n; i++) 
            {
                Arr[i] = rnd.Next(-20,20);
                if (Arr[i] == k) Console.WriteLine($"Arr[{i}] = {Arr[i]}");
            }

            sw.Stop();
            Console.WriteLine($"Время работы: {sw.Elapsed}" );
        }
    }
}
