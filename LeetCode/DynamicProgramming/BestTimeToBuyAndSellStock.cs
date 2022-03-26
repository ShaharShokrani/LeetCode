using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    [TestClass]
    public class BestTimeToBuyAndSellStock
    {
        [TestMethod]
        public void MaxProfitTest()
        {
            Assert.AreEqual(5, MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        }

        [TestMethod]
        public void MaxProfitTest2()
        {
            Assert.AreEqual(0, MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
        }


        /// <summary>
        /// For every element, we are calculating the difference between that element and the minimum of all the 
        /// values before that element and we are updating the maximum profit if the 
        /// difference thus found is greater than the current maximum profit.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {            
            int result = 0;
            int localMin = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= localMin)
                    localMin = prices[i];                

                if (prices[i] - localMin > result)
                {
                    result = prices[i] - localMin;
                }
            }
            return result;
        }
    }
}
