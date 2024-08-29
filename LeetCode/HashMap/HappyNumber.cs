using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number/
    /// </summary>
    [TestClass]
    public class HappyNumber
    {
        [TestMethod]
        public void IsHappyTest()
        {
            Assert.IsTrue(IsHappy(19));            
        }

        [TestInitialize]
        public void Init()
        {
        }

        public bool IsHappy(int n)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (n != 1 && !seenNumbers.Contains(n))
            {
                seenNumbers.Add(n);
                n = SumOfSquaresOfDigits(n);
            }

            return n == 1;
        }

        private int SumOfSquaresOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }

    }
}