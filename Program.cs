using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei, sau 0 pentru a opri programul: ");

            int n;
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                CallMethod($"p{n}");
                Console.WriteLine("Introduceti numarul problemei, sau 0 pentru a opri programul: ");
                n = int.Parse(Console.ReadLine());
            }
        }

        public static void CallMethod(string method)
        {
            try
            {
                Type type = typeof(Program);
                MethodInfo methodInfo = type.GetMethod(method);
                methodInfo.Invoke(method, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
        }

        public static void p1()
        {
            float a, b;
            Console.WriteLine("Introduceti a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b");
            b = float.Parse(Console.ReadLine());

            float x = -b / a;
            Console.WriteLine($"Rezultatul este: {x}");
        }

        public static void p2()
        {
            float a, b, c;
            Console.WriteLine("Introduceti a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c");
            c = float.Parse(Console.ReadLine());
            float D = b * b - 4 * a * c;

            if(D > 0)
            {
                double x1, x2;
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"Rezultatele sunt: {x1}; {x2}");
                return;
            }

            if(D == 0)
            {
                double x = -b/(2 * a);

                Console.WriteLine($"Rezultatul este: {x}");
                return;
            }

            if (D < 0)
            {
                double x1, x2;
                x1 = -b / (2 * a);
                x2 = Math.Sqrt(Math.Abs(D)) / (2 * a);

                Console.WriteLine($"Rezultatele sunt: {x1}-{x2}i; {x1}+{x2}i");
                return;
            }

        }
        public static void p3()
        {
            int n, k;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu ${k}");
            else
                Console.WriteLine($"{n} nu se divide cu {k}");
        }

        public static void p4()
        {
            int y;
            Console.WriteLine("Introduceti anul");
            y = int.Parse(Console.ReadLine());

            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
                Console.WriteLine("An bisect");
            else
                Console.WriteLine("Nu este an bisect");
        }

        public static void p5()
        {
            int n, k;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k");
            k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= k - 1; i++)
                n /= 10;

            Console.WriteLine($"A k-a cifra de la dreapta: {n % 10}");
        }

        public static void p6()
        {
            float a, b, c;
            Console.WriteLine("Introduceti a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c");
            c = float.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine($"{a} {b} {c} pot fi lungimile laturilor unui triunghi");
            else
                Console.WriteLine($"{a} {b} {c} NU pot fi lungimile laturilor unui triunghi");
        }

        public static void p7()
        {
            float a, b, c;
            Console.WriteLine("Introduceti a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b");
            b = float.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"a: {a} b: {b}");

        }

        public static void p8()
        {
            float a, b;
            Console.WriteLine("Introduceti a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b");
            b = float.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a: {a} b: {b}");

        }

        public static void p9()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n/2; i++)
                if(n%i==0) Console.Write($"{i} ");

            Console.Write(n);
            Console.WriteLine();
        }

        public static void p10()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());


            if(n < 2)
            {
                Console.WriteLine("Nu este prim");
                return;
            }

            if(n == 2)
            {
                Console.WriteLine("E prim");
                return;
            }

            if (n % 2 == 0)
            {
                Console.WriteLine("Nu este prim");
                return;
            }

            for (int i = 3; i*i < n; i++)
                if (n % i == 0)
                {
                    Console.WriteLine("Nu este prim");
                    return;
                }


            Console.WriteLine("E prim");
        }

        public static void p11()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            
            while(n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }

            Console.WriteLine();
        }

        public static void p12()
        {
            int n, a, b;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b");
            b = int.Parse(Console.ReadLine());

            int c = 0;
            for (int i = a; i <= b; i++)
                if (i % n == 0) c++;

            Console.WriteLine($"In [{a}, {b}] sunt {c} numere divizibile cu {n}");
        }

        public static void p13()
        {
            int y1, y2;
            Console.WriteLine("Introduceti anul 1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti anul 2");
            y2 = int.Parse(Console.ReadLine());

            int c = 0;
            for(int i = y1; i <= y2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    c++;
            }

            Console.WriteLine($"Intre {y1} si {y2} sunt {c} ani bisecti");
        }

        public static void p14()
        {
            int n, x, y=0;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());

            x = n;
            while (x > 0)
            {
                y = y * 10 +x % 10;
                x /= 10;
            }

            if (n == y)
                Console.WriteLine("Palindrom");
            else
                Console.WriteLine("Nu este palindrom");

        }

        public static void p15()
        {
            float x, y, z;
            Console.WriteLine("Introduceti x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z");
            z = float.Parse(Console.ReadLine());

            float min = Math.Min(Math.Min(x, y), z);
            float max = Math.Max(Math.Max(x, y), z);

            Console.WriteLine($"{min} {x+y+z-min-max} {max}");

        }

        public static void p16()
        {
            float a, b, c, d, e;
            Console.WriteLine("Introduceti a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti d");
            d = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti e");
            e = float.Parse(Console.ReadLine());

            float x;

            for(int i = 0; i < 5; i++)
            {
                if(a > b)
                {
                    x = a;
                    a = b;
                    b = x;
                }

                if (b > c)
                {
                    x = b;
                    b = c;
                    c = x;
                }

                if (c > d)
                {
                    x = c;
                    c = d;
                    d = x;
                }

                if (d > e)
                {
                    x = d;
                    d = e;
                    e = x;
                }

            }

            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }

        public static int euclid(int a, int b)
        {
            if (a == 0)
                return b;

            return euclid(b % a, a);
        }

        public static void p17()
        {
            int x, y;

            Console.WriteLine("Introduceti x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cel mai mare divizor comun: {euclid(x, y)}; cel mai mic multiplu comun: {x*y/euclid(x, y)}");
        }

        public static void p18()
        {
            int x, j;
            bool firstTime = true;
            //Ca sa nu afiseaza un x in plus

            Console.WriteLine("Introduceti x");
            x = int.Parse(Console.ReadLine());

            for(int i = 2; i <= x; i++)
            {
                if (x % i == 0)
                {
                    for (j = 0; x % i == 0; j++)
                        x /= i;

                    if (firstTime)
                    {
                        Console.Write($"{i}^{j}");
                        firstTime = false;
                    }
                    else
                        Console.Write($" x {i}^{j}");
                }


            }

            Console.WriteLine();
        }

        public static void p19()
        {
            int x;

            Console.WriteLine("Introduceti x");
            x = int.Parse(Console.ReadLine());

            int[] cifre = new int[10];

            while (x > 0)
            {
                cifre[x % 10]=1;
                x /= 10;
            }

            int c = 0;

            for (int i = 0; i < cifre.Length; i++)
                c += cifre[i];

            if (c == 2)
                Console.WriteLine("Numarul este format doar cu 2 cifre");
            else
                Console.WriteLine("Numarul NU este format doar cu 2 cifre");
        }

        public static void p20()
        {
            int m, n;

            Console.WriteLine("Introduceti numaratorul");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numitorul");
            n = int.Parse(Console.ReadLine());

            
            int intPart = m / n;

            m -= n * intPart;

            List<int> remainders = new List<int>();

            string fracPart = "";

            if(m > 0)
            {
                fracPart = ",";
                while(m > 0 && !remainders.Contains(m))
                {
                    remainders.Add(m);
                    m *= 10;
                    fracPart += m / n;
                    m %= n;
                }

                if(remainders.Contains(m))
                    fracPart = fracPart.Insert(remainders.IndexOf(m) + 1, "(") + ")";
            }

            string Decimal = intPart + fracPart;

            Console.WriteLine(Decimal);
        }

        public static void p21()
        {
            Random rnd = new Random();

            int x = rnd.Next(1, 1025);

            int guess;

            ConsoleColor defaultColor = Console.ForegroundColor;

            do
            {
                Console.WriteLine("Incercati sa ghiciti numarul: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > x)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{guess} este mai mare decat numarul");
                }

                if (guess < x)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{guess} este mai mic decat numarul");
                }

                Console.ForegroundColor = defaultColor;

            } while (guess != x);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Numarul este: {x}");
            Console.ForegroundColor = defaultColor;
        }

    }
}
