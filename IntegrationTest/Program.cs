using System;
using System.Collections.Generic;
using IntegrationTest;

namespace IntegrationTest
{
    internal class Program
    {
        public static double first(double x)
        {
            x = (x * Math.PI) / 180;
            Console.WriteLine("Значение x  в радианах = " + Math.Round(x, 4));

            Sinus sin = new Sinus();
            double s = sin.show(x);
            Cosin cos = new Cosin();
            double c = cos.show(x);
            Console.WriteLine("sin = " + Math.Round(s, 2) + ", cos = " + Math.Round(c, 2));

            double otv = s + c + Math.Pow(c, 2);
            Console.WriteLine("Результат вычислений = " + Math.Round(otv, 4));
            return Math.Round(otv, 4);
        }

        public static double second(double x)
        {
            NLogarifm nl = new NLogarifm();
            double ln = nl.show(x);
            Console.WriteLine("ln = " + Math.Round(ln, 2) + ", math = " + Math.Round(Math.Log(x), 2));
            Logarifm lg = new Logarifm();
            double log = lg.show(x);
            Console.WriteLine("log = " + Math.Round(log, 2) + ", math = " + Math.Round(Math.Log(x, 5), 2));

            double otv = ln * log;
            Console.WriteLine("Результат вычислений = " + Math.Round(otv, 4));
            return Math.Round(otv, 4);
        }


        static int Main(string[] args)
        {
            double x;
            while (true)
            {
                Console.Write("Введите значение x: ");
                try
                {
                    x = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Вы ввели неверное значение! Повторите ввод!");
                }
            }

            if (x <= 0)
            {
                first(x);
                return 0;

                //if (Sinus.Sin(x) == 0) // Проверка синуса 0 градусов
                //{
                //    Console.WriteLine(Sinus.Sin(x));
                //    return 1;
                //}
                //else
                //    return 0;

                //if (Cosin.Cos(x) == 1) // Проверка косинуса 0 градусов
                //{
                //    Console.WriteLine(Cosin.Cos(x));
                //    return 1;
                //}
                //else
                //    return 0;

                //if (first(x) == 2)// Проверка решения 1 уравнения из системы при вводе х равного 0
                //    return 1;
                //else
                //    return 0;

            }
            else
            {
                x = (x * Math.PI) / 180; // используется для проверки синуса и косинуса

                second(x);
                return 1;

                //if (Sinus.Sin(x) == 1) // Проверка синуса 90 градусов
                //    return 1;
                //else
                //    return 0;

                //if (Sinus.Sin(x) == 0) // Проверка синуса 180 градусов
                //    return 1;
                //else
                //    return 0;


                //if (Cosin.Cos(x) == 0) // Проверка косинуса 90 градусов
                //    return 1;
                //else
                //    return 0;

                //if (Cosin.Cos(x) == -1) // Проверка косинуса 180 градусов
                //    return 1;
                //else
                //    return 0;


                //if (Logarifm.Log(x) == 3) // Проверка log5 для 125
                //{
                //    Console.WriteLine(Logarifm.Log(x));
                //    return 1;
                //}
                //else
                //    return 0;

                //if (Logarifm.Log(x) == 4) // Проверка log5 для 625
                //{
                //    Console.WriteLine(Logarifm.Log(x));
                //    return 1;
                //}
                //else
                //    return 0;

                //if (Math.Round(NLogarifm.LN(x),3) == Math.Round(Math.Log(x), 3) ) // Проверка ln 
                //{
                //    Console.WriteLine(NLogarifm.LN(x));
                //    return 1;
                //}
                //else                
                //    return 0;

                //if (Math.Round((Math.Log(x) * Math.Log(x, 5)), 4) == second(x))  //Проверка решения 2 уравнения системы
                //    return 1;
                //else
                //    return 0;
            }

        }
    }
}