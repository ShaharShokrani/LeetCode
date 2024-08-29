using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Arrays.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// </summary>
    [TestClass]
    public class PlusOneClass
    {
        [TestMethod]
        public void TwoSumTest1()
        {
            CollectionAssert.AreEquivalent(new int[] { 1, 2, 4 }, PlusOne(new int[] { 1, 2, 3 }));
        }

        [TestMethod]
        public void TwoSumTest2()
        {
            CollectionAssert.AreEquivalent(new int[] { 4, 3, 2, 2 }, PlusOne(new int[] { 4, 3, 2, 1 }));            
        }

        [TestMethod]
        public void TwoSumTest3()
        {
            CollectionAssert.AreEquivalent(new int[] { 1, 0 }, PlusOne(new int[] { 9 }));
        }

        [TestMethod]
        public void TwoSumTest4()
        {                                                     
            CollectionAssert.AreEquivalent(new int[] { 1, 0, 0 }, PlusOne(new int[] { 9, 9 }));
        }

        [TestMethod]
        public void TwoSumTest5()
        {
            CollectionAssert.AreEquivalent(new int[] { 9, 0, 0, 0 }, PlusOne(new int[] { 8, 9, 9, 9 }));
        }        

        public int[] PlusOne(int[] digits)
        {
            List<int> result = digits.ToList();

            int i = digits.Length - 1;
            while (i >= 0)
            {
                if (result[i] == 9)
                {
                    result[i] = 0;
                    i--;
                }
                else
                {
                    result[i]++;
                    break;
                }
            }

            if (i == -1)
                result.Insert(0, 1);

            return result.ToArray();
        }
    }
}