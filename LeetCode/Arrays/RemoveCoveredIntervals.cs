using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/remove-covered-intervals/
    /// </summary>
    [TestClass]
    public class RemoveCoveredIntervalsClass
    {
        [TestMethod]
        public void TwoSumTest()
        {
            Assert.AreEqual(1, RemoveCoveredIntervals(new int[][]
                                        {
                                        new int[] { 1, 2 },
                                        new int[] { 1, 4 },
                                        new int[] { 3, 4 }
                                        }));

            Assert.AreEqual(2, RemoveCoveredIntervals(new int[][]
                                        {
                                        new int[] { 3, 10 },
                                        new int[] { 4, 10 },
                                        new int[] { 5, 11 }
                                        }));
            Assert.AreEqual(2, RemoveCoveredIntervals(new int[][]
                                        {
                                        new int[] { 1, 4 },
                                        new int[] { 3, 6 },
                                        new int[] { 2, 8 }
                                        }));
            Assert.AreEqual(1, RemoveCoveredIntervals(new int[][]
                                        {
                                        new int[] { 1, 4 },
                                        new int[] { 2, 3 }
                                        }));
        }

        public int RemoveCoveredIntervals(int[][] intervals)
        {
            int result = 0;

            IOrderedEnumerable<int[]> orderedIntervals = intervals.OrderBy(x => x.First()).ThenByDescending(x => x.ElementAt(1));

            int previousA = -1;
            int previousB = -1;
            
            foreach (int[] orderedInterval in orderedIntervals)
            {
                int currentA = orderedInterval[0];
                int currentB = orderedInterval[1];

                if (currentA >= previousA && currentB <= previousB)
                {
                    result++;
                }
                else
                {
                    previousA = currentA;
                    previousB = currentB;
                }
            }

            return intervals.Length - result;
        }
    }
}