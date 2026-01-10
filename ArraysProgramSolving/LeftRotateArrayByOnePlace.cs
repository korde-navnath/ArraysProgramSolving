using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgramSolving
{
    internal class LeftRotateArrayByOnePlace
    {
        static int[] LeftRotateArrayByOneElement(int[] arr, int n)
        {
            int temp = arr[0];
            for (int i = 1; i < n; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[n - 1] = temp;
            return arr;
        }
        public static void Main(string[] arrays)
        {
            int [] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            LeftRotateArrayByOneElement(arr, n);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
