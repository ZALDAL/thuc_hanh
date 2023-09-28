using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thực_hành
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 5, 1, 4 };

            Console.WriteLine("Mảng trước khi sắp xếp:");
            PrintArray(arr);

            BingoSort(arr);

            Console.WriteLine("Mảng sau khi sắp xếp:");
            PrintArray(arr);
        }

        static void BingoSort(int[] arr)
        {
            bool swapped;
            int n = arr.Length;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        // Hoán đổi hai phần tử
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
