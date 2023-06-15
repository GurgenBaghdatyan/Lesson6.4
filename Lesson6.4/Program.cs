using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n], y = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = 250 - rnd.Next(500);
                Console.Write(x[i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] > 0)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] != 0)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] % 2 == 1 || x[i] % 2 == -1)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0, j = 0; i < n; i++)
            {
                if (i >= a && i <= b)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] % a == 0)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] != i)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");

            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] * x[i] > a && x[i] * x[i] < b)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = '\n';
            }
            Console.WriteLine("\n");
            for (int i = 0, j = 0; i < n; i++)
            {
                if (x[i] % 6 == 1)
                {
                    y[j] = x[i];
                    Console.Write(y[j] + " ");
                    j++;
                }
            }






            Console.ReadKey();
        }
    }
}
