using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucLuaChon
{
    internal static class Init
    {
        public static void Bai11()
        {
            Console.Write("Nhap x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y = ");
            double y = double.Parse(Console.ReadLine());
            if (x == 0 && y == 0) Console.WriteLine("Diem thuoc goc toa do");
            else if (x == 0 && y != 0) Console.WriteLine("Diem thuoc tren truc Oy");
            else if (x != 0 && y == 0) Console.WriteLine("Diem thuoc tren truc Ox");
            else
            {
                if (y > 0)
                {
                    if (x > 0) Console.WriteLine("Diem thuoc Q1");
                    else Console.WriteLine("Diem thuoc Q2");
                }
                else
                {
                    if (x > 0) Console.WriteLine("Diem thuoc Q4");
                    else Console.WriteLine("Diem thuoc Q3");
                }
            }
        }

        public static void Bai10()
        {
            Console.Write("Nhap luong nhan vien = ");
            double cash = double.Parse(Console.ReadLine());
            if (cash >= 0)
            {
                if (cash <= 400.00) Console.WriteLine("Luong moi cho nhan vien = {0:0.00}", cash * 1.15);
                else if (cash <= 800.00) Console.WriteLine("Luong moi cho nhan vien = {0:0.00}", cash * 1.12);
                else if (cash <= 1200.00) Console.WriteLine("Luong moi cho nhan vien = {0:0.00}", cash * 1.10);
                else if (cash <= 2000.00) Console.WriteLine("Luong moi cho nhan vien = {0:0.00}", cash * 1.07);
                else Console.WriteLine("Luong moi cho nhan vien = {0:0.00}", cash * 1.04);
            }
            else Console.WriteLine("So tien khong hop le");
        }

        public static void Bai9()
        {
            Console.Write("Nhap code = ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Nhap quantity = ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,-20}|{1,12}|{2,12}|{3,12}", "PRODUCT NAME", "PRICE", "QUANTIY", "TOTAL(R$)");
            switch (code)
            {
                case 1:
                    Console.WriteLine("{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "Cochorro Quente", 4.00, amount, 4.00 * amount);
                    break;
                case 2:
                    Console.WriteLine("{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "X-Salada", 4.50, amount, 4.50 * amount);
                    break;
                case 3:
                    Console.WriteLine("{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "X-Bacon", 5.00, amount, 5.00 * amount);
                    break;
                case 4:
                    Console.WriteLine("{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "Torrada simples", 2.00, amount, 2.00 * amount);
                    break;
                case 5:
                    Console.WriteLine("{0,-20}|{1,12:0.00}|{2,12}|{3,12:0.00}", "Refrigerante", 1.00, amount, 1.00 * amount);
                    break;
                default:
                    Console.WriteLine("{0,-20}|{1,12}|{2,12}|{3,12}", "Error code", "Error", "Error", "Error");
                    break;
            }
        }

        public static void Bai8()
        {
            Console.Write("Nhap x = ");
            double x = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= 100)
            {
                if (x <= 25) Console.WriteLine("[0,25]");
                else if (x <= 50) Console.WriteLine("(25,50]");
                else if (x <= 75) Console.WriteLine("(50,75]");
                else Console.WriteLine("(75,100]");
            }
            else Console.WriteLine("Nhap 0 <= x <= 100");
        }

        public static void Bai7()
        {
            Console.Write("Nhap a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan = ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;
                case "%":
                    Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
                    break;
                default:
                    Console.WriteLine("Phep toan khong hop le");
                    break;
            }
        }

        public static void Bai6()
        {
            Console.Write("Nhap thang = ");
            int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Thang khong hop le");
                    break;
            }
        }

        public static void Bai5()
        {
            Console.Write("Nhap a (a>0) = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b (b>0) = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c (c>0) = ");
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                    Console.WriteLine("Chu vi tam giac: {0}", a + b + c);
                else
                    Console.WriteLine("Dien tich hinh thang: {0}", (c * (a + b)) / 2);
            }
            else Console.WriteLine("Input khong hop le");
        }

        public static void Bai4()
        {
            Console.Write("Nhap a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            if (a > c)
            {
                double temp = a;
                a = c;
                c = temp;
            }
            if (b > c)
            {
                double temp = b;
                b = c;
                c = temp;
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }

        public static void Bai3()
        {
            Console.Write("Nhap a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            double c = double.Parse(Console.ReadLine());
            if ((a >= b) && (a >= c))
                Console.WriteLine(a);
            else if (b >= c)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
        }

        public static void Bai2()
        {
            Console.Write("Nhap a (a!=0) = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            double c = double.Parse(Console.ReadLine());
            double delta = (b * b) - (4 * a * c);
            if (a != 0)
            {
                if (delta < 0)
                    Console.WriteLine("PT vo nghiem");
                else if (delta == 0)
                    Console.WriteLine("X = {0:0.00}", -b / 2 * a);
                else
                    Console.WriteLine("X1 = {0:0.00}\nX2 = {1:0.00}",
                        (-b + Math.Sqrt(delta)) / (2 * a), (-b - Math.Sqrt(delta)) / (2 * a));
            }
            else Console.WriteLine("PT khong hop le");
        }

        public static void Bai1()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0)
                Console.Write("{0} la so duong va ", n);
            else
                Console.Write("{0} la so am va ", n);
            switch (Math.Abs(n) % 2)
            {
                case 1:
                    Console.WriteLine("la so le");
                    break;
                case 0:
                    Console.WriteLine("la so chan");
                    break;
            }
        }
    }
}
