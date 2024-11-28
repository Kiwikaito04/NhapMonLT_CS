using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_CauTrucTuanTu_LuaChon_Lap
{
    public static class Init
    {
        public static void Bai5()
        {
            do
            {
                Console.Clear();

                Console.Write("The number of products: ");
                int n = int.Parse(Console.ReadLine());

                int[] code = new int[n];
                int[] amount = new int[n];

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Code of Product {0,-3}: ", i);
                    code[i - 1] = int.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    amount[i - 1] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("{0,-3}|{1,-20}|{2,12}|{3,12}|{4,12}", "No", "PRODUCT NAME", "PRICE", "QUANTIY", "TOTAL(R$)");

                double total = 0;

                for (int i = 1; i <= n; i++)
                {
                    switch (code[i - 1])
                    {
                        case 1:
                            Console.WriteLine("{4,-3}|{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "Cochorro Quente", 4.00, amount[i - 1], 4.00 * amount[i - 1], i);
                            total += 4.00 * amount[i - 1];
                            break;
                        case 2:
                            Console.WriteLine("{4,-3}|{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "X-Salada", 4.50, amount[i - 1], 4.50 * amount[i - 1], i);
                            total += 4.50 * amount[i - 1];
                            break;
                        case 3:
                            Console.WriteLine("{4,-3}|{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "X-Bacon", 5.00, amount[i - 1], 5.00 * amount[i - 1], i);
                            total += 5.00 * amount[i - 1];
                            break;
                        case 4:
                            Console.WriteLine("{4,-3}|{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "Torrada simples", 2.00, amount[i - 1], 2.00 * amount[i - 1], i);
                            total += 2.00 * amount[i - 1];
                            break;
                        case 5:
                            Console.WriteLine("{4,-3}|{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "Refrigerante", 1.00, amount[i - 1], 1.00 * amount[i - 1], i);
                            total += 1.00 * amount[i - 1];
                            break;
                        default:
                            Console.WriteLine("{4,-3}|{0,-20}|{1,12}|{2,12}|{3,12}", "Error code", "Error", "Error", "Error", i);
                            break;
                    }
                }
                Console.WriteLine("TOTAL:{0,57:0.00}", total);
                Console.WriteLine("Thank you & Goodbye!");
                Console.Write("1 - continue / 0 - exit: ");
                int key = int.Parse(Console.ReadLine());
                while (key != 1 && key != 0)
                {
                    Console.WriteLine("Unknown Command!");
                    Console.Write("1 - continue / 0 - exit: ");
                    key = int.Parse(Console.ReadLine());
                }
                if (key == 0)
                    break;
            } while (true);
        }

        public static void Bai4()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());

            //Mau 1
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Mau 2
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Mau 3
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Mau 4
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                    if (j == 1 || j == i)
                        Console.Write("* ");
                    else Console.Write("  ");
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
                Console.Write("* ");
            Console.WriteLine();
            Console.WriteLine();
            /////////////////////////////////////////////
            //Mau 5
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }
            Console.WriteLine();

            //Mau 6
            int temp = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", temp);
                    temp++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Mau 7
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }
            Console.WriteLine();

            //Mau 8
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                    if (j == 1 || j == i)
                        Console.Write("{0} ", j);
                    else Console.Write("  ");
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        public static void Bai3()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int checker = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) checker += i;
            if (checker == n) Console.WriteLine("{0} la so hoan hao", n);
            else Console.WriteLine("{0} khong la so hoan hao", n);

        }

        public static void Bai2()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i += 2)
                Console.Write("{0} ", Math.Pow(i, 2));
            Console.WriteLine();
        }

        public static void Bai1()
        {
            Console.Write("Nhap x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y = ");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            x += 1;
            if (x % 2 == 0) x++;
            int sum = 0;
            for (int i = x; i < y; i += 2)
                sum += i;
            Console.WriteLine("Tong la {0}", sum);
        }
    }
}
