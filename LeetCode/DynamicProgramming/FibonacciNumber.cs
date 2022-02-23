using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/fibonacci-number/
    /// </summary>
    [TestClass]
    public class FibonacciNumber
    {
        [TestMethod, Timeout(2000)]
        public void FibTest()
        {
            Assert.AreEqual(1, Fib2(2));
            Assert.AreEqual(2, Fib2(3));
            Assert.AreEqual(3, Fib2(4));
        }

        private IDictionary<int, int> _map = new Dictionary<int, int>();
        /// <summary>
        /// F(0) = 0, F(1) = 1
        /// F(n) = F(n - 1) + F(n - 2), for n > 1.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Top-Down Approach using Memoization</returns>
        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n== 1)
                return 1;            
            
            if (_map.ContainsKey(n))
            {
                return _map[n];
            }

            int result = Fib(n - 1) + Fib(n - 2);
            _map[n] = result;

            return result;
        }

        public int Fib2(int n)
        {
            if (n ==0)
                return 0;
            if (n==1)
                return 1;

            int[] cahceArray = new int[n + 1];
            cahceArray[0] = 0;
            cahceArray[1] = 1;

            for (int i = 2; i < n + 1; i++)
            {
                cahceArray[i] = cahceArray[i - 1] + cahceArray[i - 2];
            }

            return cahceArray[n];
        }
    }
}
