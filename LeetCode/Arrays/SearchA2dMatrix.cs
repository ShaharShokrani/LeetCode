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
    /// https://leetcode.com/problems/search-a-2d-matrix/
    /// </summary>
    [TestClass]
    public class SearchA2dMatrix
    {
        [TestMethod]
        public void SearchMatrixTest()
        {
            Assert.AreEqual(true, SearchMatrix(new int[][]
                                        {
                                        new int[] { 1,3,5,7 },
                                        new int[] { 10,11,16,20 },
                                        new int[] { 23, 30, 34, 60 }
                                        }, 3));
        }

        [TestMethod]
        public void SearchMatrixTest2()
        {
            Assert.AreEqual(false, SearchMatrix(new int[][]
                                        {
                                        new int[] { 1,3,5,7 },
                                        new int[] { 10,11,16,20 },
                                        new int[] { 23, 30, 34, 60 }
                                        }, 13));


        }

        public bool SearchMatrix(int[][] matrix, int target)
        {
            bool result = false;

            int columns = matrix[0].Length;
            int rows = matrix.Length;

            int left = 0;
            int right = columns * rows - 1;
            while (left <= right)
            {
                int pivot = (left + right) / 2;
                int pivotElement = matrix[pivot / columns][pivot % columns]; //pivot / columns gives us the row number [ 0,0,0,0 - 1,1,1,1 - 2,2,2,2] = [0,1,2,3 - 4,5,6,7 - 8,9,10,11]

                if (pivotElement == target)
                {
                    return true;
                }
                else
                {
                    if (target < pivotElement)
                        right--;
                    else
                        left++;
                }
            }

            return result;
        }
    }
}