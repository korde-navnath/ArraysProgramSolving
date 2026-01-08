using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgramSolving
{
    internal class SecondSmallestAndSecondeLargest
    {
        public static int FindSecondLargest(int[] arr, int n)
        {
            int largest = arr[0];
            int secondeLargest = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    secondeLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondeLargest && arr[i] != largest)
                {
                    secondeLargest = arr[i];
                }
            }
            return secondeLargest;
        }
        public static int FindSecondSmallest(int[] arr, int n)
        {
            int smallest = arr[0];
            int secondeSmallest = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < smallest)
                {
                    secondeSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondeSmallest && arr[i] != smallest)
                {
                    secondeSmallest = arr[i];
                }
            }
            return secondeSmallest;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1, 4, 7, 2, 6 };
            int n = arr.Length;
            int secondSmallest = FindSecondSmallest(arr, n);
            int secondLargest = FindSecondLargest(arr, n);
            Console.WriteLine("Second Smallest: " + secondSmallest);
            Console.WriteLine("Second Largest: " + secondLargest);
        }

    }
}
