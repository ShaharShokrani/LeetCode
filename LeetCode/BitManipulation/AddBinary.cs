using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace LeetCode.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary/
    /// </summary>
    [TestClass]
    public class AddBinaryTests
    {
        [TestMethod]
        public void AddBinaryTest()
        {
            Assert.AreEqual("100", AddBinary("11", "1"));
            Assert.AreEqual("10101", AddBinary("1010", "1011"));
        }

        public string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            while (i >= 0 || j >= 0 || carry != 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0'; // Convert char to int
                    i--;
                }
                if (j >= 0)
                {
                    sum += b[j] - '0'; // Convert char to int
                    j--;
                }
                result.Insert(0, sum % 2); // Append current bit
                carry = sum / 2; // Calculate carry for the next step
            }

            return result.ToString();

        }
    }
}