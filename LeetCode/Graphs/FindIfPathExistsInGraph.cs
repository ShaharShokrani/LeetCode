using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Graphs
{
    /// <summary>
    /// https://leetcode.com/problems/find-if-path-exists-in-graph/
    /// </summary>
    [TestClass]
    public class FindIfPathExistsInGraph
    {
        [TestMethod, Timeout(2000)]
        public void FibTest()
        {
            Assert.AreEqual(true, ValidPath(3, new int[][]
                            {
                                        new int[] { 0, 1 },
                                        new int[] { 1, 2 },
                                        new int[] { 2, 0 }
                            }, 0, 2));

            Assert.AreEqual(false, ValidPath(6, new int[][]
                            {
                                        new int[] { 0, 1 },
                                        new int[] { 0, 2 },
                                        new int[] { 3, 5 },
                                        new int[] { 5, 4 },
                                        new int[] { 4, 3 }
                            }, 0, 5));
        }        
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {           
            throw new NotImplementedException();
        }
    }
}