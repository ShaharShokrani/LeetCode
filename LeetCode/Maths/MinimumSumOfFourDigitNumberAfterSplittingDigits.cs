using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Maths
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/
    /// </summary>
    [TestClass]
    public class MinimumSumOfFourDigitNumberAfterSplittingDigits
    {
        [TestMethod]
        public void MinimumSumTest()
        {
            Assert.AreEqual(52, MinimumSum(2932));
            Assert.AreEqual(13, MinimumSum(4009));
        }

        public int MinimumSum(int num)
        {
            int[] items = new int[4];

            for (int i = items.Length -1; i > -1; i--)
            {
                items[i]= num % 10;
                num = num / 10;
            }

            Array.Sort(items);
            
            return items[0]*10 + items[2] + items[1]*10 + items[3];
        }
    }
}
