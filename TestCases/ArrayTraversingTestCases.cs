using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using VariousAlgorithms;
using Xunit;

namespace TestCases
{
    public class ArrayTraversingTestCases
    {
        [Theory]
        [InlineData(null, 1, -1)]
        [InlineData(new int[] {}, 1, -1)]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 1, -1)]    // array of same elements and x is equal to every element
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 2, -1)]    // array of same elements and x is not equal to any element
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 1, 8)]
        [InlineData(new[] { 4, 7, 1, 3, 9, 1, 8, 1, 6, 5, 4, 3, 1, 0 }, 1, 9)]
        [InlineData(new[] { 1, 8, 1, 6, 5, 4, 3, 1, 0 }, 1, 5)]
        [InlineData(new[] { 5, 5, 3, 1, 6, 5, 1 }, 5, 3)]
        [InlineData(new[] { 5, 5, 3, 1, 6, 5, 1 }, 3, 5)]
        public void ArrayDevidingElement(int[] a, int x, int expResult)
        {
            var actualResult = ArrayTraversing.FindDevidingElement(a, x);

            Assert.Equal(expResult, actualResult);
        }
    }
}
