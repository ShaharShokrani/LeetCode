using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace LeetCode.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-good-pairs/
    /// </summary>
    [TestClass]
    public class CountingBitsPairs
    {
        [TestMethod, Timeout(2000)]
        [Ignore]
        public void CountBitsTest()
        {
            CollectionAssert.AreEquivalent(new int[3] { 0, 1, 1 }, CountBits(2));
            CollectionAssert.AreEquivalent(new int[6] { 0, 1, 1, 2, 1, 2 }, CountBits(5));
            Console.WriteLine(CountBits(6));
        }

        /// <summary>
        /// O (n log n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            try
            {                
                for (int i = 0; i < n + 1; i++)
                {
                    BitArray bitArray = new BitArray(BitConverter.GetBytes(i));

                    int totalOnes = 0;
                    foreach (bool item in bitArray)
                    {
                        if (item)
                            totalOnes++;
                    }
                    result[i] = totalOnes;
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }    
    }
}
