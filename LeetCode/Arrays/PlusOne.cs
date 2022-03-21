using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
                                                     //0, 1, 2                        0, 1
            CollectionAssert.AreEquivalent(new int[] { 1, 0, 0 }, PlusOne(new int[] { 9, 9 }));
        }

        public int[] PlusOne(int[] digits)
        {   
            //Calculate the curry if the sum larger than 9.
            int curry = digits[digits.Length - 1] + 1 > 9 ? 1 : 0;

            //Init the resulted array, should be bigger if curry is 1.
            int[] result = new int[digits.Length + curry];


            int i = digits.Length - 1;
            result[i + curry] = (digits[i] + 1) % 10;
            i--;

            while (i >= 0)
            {
                result[i + curry] = (digits[i] + curry) % 10;

                curry = digits[i] + curry + 1 > 9? 1 : 0;
                i--;
            }

            if (curry == 1)
            {
                result[0] = 1;
            }

            return result;
        }
    }
}