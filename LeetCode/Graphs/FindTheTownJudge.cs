using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Graphs
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-town-judge/
    /// </summary>
    [TestClass]
    public class FindTheTownJudge
    {
        [TestMethod, Timeout(2000)]
        public void FindJudgeTest()
        {
            Assert.AreEqual(2, FindJudge(2, new int[][]
                            {
                                        new int[] { 1, 2 },
                            }));
            Assert.AreEqual(3, FindJudge(3, new int[][]
                            {
                                        new int[] { 1, 3 },
                                        new int[] { 2, 3 }
                            }));
            Assert.AreEqual(-1, FindJudge(3, new int[][]
                            {
                                        new int[] { 1, 3 },
                                        new int[] { 2, 3 },
                                        new int[] { 3, 1 }
                            }));
            Assert.AreEqual(3, FindJudge(4, new int[][]
                            {
                                        new int[] { 1, 3 },
                                        new int[] { 1, 4 },
                                        new int[] { 2, 3 },
                                        new int[] { 2, 4 },
                                        new int[] { 4, 3 }
                            }));
        }

        public int FindJudge(int n, int[][] trust)
        {
            int[] @out = new int[n + 1];
            int[] @in = new int[n + 1];

            foreach (int[] item in trust)
            {
                @out[item[0]]++;
                @in[item[1]]++;
            }

            for (int i = 1; i <= n; i++)
            {
                if (@in[i] == n - 1 && @out[i] == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}