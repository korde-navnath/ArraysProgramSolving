using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgramSolving
{
    internal class RotateArrayKsteps
    {
        //Rotate an array of n elements to the right by k steps.
        static void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void RotateArrayByKSteps(int[] arr, int n, int k)
        {
            k = k % n; // In case k is greater than n
            ReverseArray(arr, 0, n - 1);
            ReverseArray(arr, 0, k - 1);
            ReverseArray(arr, k, n - 1);
          
        }
        public static void Main(string[] arrays)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            int k = 1;
            RotateArrayByKSteps(arr, n, k);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
