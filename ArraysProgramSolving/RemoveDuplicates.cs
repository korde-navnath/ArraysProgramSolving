using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgramSolving
{
    internal class RemoveDuplicates
    {
        public static int RemoveDuplicatesAndReturnNewArrayLength(int[] arr, int n)
        {
            int i = 0;
            for(int j = 1; j < n; j++)
            {
                if (arr[i] != arr[j])
                {
                    arr[i + 1] = arr[j];
                    i++;
                }
            }
            return i + 1;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
            int n = arr.Length;
            int printResult = RemoveDuplicatesAndReturnNewArrayLength(arr, n);
            Console.WriteLine(printResult);
        }
    }
}
