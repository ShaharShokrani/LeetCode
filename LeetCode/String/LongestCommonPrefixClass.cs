using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    [TestClass]
    public class LongestCommonPrefixClass
    {

        [TestMethod]
        public void RomanToIntTest()
        {
            Assert.AreEqual("fl", LongestCommonPrefix(new string[3] { "flower", "flow", "flight" }));
            Assert.AreEqual("", LongestCommonPrefix(new string[3] { "dog", "racecar", "car" }));
            Assert.AreEqual("c", LongestCommonPrefix(new string[2] { "cir", "car" }));            
        }

        [TestInitialize]
        public void Init()
        {

        }

        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder result = new StringBuilder();
            result.Append(strs[0]);

            for (int i = 1; i < strs.Length; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int j = 0; j < Math.Min(strs[i].Length, result.Length) ; j++)
                {
                    if (strs[i][j] == result[j])
                        stringBuilder.Append(strs[i][j]);
                    else
                        break;
                }
                result = stringBuilder;
            }

            return result.ToString();
        }
    }
}
