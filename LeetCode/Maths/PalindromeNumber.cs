using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LeetCode.Maths
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    [TestClass]
    public class PalindromeNumber
    {
        [TestMethod, Timeout(2000)]
        public void IsPalindromeTest()
        {
            Assert.AreEqual(true, IsPalindrome(11));
            Assert.AreEqual(true, IsPalindrome(0));
            Assert.AreEqual(true, IsPalindrome(121));
            Assert.AreEqual(false, IsPalindrome(1211));
            Assert.AreEqual(false, IsPalindrome(-121));
            Assert.AreEqual(false, IsPalindrome(10));
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int totalDigits = (int)Math.Floor(Math.Log10(x) + 1);

            Stack<int> stack = new Stack<int>();
            int medium = totalDigits / 2;
            for (int i = 0; i < totalDigits ; i++)
            {
                if (i < medium)
                {
                    stack.Push(x % 10);                    
                }
                else if (i == medium && 
                    totalDigits % 2 != 0)
                {

                }
                else
                {
                    if (x % 10 != stack.Pop())
                        return false;
                }
                x = x / 10;
            }

            return true;
        }
    }
}
