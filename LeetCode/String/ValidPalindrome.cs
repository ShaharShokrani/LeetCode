using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    [TestClass]
    public class ValidPalindrome
    {
        [TestMethod]
        public void ValidPalindromeTest()
        {
            Assert.AreEqual(true, IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [TestMethod]
        public void ValidPalindromeTest2()
        {
            Assert.AreEqual(false, IsPalindrome("race a car"));
        }

        [TestMethod]
        public void ValidPalindromeTest3()
        {
            Assert.AreEqual(true, IsPalindrome(" "));
        }

        [TestMethod]
        public void ValidPalindromeTest4()
        {
            Assert.AreEqual(false, IsPalindrome("0P"));
        }

        [TestMethod]
        public void ValidPalindromeTest5()
        {
            Assert.AreEqual(true, IsPalindrome("A man, a plan, a canal: Panama"));
        }
        

        [TestInitialize]
        public void Init()
        {
        }

        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            
            while (left <= right)
            {                
                while (!char.IsLetterOrDigit(s[left]))
                {
                    if (left == right)
                    {
                        break;
                    }
                    left++;
                }

                while (!char.IsLetterOrDigit(s[right]))
                {
                    if (right == left)
                    {
                        break;
                    }
                    right--;
                }

                char leftChar = s[left];
                char rightChar = s[right];
                
                if (char.IsLetterOrDigit(leftChar) && 
                    char.IsLetterOrDigit(rightChar) &&
                    char.ToLower(leftChar) != char.ToLower(rightChar))
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return true;
        }        
    }
}