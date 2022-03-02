using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/counting-bits/
    /// </summary>
    [TestClass]
    public class CountingBits
    {
        [TestMethod, Timeout(2000)]
        public void CountBitsTest()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1, 1 }, CountBits(2));
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 1, 2 }, CountBits(5));
            /*     N  N-1
             *    --- ---
            0-- > 000 & 000 = 000
            1-- > 001 & 000 = 000
            2-- > 010 & 001 = 000
            3-- > 011 & 010 = 010
            4-- > 100 & 011 = 000
            5-- > 101 & 100 = 100
            */
        }

        /// <summary>
        /// O(nlogn)
        /// </summary>
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i < result.Length; i++)
            {
                NumberOf1Bits numberOf1Bits = new NumberOf1Bits();
                result[i] = numberOf1Bits.HammingWeight2(i);
            }
            
            return result;
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public int[] CountBits2(int n)
        {
            throw new NotImplementedException();
        }
    }
}