using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Graphs
{
    /// <summary>
    /// https://leetcode.com/problems/find-center-of-star-graph/
    /// </summary>
    [TestClass]
    public class FindCenterOfStarGraph
    {
        [TestMethod, Timeout(2000)]
        public void FibTest()
        {
            Assert.AreEqual(2, FindCenter(new int[][]
                            {
                                        new int[] { 1, 2 },
                                        new int[] { 2, 3 },
                                        new int[] { 4, 2 }
                            }));
        }

        public int FindCenter(int[][] edges)
        {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
                return edges[0][0];
            else
                return edges[0][1];
        }
    }
}