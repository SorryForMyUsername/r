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
            //Задача 18
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //if(x > 0)
            //{
            //    Console.WriteLine($"x={++x}");
            //}
            //else
            //{
            //    Console.WriteLine($"x={x -= 2}");
            //}  

            //Задача 2
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //if(x > 0)
            //{
            //    Console.WriteLine($"Число {x} - положительное");
            //}
            //if (x < 0)
            //{
            //    Console.WriteLine($"Число {x} - отрицательное");
            //}
            //if (x == 0)
            //{
            //    Console.WriteLine($"Число {x} - нулевое");
            //}

            //Задача 40
            //for(int i = 1; i <= 11; i += 2)
            //{
            //    if(i != 3)
            //    {
            //        Console.Write($"{i}\t");
            //    }
            //}

            //Задача 45
            for(int i = 0; i < 20; i++)
            {
                if(i == 1)
                {
                    Console.WriteLine($"{i} штука товара стоит {(i + 1) * 20.4} руб.");
                }
                if(i < 5 && i > 1)
                {
                    Console.WriteLine($"{i} штуки товара стоит {(i + 1) * 20.4} руб.");
                }
                if(i <= 20 && i >= 5)
                {
                    Console.WriteLine($"{i} штук товара стоит {(i + 1) * 20.4} руб.");
                }
            }

            Console.ReadKey();
        }
    }
}
