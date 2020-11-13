using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Условие
                double E, e, e2, r1, r2, r3, q, q2, q3, f, f2, f3;
                E = 3;
                e = 1;
                e2 = (8.85 *Math.Pow(10,-12));

                //Решение q1
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("//ВЫЧИСЛЕНИЕ ЗАРЯДОВ Q1 - Q3//");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите r1:");
                r1 = double.Parse(Console.ReadLine());
                q = E * (4 * Math.PI * e2 * e * r1 * r1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Заряд q1: = {q}");

                //Решение q2
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Введите r2:");
                r2 = double.Parse(Console.ReadLine());
                q2 = E * (4 * Math.PI * e2 * e * r2 * r2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Заряд q2: = {q2}");

                //Решение q3
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите r3:");
                r3 = double.Parse(Console.ReadLine());
                q3 = E * (4 * Math.PI * e2 * e * r3 * r3);
                Console.ForegroundColor = ConsoleColor.Blue;

                //Решение f
                Console.WriteLine($"Заряд q3 = {q3}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ВЫЧИСЛЕНИЕ ПОТЕНЦИАЛОВ Q1 - Q3");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Введите r1:");
                r1 = double.Parse(Console.ReadLine());
                f = (E * r1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Потонциал f: = {0:F2}", f);

                //Решение f2
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Введите r2:");
                r1 = double.Parse(Console.ReadLine());
                f2 = (E * r2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Потонциал f2: = {0:F2}",f2);

                //Решение f3
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Введите r3:");
                r1 = double.Parse(Console.ReadLine());
                f3 = (E * r3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Потонциал f3: = {0:F2}",f3);

                //Нахождение Максимального предельного заряда q(max)
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("//////МАКСИМАЛЬНЫЙ ЗАРЯД//////");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.ForegroundColor = ConsoleColor.Blue;
                double max = q;
                if (q2 > max) max = q2;
                if (q3 > max) max = q3;
                Console.WriteLine("Наибольший заряд Q = " + max);
                Console.WriteLine("");

                //Нахождение минимального потенциала f(min)
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("////МИНИМАЛЬНЫЙ ПОТЕНЦИАЛ/////");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("//////////////////////////////");
                Console.ForegroundColor = ConsoleColor.Blue;
                double min = f;
                if (f2 < min) min = f2;
                if (f3 < min) min = f3;
                Console.WriteLine("Наименьший потенциал F = " + min);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}