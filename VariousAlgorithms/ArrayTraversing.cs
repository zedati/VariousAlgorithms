using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousAlgorithms
{
    public class ArrayTraversing
    {
        /// <summary>
        /// An array of N elements and number x are given. 
        /// It's necessary to find such deviding element, that the number of element equal to x in left part 
        /// and the number of element not equal to x in the right part are equal
        /// For example, for an array a = {5, 5, 3, 1, 6, 5, 1} and x = 5
        /// the dividing element will be a[3] = 1, because the number of elements equal to 5 in a[0..3] and
        /// the number of elements not equal to 5 in a[4..6] are the same.
        /// </summary>
        /// <param name="a">The given array of integers.</param>
        /// <param name="x">The given number.</param>
        public static int FindDevidingElement(int[] a, int x)
        {
            if (a == null || a.Length == 0) return -1;

            int i = 0, j = a.Length - 1, l = 0, r = 0;

            while (true)
            {
                if (a[i] == x) l++;
                if (a[j] != x) r++;

                while (l < r && i != j)
                {
                    i++;
                    if (a[i] == x) l++;
                }

                while (l > r && i != j)
                {
                    j--;
                    if (a[j] != x) r++;
                }

                if (i == j) break;

                i++; j--;
            };

            if (l == 0 || r == 0)
                return -1;

            return i;
        }
    }
}
