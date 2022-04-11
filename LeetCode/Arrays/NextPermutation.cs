using LeetCode.Arrays.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// </summary>
    [TestClass]
    public class NextPermutationClass
    {
        [TestMethod]
        public void NextPermutationTest()
        {
            int[] actual = new int[] { 1, 2, 3 };
            int[] expected = new int[] { 1, 3, 2 };

            NextPermutation(actual);
            
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void NextPermutationTest2()
        {
            int[] actual = new int[] { 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3 };

            NextPermutation(actual);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void NextPermutationTest3()
        {
            int[] actual = new int[] { 1, 1, 5 };
            int[] expected = new int[] { 1, 5, 1 };

            NextPermutation(actual);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void NextPermutationTest4()
        {
            int[] actual = new int[] { 1, 7, 8, 4, 3 };
            int[] expected = new int[] { 1, 8, 3, 4, 7 };

            NextPermutation(actual);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void NextPermutationTest5()
        {
            int[] actual = new int[] { 1, 2 };
            int[] expected = new int[] { 2, 1 };

            NextPermutation(actual);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void NextPermutationTest6()
        {
            int[] actual = new int[] { 1, 3, 2 };
            int[] expected = new int[] { 2, 1, 3 };

            NextPermutation(actual);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void NextPermutationTest7()
        {
            int[] actual = new int[] { 1, 8, 4, 3 };            
            int[] expected = new int[] { 3, 1, 4, 8 };

            NextPermutation(actual);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public void NextPermutation(int[] nums)
        {
            int index = nums.Length - 1;

            while (index >= 1)
            {                
                //Find right bigger than its left
                if (nums[index] > nums[index - 1])
                {
                    //Find candidate index: Must be the minimum of the bigger than the left.
                    int minimumIndex = FindMinimum(nums, index, nums[index - 1]);

                    SwapElement(nums, index-1, minimumIndex);
                    break;
                }
                index--;
            }

            Sorting.SelectionSort(nums, index);                        
        }

        private int FindMinimum(int[] nums, int index, int atLeast)
        {
            int result = index;

            int min = nums[index];
            for (int i = index; i < nums.Length; i++)
            {
                if (nums[i] < min && 
                    nums[i] > atLeast)
                {
                    result = i;
                    min = nums[i];
                }
                    
            }
            return result;
        }

        private void SwapElement(int[] nums, int leftIndex, int rightIndex)
        {
            int temp = nums[leftIndex];
            nums[leftIndex] = nums[rightIndex];
            nums[rightIndex] = temp;
        }
    }
}