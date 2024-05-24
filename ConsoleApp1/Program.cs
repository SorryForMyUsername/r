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
            //Задача 1
            //Console.Write("x= ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={x + y}");

            //Задача 2
            //Console.Write("x= ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("z= ");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}+{z}={x + y + z}");

            //Задача 3
            //Console.Write("x= ");
            //double x = Double.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //double y = Double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x:N1}*{y:N1}={x*y:N1}");

            //Задача 4
            //Console.Write("x= ");
            //double x = Double.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //double y = Double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x:N3}/{y:N3}={x / y:N3}");

            //Задача 5
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a}+{b}={b}+{a}");

            //Задача 6
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"a+b={a}+{b}={a+b}\ta-b={a}-{b}={a-b}\ta*b={a}*{b}={a*b}");

            //Задача 7
            //Console.Write("Как тебя зовут? ");
            //string name = Console.ReadLine();
            //Console.Write("Сколько тебе лет? ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{name}, ты родился в {DateTime.Now.Year - age} году");

            //Задача 8
            //Console.Write("Номинал купюры = ");
            //int nominal = int.Parse(Console.ReadLine());
            //Console.Write("Количество купюр = ");
            //int all = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Сумма денег= {nominal*all:N2}р.");

            //Задача 9
            //Console.Write("Сторона квадрата = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Периметр квадрата = {4 * a}");

            //Задача 10
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Периметр прямоугольниака = {2*(a+b)}");

            //Задача 11
            //Console.Write("Радиус = ");
            //int r = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Длина окружности = {2*Math.PI*r}");

            //Задача 12
            //Console.Write("Объём флешки в Гб - ");
            //int v = int.Parse(Console.ReadLine());
            //Console.WriteLine($"На это флешке помещается {v * 1024 / 820} файла(-ов), размером 820 Мб");

            //Задача 13
            //Console.Write("Введите двухзначное число: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Число в десятках - {a/10}\nЧисло в единицах - {a%10}");

            //Задача 14
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 0)
            //{
            //    Console.WriteLine($"y = {Math.Sqrt(x) + 2 * Math.Sin(x)}");
            //}
            //else
            //{
            //    Console.WriteLine($"y = {6 - Math.Pow(x, 2)}");
            //}

            //Задача 15
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            if (x <= -5)
            {
                Console.WriteLine($"y = {Math.Pow(x, 2) + 15*x}");
            }
            else if (x >= 5)
            {
                Console.WriteLine($"y = {(3*x+1)/5}");
            }
            else
            {
                Console.WriteLine($"y = {Math.Sqrt(13+x)}");
            }

            Console.Read();
        }
    }
}
