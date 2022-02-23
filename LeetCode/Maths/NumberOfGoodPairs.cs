using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Maths
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-good-pairs/
    /// </summary>
    [TestClass]
    public class NumberOfGoodPairs
    {
        [TestMethod, Timeout(2000)]
        public void NumIdenticalPairsTest()
        {
            Assert.AreEqual(4, NumIdenticalPairs(new[] { 1, 2, 3, 1, 1, 3 }));
        }
        /// <summary>
        /// naive
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int NumIdenticalPairs(int[] nums)
        {
            int result = 0;

            IDictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length ; i++)
            {
                int key = nums[i];

                if (map.ContainsKey(key))
                {
                    result = result + map[key];
                    map[key]++;
                }
                else
                {
                    map.Add(key, 1);
                }
            }

            return result;
        }    
    }
}
