using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace LeetCode.BinarySearch
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    [TestClass]
    public class SearchInsertPosition
    {
        [TestMethod]
        public void SearchInsertTest()
        {
            Assert.AreEqual(2, SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
        }

        [TestMethod]
        public void SearchInsertTest2()
        {
            Assert.AreEqual(1, SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
        }

        [TestMethod]
        public void SearchInsertTest3()
        {
            Assert.AreEqual(4, SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
        }

        [TestMethod]
        public void SearchInsertTest4()
        {
            Assert.AreEqual(0, SearchInsert(new int[] { 1, 3, 5, 6 }, 0));
        }

        [TestMethod]
        public void SearchInsertTest5()
        {
            Assert.AreEqual(0, SearchInsert(new int[] { 1 }, 0));
        }

        /// <summary>
        /// O ( N )
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int i;
            for (i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    return i;
                }

                if (target < nums[i])
                {
                    return i;
                }
                
                if (target > nums[i])
                {
                    continue;
                }
            }

            return i;
        }


        [TestMethod]
        public void SearchInsert2Test()
        {
            Assert.AreEqual(2, SearchInsert2(new int[] { 1, 3, 5, 6 }, 5));
        }

        [TestMethod]
        public void SearchInsert2Test2()
        {
            Assert.AreEqual(1, SearchInsert2(new int[] { 1, 3, 5, 6 }, 2));
        }

        [TestMethod]
        public void SearchInsert2Test3()
        {
            Assert.AreEqual(4, SearchInsert2(new int[] { 1, 3, 5, 6 }, 7));
        }

        [TestMethod]
        public void SearchInsert2Test4()
        {
            Assert.AreEqual(0, SearchInsert2(new int[] { 1, 3, 5, 6 }, 0));
        }

        [TestMethod]
        public void SearchInsert2Test5()
        {
            Assert.AreEqual(0, SearchInsert2(new int[] { 1 }, 0));
        }

        [TestMethod]
        public void SearchInsert2Test6()
        {
            Assert.AreEqual(0, SearchInsert2(new int[] { 1 }, 1));
        }
        /// <summary>
        /// O ( N logN )
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert2(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] >= target)
                    return left;

                if (nums[right] < target)
                    return right + 1;

                left++;
                right--;
            }

            return left;
        }
    }
}