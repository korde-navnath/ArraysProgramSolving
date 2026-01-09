using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgramSolving
{
    internal class ArrayIsSortedOrNot
    {
        public static bool IsSortedOrNot(int[] arr, int n)
        {
            for(int i = 1; i < n; i++)
            {
                if (arr[i] >= arr[i - 1])
                {

                }
                else return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            bool answer = IsSortedOrNot(arr, n);
            Console.WriteLine(answer);
        }
    }
}
