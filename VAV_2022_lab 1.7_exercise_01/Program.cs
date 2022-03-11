using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        /*Два треугольника заданы длинами своих сторон. Определить, площадь какого из них
больше (создать метод для вычисления площади треугольника по длинам его сторон). Для решения задачи можно
использовать формулу Герона*/


        static void Main(string[] args)
        {
            // Объявление переменных для площадей и длин строн треугольников, переменную для сравнения
            double s1, a1, b1, c1, s2, a2, b2, c2, val;

            // Запрашиваем длины сторон треугольников
            Console.WriteLine("Введите длины сторон треугольника 1 (см): ");
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nВведите длины сторон треугольника 2 (см): ");
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());
            c2 = Convert.ToDouble(Console.ReadLine());

            // Вычисляем площади треугольников через вызов метода CalcP
            s1 = CalcSq1(a1, b1, c1);
            s2 = CalcSq2(a2, b2, c2);
            // Вычисляем разницу (<0, >0, ==0), будем использовать в операторе switch
            val = s1 - s2;

            // Выводим данные по обоим треугольникам для наглядности
            Console.WriteLine("\nДанные треугольника 1:\nСтороны {0}см {1}см {2}см\nПлощадь {3}кв.см", a1, b1, c1, s1);
            Console.WriteLine("\nДанные треугольника 2:\nСтороны {0}см {1}см {2}см\nПлощадь {3}кв.см", a2, b2, c2, s2);

            if (val > 0)
            {
                Console.WriteLine("\nПлощадь треугольника 1 больше");

            }
            if (val < 0)
            {
                Console.WriteLine("\nПлощадь треугольника 2 больше");

            }
            if (val == 0)
            {
                Console.WriteLine("\nПлощади треугольников равны");

            }
            Console.ReadKey();
        }


        // Метод для вычисления площади треугольника по формуле Герона
        static double CalcSq1(double a1, double b1, double c1)
        {
            double p1 = (a1 + b1 + c1) / 2;
            double s1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            return s1;
        }

        static double CalcSq2(double a2, double b2, double c2)
        {
            double p2 = (a2 + b2 + c2) / 2;
            double s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            return s2;
        }
    }
}


