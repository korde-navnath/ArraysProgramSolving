using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgramSolving
{
    internal class KidsWithGretestNumbersOfCandies
    {
        public static IList<bool> KidsWithGretestNumbersOfCandie(int[] candies, int extraCandies)
        {
            int maxCandies = candies.Max();
            IList<bool> result = new List<bool>();
            foreach (int candy in candies)
            {
                if (candy + extraCandies >= maxCandies)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            KidsWithGretestNumbersOfCandie(candies, extraCandies);
            foreach (var item in KidsWithGretestNumbersOfCandie(candies, extraCandies))
            {
                Console.WriteLine(item);
            }
        }
    }
}
