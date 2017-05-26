using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.Extensions
{
    public static class IENumerableExtension
    {
        public static int Sum(this IEnumerable<int> enumerable)
        {
            int sum = 0;
            foreach (int number in enumerable)
            {
                sum += number;
            }
            return sum;
        }


        public static int Product(this IEnumerable<int> enumerable)
        {
            int product = 1;
            foreach (int number in enumerable)
            {
                product *= number;
            }
            return product;
        }


        public static int Min(this IEnumerable<int> enumerable)
        {
            if (enumerable == null)
            {
                return 0;
            }
            int min = Int32.MaxValue;
            foreach (int number in enumerable)
            {
                if (min > number)
                {
                    min = number;
                }
            }
            return min;
        }


        public static int Max(this IEnumerable<int> enumerable)
        {
            if (enumerable == null)
            {
                return 0;
            }
            int max = Int32.MinValue;
            foreach (int number in enumerable)
            {
                if (max < number)
                {
                    max = number;
                }
            }
            return max;
        }


        public static int Media(this IEnumerable<int> enumerable)
        {
            if (enumerable != null)
            {
                int sum = enumerable.Sum();
                if (sum != 0)
                {
                    return sum / enumerable.Count();
                }
            }
            return 0;
        }
    }
}
