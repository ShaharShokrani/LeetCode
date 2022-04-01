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
    /// https://leetcode.com/problems/reverse-string/
    /// </summary>
    [TestClass]
    public class ReverseStringClass
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            var actual = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var expected = new char[] { 'o', 'l', 'l', 'e', 'h' };

            ReverseString(actual); // Calls your implementation

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ReverseStringTes2()
        {
            var actual = new char[] { 'h', 'e', 'l', 'l' };
            var expected = new char[] { 'l', 'l', 'e', 'h' };

            ReverseString(actual); // Calls your implementation

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public void ReverseString(char[] s)
        {
            int right = s.Length - 1;
            int left = 0;
            while (left <= right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                right--;
                left++;
            }
        }
    }
}