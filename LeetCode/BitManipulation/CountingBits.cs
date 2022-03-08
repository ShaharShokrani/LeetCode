using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace LeetCode.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/counting-bits/
    /// </summary>
    [TestClass]
    public class CountingBits
    {
        [TestMethod]
        public void CountBitsTest()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                stringBuilder.Append(i);
                stringBuilder.Append(" : ");
                stringBuilder.Append(Convert.ToString(i, 2));
                stringBuilder.AppendLine();                
            }

            Console.WriteLine(stringBuilder.ToString());

            CollectionAssert.AreEqual(new int[] { 0, 1, 1 }, CountBits(2));
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 1, 2 }, CountBits(5));
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

        [TestMethod]
        public void CountBitsTest2()
        {                        
            CollectionAssert.AreEqual(new int[] { 0, 1, 1 }, CountBits2(2));
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 1, 2 }, CountBits2(5));            
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public int[] CountBits2(int n)
        {
            /*
             * 0 [1], [2,3], [4,5,6,7], [8,9,10,11,12,13,14,15]
    i             result  GroupSize
    0  : 00000 A   0          0
    1  : 00001 B   1          1
    2  : 00010 C   1          2
    3  : 00011 C   2          2
    4  : 00100 D   1          4
    5  : 00101 D   2          4
    6  : 00110 D   2          4
    7  : 00111 D   3          4
    8  : 01000 E   1          8
    9  : 01001 E   2          8
    10 : 01010 E   2          8
    11 : 01011 E   3          8
    12 : 01100 E   2          8
    13 : 01101 E   3          8
    14 : 01110 E   3          8
    15 : 01111 E   4          8
    16 : 10000 F   1          16
    17 : 10001 F   2          16
    18 : 10010 F   2          16
    19 : 10011 F   3          16
             */
            int[] result = new int[n + 1];
            
            int groupSize = 1;

            for (int i = 1; i < n + 1; i++)
            {
                int seed = 0;
                while (seed < groupSize &&
                    (seed + groupSize) < n + 1 )
                {
                    result[seed + groupSize] = result[seed] + 1;
                    seed++;
                }
                groupSize = groupSize << 1; // 1 -> 2 -> 4 -> 8 -> ...
            }

            return result;
        }

        [TestMethod]
        public void CountBitsTest3()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1, 1 }, CountBits3(2));
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 1, 2 }, CountBits3(5));
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public int[] CountBits3(int n)
        {
            /*
    i           result  i'      result'   i%2
    0  : 00000   0      00000     0        0
    1  : 00001   1      00000     0        1
    2  : 00010   1      00001     1        0
    3  : 00011   2      00001     1        1
    4  : 00100   1      00010     1        0    
    5  : 00101   2      00010     1        1
    6  : 00110   2      00011     2        0
    7  : 00111   3      00011     2        1
    8  : 01000   1      00100     1        0
    9  : 01001   2      00100     1        1
    10 : 01010   2      00101     2        0
    11 : 01011   3      00101     2        1
    12 : 01100   2      00110     2        0
    13 : 01101   3      00110     2        1
        
             */
            int[] result = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                result[i] = result[i>>1] + (i % 2);
            }

            return result;
        }

        [TestMethod]
        public void CountBitsTest4()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1, 1 }, CountBits4(2));
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 1, 2 }, CountBits4(5));
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public int[] CountBits4(int n)
        {
            /*
    i           result  i-1      i & i-1   
    0  : 00000   0      -         -            -
    1  : 00001   1      00000     00000        
    2  : 00010   1      00001     00000
    3  : 00011   2      00010     00010        
    4  : 00100   1      00011     00000          
    5  : 00101   2      00100     1        
    6  : 00110   2      00101     2        
    7  : 00111   3      00110     2        
    8  : 01000   1      00111     1        
    9  : 01001   2      01000     1        
    10 : 01010   2      01001     2        
    11 : 01011   3      01010     2        
    12 : 01100   2      01011     2        
    13 : 01101   3      01100     2        
        
             */
            int[] result = new int[n + 1];

            for (int i = 1; i < result.Length; i++)
            {
                result[i] = result[i & (i - 1)] + 1;
            }

            return result;
        }
    }
}