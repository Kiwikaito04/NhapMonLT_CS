using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapXepVaTimKiem
{
    public static class Init
    {
        static int InputN()
        {
            Console.Write("\nNhap n: ");
            return int.Parse(Console.ReadLine());
        }

        static void InputArray(out string[] arrS, ref int[] arrBubble, ref int[] arrInterchange, int n)
        {
            Console.WriteLine("\nNhap mang:");
            arrS = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                arrBubble[i] = int.Parse(arrS[i]);
                arrInterchange[i] = int.Parse(arrS[i]);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void BubbleSort(ref int[] arr, int l, int r)
        {
            for (int i = l; i <= r - 1; i++)
                for (int j = l; j <= r - i - 1 + l; j++)
                    if (arr[j] > arr[j + 1])
                        Swap(ref arr[j], ref arr[j + 1]);
        }

        static void InterchangeSort(ref int[] arr, int l, int r)
        {
            for (int i = l; i <= r - 1; i++)
                for (int j = i + 1; j <= r; j++)
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);
        }

        public static void Bai1()
        {
            int n = InputN();
            string[] arrS;
            int[] arrBubble = new int[n];
            int[] arrInterchange = new int[n];
            if (n != 0)
            {
                InputArray(out arrS, ref arrBubble, ref arrInterchange, n);
            }
            BubbleSort(ref arrBubble, 0, n - 1);
            Console.WriteLine("\nBubble Sort:");
            for (int i = 0; i < n; i++)
                Console.Write($"{arrBubble[i]} ");
            Console.WriteLine();

            InterchangeSort(ref arrInterchange, 0, n - 1);
            Console.WriteLine("\nInterchange Sort:");
            for (int i = 0; i < n; i++)
                Console.Write($"{arrInterchange[i]} ");
            Console.WriteLine();
        }

        public static void Bai2()
        {
            int n = InputN();
            string[] arrS;
            int[] arrBubble = new int[n];
            int[] arrInterchange = new int[n];
            int l = 0, r = 0;
            if (n != 0)
            {
                InputArray(out arrS, ref arrBubble, ref arrInterchange, n);
                Console.Write("\nNhap k = ");
                l = int.Parse(Console.ReadLine());
                Console.Write("\nNhap l = ");
                r = int.Parse(Console.ReadLine());
            }
            BubbleSort(ref arrBubble, l, r);
            Console.WriteLine("\nBubble Sort:");
            for (int i = 0; i < n; i++)
                Console.Write($"{arrBubble[i]} ");
            Console.WriteLine();

            InterchangeSort(ref arrInterchange, l, r);
            Console.WriteLine("\nInterchange Sort:");
            for (int i = 0; i < n; i++)
                Console.Write($"{arrInterchange[i]} ");
            Console.WriteLine();
        }

        static int FindKth(int n, int[] arr, int k)
        {
            return arr[n - k];
        }

        public static void Bai3()
        {
            int n = InputN();
            string[] arrS;
            int[] arr = new int[n];
            if (n != 0)
            {
                Console.WriteLine("\nNhap mang:");
                arrS = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(arrS[i]);
                }
                BubbleSort(ref arr, 0, n - 1);
                Console.Write("\nNhap k = ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nPhan tu lon thu {k} trong mang la {FindKth(n, arr, k)}");
            }
        }

        public static void Bai4()
        {
            int n = InputN();
            string[] arrS;
            int[] arr = new int[n];
            if (n != 0)
            {
                Console.WriteLine("\nNhap mang:");
                arrS = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(arrS[i]);
                }
                BubbleSort(ref arr, 0, n - 1);

            }
            for (int i = 0; i < n; i++)
            {
                int temp = 0;
                while (i + 1 < n && arr[i] == arr[i + 1])
                {
                    temp++;
                    i++;
                }
                temp++;
                Console.WriteLine($"[{arr[i]}] = {temp}");
            }
        }
    }
}
