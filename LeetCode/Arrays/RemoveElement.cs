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
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    [TestClass]
    public class RemoveElementClass
    {
        [TestMethod]
        public void RemoveElementTest()
        {
            int[] nums = new int[4] { 3, 2, 1, 3 }; // Input array            
            int[] expectedNums = new int[2] { 2, 1 }; // The expected answer with correct length

            int k = RemoveElement(nums, 3); // Calls your implementation

            Assert.AreEqual(expectedNums.Length, k);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }

            /*                        
 3, 2, 1, 3

 i         j          Is3 ?  result
------   ------      -----   ------
 0 (3)                 y       1
        0+1=1 (2)

Switch
2, 2, 1, 3

1 (2)                  n       1
        1+1=2 (1)


2, 1, 1, 3
 */
        }

        [TestMethod]
        public void RemoveElementTest2()
        {
            int[] nums = new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 }; // Input array            
            int[] expectedNums = new int[5] { 0, 1, 3, 0, 4 }; // The expected answer with correct length

            int k = RemoveElement(nums, 2); // Calls your implementation

            Assert.AreEqual(expectedNums.Length, k);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }        

        public int RemoveElement(int[] nums, int val)
        {
            int slowRunner = 0;

            for (int faseRunner = 0; faseRunner < nums.Length; faseRunner++)
            {
                if (nums[faseRunner] != val)
                {
                    nums[slowRunner] = nums[faseRunner];
                    slowRunner++;
                }
            }
            return slowRunner;
        }
    }
}