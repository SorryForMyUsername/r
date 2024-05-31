using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 14
            //Console.Write("x=");
            //double y;
            //int x = int.Parse(Console.ReadLine());
            //if(x >= 0)
            //{
            //    y = Math.Sqrt(x) + 2 * Math.Sin(x);
            //}
            //else
            //{
            //    y = 6 - Math.Pow(x, 2);
            //}
            //Console.WriteLine($"y = {y:f2}");

            //Задача 15
            //Console.Write("x = ");
            //double x = Double.Parse(Console.ReadLine());
            //double y = 0;
            //if (x <= -5)
            //{
            //    y = Math.Pow(x, 2) + 15 * x;
            //}
            //if (x >= 5)
            //{
            //    y = (3 * x + 1) / 5;
            //}
            //if (x > -5 && x < 5)
            //{
            //    y = Math.Sqrt(13 + x);
            //}
            //Console.WriteLine($"y = {y:f2}");

            //Задача 16
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //double z;
            //if (x >= 0)
            //{
            //    z = 2 + 3 * Math.Sqrt(x);
            //}
            //else
            //{
            //    z = 1 - 2 * Math.Pow(x, 2);
            //}
            //Console.WriteLine($"z = {z:f2}");

            //Задача 17
            //Console.Write("x = ");
            //double x = Double.Parse(Console.ReadLine());
            //double y;
            //if(x <= -5)
            //{
            //    y = Math.Sqrt(13 - x);
            //}
            //else if(x > -5 && x < 5)
            //{
            //    y = Math.Abs(4 * x - 5);
            //}
            //else
            //{
            //    y = 3 * Math.Pow(x, 2) - 5 * x;
            //}
            //Console.WriteLine($"y = {y:f2}");

            //Задача 18
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //if(x >= 0)
            //{
            //    x++;
            //}
            //else
            //{
            //    x -= 2;
            //}
            //Console.WriteLine($"x = {x}");

            //Задача 19 
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //if(x > 0)
            //{
            //    x++;
            //}
            //if(x < 0)
            //{
            //    x -= 2;
            //}
            //if(x == 0)
            //{
            //    x = 10;
            //}
            //Console.WriteLine($"x = {x}");

            //Задача 20
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //if(x > 0)
            //{
            //    Console.WriteLine($"Число {x} положительное");
            //}
            //if(x < 0)
            //{
            //    Console.WriteLine($"Число {x} отрицательное");
            //}
            //if(x == 0)
            //{
            //    Console.WriteLine($"Число {x} нулевое");
            //}

            //Задача 21
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());
            //if(a == b && b == c)
            //{
            //    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} - равносторонний");
            //}

            //Задача 23
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int x = rnd.Next(-30, 30);
            //    if (x > 0)
            //    {
            //        Console.WriteLine($"Число {x} - положительное");
            //    }
            //    if (x < 0)
            //    {
            //        Console.WriteLine($"Число {x} - отрицательное");
            //    }
            //}

            //Задача 24
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                int x = rnd.Next(-20, 30);
                if(x % 2 == 0)
                {
                    Console.WriteLine($"Число {x} чётное");
                }
                else
                {
                    Console.WriteLine($"Число {x} нечётное");
                }
            }

            Console.Read();
        }
    }
}
