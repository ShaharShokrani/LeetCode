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
    /// https://leetcode.com/problems/insert-interval/description/
    /// </summary>
    [TestClass]
    public class InsertIntervalTests
    {
        [TestMethod]
        public void InsertTest1()
        {
            int[][] intervals = new int[][] { new[] { 1, 3 }, new[] { 6, 9 } };
            int[] newInterval = new int[] { 2, 5 };

            int[][] expected = new int[][] { new[] { 1, 5 }, new[] { 6, 9 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest2()
        {
            int[][] intervals = new int[][] { new[] { 1, 4 }, new[] { 6, 9 } };
            int[] newInterval = new int[] { 2, 3 };

            int[][] expected = new int[][] { new[] { 1, 4 }, new[] { 6, 9 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest3()
        {
            int[][] intervals = new int[][] { new[] { 1, 4 }, new[] { 6, 9 } };
            int[] newInterval = new int[] { 2, 7 };

            int[][] expected = new int[][] { new[] { 1, 9 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest4()
        {
            int[][] intervals = new int[][] {
            new[] { 1, 2 },
            new[] { 3, 5 },
            new[] { 6, 7 },
            new[] { 8, 10 },
            new[] { 12,16 } };
            int[] newInterval = new int[] { 4, 8 };

            int[][] expected = new int[][] { new[] { 1, 2 }, new[] { 3, 10 }, new[] { 12, 16 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest5()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 } };
            int[] newInterval = new int[] { 2, 3 };

            int[][] expected = new int[][] { new[] { 1, 5 }};
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest6()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 } };
            int[] newInterval = new int[] { 2, 7 };

            int[][] expected = new int[][] { new[] { 1, 7 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest7()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 } };
            int[] newInterval = new int[] { 5, 7 };

            int[][] expected = new int[][] { new[] { 1, 7 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest8()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 } };
            int[] newInterval = new int[] { 6, 7 };

            int[][] expected = new int[][] { new[] { 1, 5 }, new[] { 6, 7 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest9()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 } };
            int[] newInterval = new int[] { 0, 3 };

            int[][] expected = new int[][] { new[] { 0, 5 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest10()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 } };
            int[] newInterval = new int[] { 0, 0 };

            int[][] expected = new int[][] { new[] { 0, 0 }, new[] { 1, 5 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest11()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 } };
            int[] newInterval = new int[] { 0, 1 };

            int[][] expected = new int[][] { new[] { 0, 5 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest12()
        {
            int[][] intervals = new int[][] { new[] { 1, 5 }, new[] { 6, 8 } };
            int[] newInterval = new int[] { 0, 9 };

            int[][] expected = new int[][] { new[] { 0, 9 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }
        [TestMethod]
        public void InsertTest13()
        {
            //[[0,0],[2,4],[9,9]]

            int[][] intervals = new int[][] { new[] { 0, 0 }, new[] { 2, 4 }, new[] { 9, 9 } };
            int[] newInterval = new int[] { 0, 7 };

            int[][] expected = new int[][] { new[] { 0, 7 }, new[] { 9, 9 } };
            int[][] actual = Insert(intervals, newInterval);

            bool areEqual = expected.Length == actual.Length &&
                            !expected.Where((t, i) => !t.SequenceEqual(actual[i])).Any();

            Assert.IsTrue(areEqual, "The actual result is different from the expected result.");
        }


        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();

            int newIntervalStart = newInterval[0];
            int newIntervalEnd = newInterval[1];                       

            bool found = false;

            for (int i = 0; i < intervals.Length; i++)
            {
                int[] currentInterval = intervals[i];

                int start = currentInterval[0];
                int end = currentInterval[1];                

                if (!found &&
                    newIntervalStart <= currentInterval[1])
                {
                    if (newIntervalStart >= currentInterval[0])
                    {
                        start = currentInterval[0];
                    }
                    else
                    {
                        start = newIntervalStart;
                    }

                    if (newIntervalEnd < currentInterval[0])
                    {
                        if (newIntervalStart < currentInterval[0])
                            i--;

                        end = newIntervalEnd;
                    }
                    else if (newIntervalEnd <= currentInterval[1])
                    {
                        end = currentInterval[1];
                    }
                    else
                    {
                        end = FindEnd(intervals, newInterval, i, out int j);
                        i = j;
                    }
                    
                    found = true;
                }               

                result.Add(new int[] { start, end });
            }

            if (found == false ||
                intervals.Length == 0)
            {
                result.Add(new[] { newIntervalStart, newIntervalEnd });
            }

            return result.ToArray();
        }

        public int FindEnd(int[][] intervals, int[] newInterval, int i, out int j)
        {
            int result = newInterval[1];

            while (i < intervals.Length - 1)
            {
                int nextIntervalStart = intervals[i + 1][0];
                int nextIntervalEnd = intervals[i + 1][1];

                if (newInterval[1] < nextIntervalStart)
                {
                    result = newInterval[1];
                    break;
                }

                if (newInterval[1] >= nextIntervalStart &&
                    newInterval[1] <= nextIntervalEnd) // Current:[1,4],[5,9],[10,11] NEW:[2,6] => [1,9],[10,11]
                {
                    i++;
                    result = nextIntervalEnd;
                    break;
                }

                if (newInterval[1] > nextIntervalStart) // Current: [[0,0],[2,4],[9,9]], New: [0,7] => [[0,7],[9,9]]
                {
                    i++;
                }
            }

            j = i;
            return result;
        }
    }
}