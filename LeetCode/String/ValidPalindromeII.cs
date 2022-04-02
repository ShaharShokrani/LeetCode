using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome-ii/
    /// </summary>
    [TestClass]
    public class ValidPalindromeII
    {
        [TestMethod]
        public void ValidPalindromeTest()
        {
            Assert.AreEqual(true, ValidPalindrome("aba"));
        }

        [TestMethod]
        public void ValidPalindromeTest2()
        {
            Assert.AreEqual(true, ValidPalindrome("abca"));
        }

        [TestMethod]
        public void ValidPalindromeTest3()
        {
            Assert.AreEqual(false, ValidPalindrome("abc"));
        }

        [TestMethod]
        public void ValidPalindromeTest4()
        {
            Assert.AreEqual(true, ValidPalindrome("abcdXcba"));
        }

        [TestMethod]
        public void ValidPalindromeTest5()
        {
            Assert.AreEqual(true, ValidPalindrome("abcXdcba"));
        }

        [TestMethod]
        public void ValidPalindromeTest6()
        {
            Assert.AreEqual(true, ValidPalindrome("deeee"));
            Assert.AreEqual(true, ValidPalindrome("xxxdeeeexxx"));
        }

        [TestMethod]
        public void ValidPalindromeTest7()
        {
            Assert.AreEqual(true, ValidPalindrome("eeeed"));
        }

        [TestMethod]
        public void ValidPalindromeTest8()
        {
            Assert.AreEqual(true, ValidPalindrome("eedede"));
        }

        [TestMethod]
        public void ValidPalindromeTest9()
        {
            Assert.AreEqual(true, ValidPalindrome("ebcbbececabbacecbbcbe"));
            //Assert.AreEqual(true, ValidPalindrome("_____ececabbacec_____"));
        }

        [TestMethod]
        public void ValidPalindromeTest10()
        {
            Assert.AreEqual(false, ValidPalindrome("eeccccbebaeeabebccceea"));
            //Assert.AreEqual(true, ValidPalindrome("_____ececabbacec_____"));
        }

        [TestMethod]
        public void ValidPalindromeTest11()
        {
            Assert.AreEqual(true, ValidPalindrome("ababbab"));            
        }

        [TestInitialize]
        public void Init()
        {
        }

        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            
            bool hasDifferent = false;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (hasDifferent)
                        return false;

                    hasDifferent = true;

                    if ((s[left] == s[right-1]) && IsPure(s.Substring(left, s.Length - 2 * left - 1)))
                        return true;
                    else if ((s[right] == s[left + 1]) && IsPure(s.Substring(left + 1, s.Length - 2 * left - 1)))
                        return true;
                    else
                        return false;
                }

                left++;
                right--;
            }

            return true;
        }

        private bool IsPure(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}