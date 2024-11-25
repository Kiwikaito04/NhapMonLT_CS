using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapXepVaTimKiem
{
    public static class Init
    {

        // Hàm nhập N (số lượng phần tử mảng)
        static int InputN()
        {
            Console.Write("\nNhap n: ");
            return int.Parse(Console.ReadLine());
        }

        // Hàm nhập mảng
        static void InputArray(out int[] arr, int n)
        {
            Console.WriteLine("\nNhap mang:");

            // Nhận chuỗi ký tự từ bàn phím
            string[] arrS = Console.ReadLine().Split();

            // Chuyển thành mảng int
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(arrS[i]);
            }
        }

        // Hàm hoán vị
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Hàm in mảng
        static void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        //Hàm Buuble Sort
        static void BubbleSort(ref int[] arr, int l, int r)
        {
            for (int i = l; i <= r - 1; i++)
                for (int j = l; j <= r - i - 1 + l; j++)
                    if (arr[j] > arr[j + 1])
                        Swap(ref arr[j], ref arr[j + 1]);

            Console.WriteLine("\nBubble Sort:");
            PrintArray(arr, arr.Length);
        }

        // Hàm Interchange Sort
        static void InterchangeSort(ref int[] arr, int l, int r)
        {
            for (int i = l; i <= r - 1; i++)
                for (int j = i + 1; j <= r; j++)
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);

            Console.WriteLine("\nInterchange Sort:");
            PrintArray(arr, arr.Length);
        }

        // Bài 1
        public static void Bai1()
        {
            int n = InputN();

            int[] arr;
            int[] arrBubble = new int[n];
            int[] arrInterchange = new int[n];

            if (n != 0)
            {
                InputArray(out arr, n);

                // Sao chép mảng
                for (int i = 0; i < n; i++)
                {
                    arrBubble[i] = arr[i];
                    arrInterchange[i] = arr[i];
                }
            }

            // Thực hiện sắp xếp
            BubbleSort(ref arrBubble, 0, n - 1);
            InterchangeSort(ref arrInterchange, 0, n - 1);
        }

        public static void Bai2()
        {
            int n = InputN();

            int[] arr;
            int[] arrBubble = new int[n];
            int[] arrInterchange = new int[n];

            int l = 0, r = 0;

            if (n != 0)
            {
                InputArray(out arr, n);

                // Sao chép mảng
                for (int i = 0; i < n; i++)
                {
                    arrBubble[i] = arr[i];
                    arrInterchange[i] = arr[i];
                }

                Console.Write("\nNhap l = ");
                l = int.Parse(Console.ReadLine());
                Console.Write("\nNhap r = ");
                r = int.Parse(Console.ReadLine());
            }

            // Thực hiện sắp xếp
            BubbleSort(ref arrBubble, l, r);
            InterchangeSort(ref arrInterchange, l, r);
        }

        static int FindKth(int n, int[] arr, int k)
        {
            return arr[n - k];
        }

        public static void Bai3()
        {
            int n = InputN();

            int[] arr = new int[n];

            if (n != 0)
            {
                InputArray(out arr, n);

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
