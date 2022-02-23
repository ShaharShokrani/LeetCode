using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-1-bits/
    /// </summary>
    [TestClass]
    public class NumberOf1Bits
    {
        [TestMethod, Timeout(2000)]
        public void HammingWeightTest()
        {                        
            Assert.AreEqual(3, HammingWeight(Convert.ToInt64("00000000000000000000000000001011", 2)));
            Assert.AreEqual(1, HammingWeight(Convert.ToInt64("00000000000000000000000010000000", 2)));
            Assert.AreEqual(31, HammingWeight(Convert.ToInt64("11111111111111111111111111111101", 2)));
        }

        public int HammingWeight(long n)
        {
            int bits = 0;
            int mask = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((n & mask) != 0)
                {
                    bits++;
                }
                mask = mask << 1;
            }
            return bits;
        }

        [TestMethod, Timeout(2000)]
        public void HammingWeight2Test()
        {
            Assert.AreEqual(3, HammingWeight2(Convert.ToInt64("00000000000000000000000000001011", 2)));
            Assert.AreEqual(1, HammingWeight2(Convert.ToInt64("00000000000000000000000010000000", 2)));
            Assert.AreEqual(31, HammingWeight2(Convert.ToInt64("11111111111111111111111111111101", 2)));
        }

        //n     = 110_1_00
        //n-1   = 110_0_11

        public int HammingWeight2(long n)
        {
            int result = 0;
            while (n != 0)
            {                
                n = n & (n - 1);

                result++;
            }
            return result;
        }
    }
}

