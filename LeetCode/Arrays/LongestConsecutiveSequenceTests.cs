using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LeetCode.Arrays.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/longest-consecutive-sequence/description/
    /// </summary>
    [TestClass]
    public class LongestConsecutiveSequenceTests
    {
        [TestMethod]
        public void InsertTest1()
        {
            int[] nums = new int[] { 4, 1, 3, 2 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(4, actual);
            // 1. ([4])         (4)->[4]
            // 2. ([4],[1])     (4)->[4], (1)->[1]
            // 3. ([3-4],[1])   (4)->[3-4], (1)->[1], (3)->[3-4]
            // 4. ([3-4],[1])   (4)->[3-4], (1)->[1-2], (3)->[3-4], (2)->[1-2]
        }

        [TestMethod]
        public void InsertTest8()
        {
            int[] nums = new int[] { 4, 3, 2 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(3, actual); // (4), (1), (2)->(3)->(4), (2), 
        }

        [TestMethod]
        public void InsertTest6()
        {
            int[] nums = new int[] { 4, 3 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void InsertTest7()
        {
            int[] nums = new int[] { 3, 4 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void InsertTest2()
        {
            int[] nums = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void InsertTest3()
        {
            int[] nums = new int[] { 0 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void InsertTest4()
        {
            int[] nums = new int[] { -2, -3, 0, -4, -1 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void InsertTest5()
        {
            int[] nums = new int[] { 2, 3, 0, 4, 1 };
            int actual = LongestConsecutive(nums);

            Assert.AreEqual(5, actual);
        }

        IDictionary<int, Tuple<int,int>> numToRange = new Dictionary<int, Tuple<int,int>>();
        public int LongestConsecutive(int[] nums)
        {
            int result = 0;

            foreach (int currentNum in nums)
            {
                int following = currentNum + 1;
                int previous = currentNum - 1;                

                if (!numToRange.ContainsKey(currentNum))
                {
                    Tuple<int, int> range = new Tuple<int, int>(currentNum, currentNum);
                    numToRange.Add(currentNum, range);

                    int chainLength = Math.Abs(range.Item2 - range.Item1) + 1;

                    if (chainLength > result)
                    {
                        result = chainLength;
                    }

                    //Current: 4
                    //Previous: 3
                    if (numToRange.ContainsKey(previous)) // (3)->[1,3], (4)->[4,4] => (3),(4)->[1,4]
                    {
                        int startRange = numToRange[previous].Item1; //1
                        int endRange = numToRange[currentNum].Item2; //1
                        Tuple<int, int> newRange = new Tuple<int, int>(startRange, endRange);

                        numToRange[previous] = newRange;
                        numToRange[currentNum] = newRange;
                        numToRange[startRange] = newRange;
                        numToRange[endRange] = newRange;

                        chainLength = Math.Abs(newRange.Item2 - newRange.Item1) + 1;

                        if (chainLength > result)
                        {
                            result = chainLength;
                        }
                    }

                    // Current: 3
                    // Following: 4
                    if (numToRange.ContainsKey(following)) // [4, 3],{ 4, (4) }, { 3, (3) } => { 4, -- }, { 3, (3)->(4) }
                    {
                        int endRange = numToRange[following].Item2; //1
                        int startRange = numToRange[currentNum].Item1;
                        Tuple<int, int> newRange = new Tuple<int, int>(startRange, endRange);

                        numToRange[following] = newRange;
                        numToRange[currentNum] = newRange;
                        numToRange[endRange] = newRange;
                        numToRange[startRange] = newRange;

                        chainLength = Math.Abs(newRange.Item2 - newRange.Item1) + 1;

                        if (chainLength > result)
                        {
                            result = chainLength;
                        }
                    }
                }
            }

            return result;
        }
    }

    public class ListNode
    {
        public Guid chainKey;        
        public ListNode(Guid chainKey)
        {
            this.chainKey = chainKey;
        }
    }
}