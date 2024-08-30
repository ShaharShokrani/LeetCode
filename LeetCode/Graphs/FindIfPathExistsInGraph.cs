using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

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
        }

        [TestMethod, Timeout(2000)]
        public void FibTest2()
        {
            Assert.AreEqual(false, ValidPath(6, new int[][]
                            {
                                        new int[] { 0, 1 },
                                        new int[] { 0, 2 },
                                        new int[] { 3, 5 },
                                        new int[] { 5, 4 },
                                        new int[] { 4, 3 }
                            }, 0, 5));
        }

        [TestMethod, Timeout(2000)]
        public void FibTest3()
        {
            Assert.AreEqual(true, ValidPath(2, new int[][]
                            {
                                        new int[] { 0, 1 },
                                        new int[] { 1, 2 },
                            }, 0, 2));
        }

        [TestMethod, Timeout(2000)]
        public void FibTest4()
        {
            Assert.AreEqual(true, ValidPath(1, new int[][] { }, 0, 0));
        }

        [TestMethod, Timeout(2000)]
        public void FibTest5()
        {
            Assert.AreEqual(true, ValidPath(10, new int[][] 
            {
                new int[] { 4, 3 },
                new int[] { 1, 4 },
                new int[] { 4, 8 },
                new int[] { 1, 7 },
                new int[] { 6, 4 },
                new int[] { 4, 2 },
                new int[] { 7, 4 },
                new int[] { 4, 0 },
                new int[] { 0, 9 },
                new int[] { 5, 4 },
            }, 5, 9));
        }

        [TestMethod, Timeout(2000)]
        public void FibTest6()
        {
            Assert.AreEqual(true, ValidPath(10, new int[][]
            {
                new int[] { 0, 7 },
                new int[] { 0, 8 },
                new int[] { 6, 1 },
                new int[] { 2, 0 },
                new int[] { 0, 4 },
                new int[] { 5, 8 },
                new int[] { 4, 7 },
                new int[] { 1, 3 },
                new int[] { 3, 5 },
                new int[] { 6, 5 },
            }, 7, 5));
        }        

        IDictionary<int, List<int>> _edgesList = new Dictionary<int, List<int>>();
        HashSet<int> _visits = new HashSet<int>();

        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            if (edges.Length == 0)
                return true;

            foreach (int[] edge in edges)
            {
                int key = edge[0];
                if (!_edgesList.ContainsKey(key))
                {
                    _edgesList.Add(key, new List<int>() { edge[1] });
                }
                else
                {
                    _edgesList[key].Add(edge[1]);
                }

                key = edge[1];
                if (!_edgesList.ContainsKey(key))
                {
                    _edgesList.Add(key, new List<int>() { edge[0] });
                }
                else
                {
                    _edgesList[key].Add(edge[0]);
                }
            }

            if (Recursive(source, destination))
                return true;

            return false;
        }

        private bool Recursive(int source, int destination)
        {
            if (source == destination)
                return true;

            if (_edgesList.ContainsKey(source))
            {
                foreach (int target in _edgesList[source])
                {
                    if (_visits.Contains(target))
                    {
                        continue;
                    }
                    _visits.Add(target);

                    if (Recursive(target, destination))
                        return true;
                }
            }

            return false;            
        }
    }
}