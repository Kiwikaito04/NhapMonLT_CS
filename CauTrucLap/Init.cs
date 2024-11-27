using System;

namespace B3_CauTrucLap
{
    public static class Init
    {
        public static void Bai14()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            while (n >= 10)
            {
                n -= 7;
                m += 3;
            }
            Console.WriteLine("{0}", m);
        }

        public static void Bai13()
        {
            int n = 0;
            while (n < 1 || n > 10)
            {
                Console.Write("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,2} x {1,-2} = {2,-2}", j, i, j * i);
                    if (j < n) Console.Write("|");
                }
                Console.WriteLine();
            }
        }

        public static void Bai12()
        {
            double s = 0;
            for (int i = 0; i <= 19; i++)
                s = s + (((double)2 * i + 1) / Math.Pow(2, i));
            Console.WriteLine("S = {0}", s);
        }

        public static void Bai11()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
                s += (double)1 / i;
            Console.WriteLine("S = {0}", s);
        }

        public static void Bai10()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            if (n < 0) Console.WriteLine("0");
            else
            {
                for (int i = 1; i <= n; i++)
                    s *= i;
                Console.WriteLine("{0}! = {1}", n, s);
            }
        }

        public static void Bai9()
        {
            int n = 0;
            while (n < 100 || n > 500 || n % 2 == 1)
            {
                Console.Write("Nhap n (n thuoc [100,500] & n%2=0) :");
                n = int.Parse(Console.ReadLine());
            }
        }

        public static void Bai8()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; sum + i < n; i++)
                sum += i;
            Console.WriteLine(sum);
        }

        public static void Bai7()
        {
            int sum = 0;
            for (int i = 1; sum + i < 200000; i++)
                sum += i;
            Console.WriteLine(sum);
        }

        public static void Bai6()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            bool check = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
            if (check) Console.WriteLine("{0} la so nguyen to", n);
            else Console.WriteLine("{0} khong la so nguyen to", n);
        }

        public static void Bai5()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) Console.Write("{0} ", i);
            Console.WriteLine(n);
        }

        public static void Bai4()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;
            Console.WriteLine("Sum = {0}\nAvg = {1}", sum, (double)sum / n);
        }

        public static void Bai3()
        {
            int n = 1;
            while (n <= 1)
            {
                Console.Write("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 2; i <= n; i += 2)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        public static void Bai2()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        public static void Bai1()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }
    }
}
