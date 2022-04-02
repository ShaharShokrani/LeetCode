using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    [TestClass]
    public class LengthOfLastWordClass
    {
        [TestMethod]
        public void LengthOfLastWordTest()
        {
            Assert.AreEqual(5, LengthOfLastWord("Hello World"));
            Assert.AreEqual(4, LengthOfLastWord("   fly me   to   the moon  "));
            Assert.AreEqual(6, LengthOfLastWord("luffy is still joyboy"));
        }

        [TestInitialize]
        public void Init()
        {
        }

        public int LengthOfLastWord(string s)
        {
            int result = 0;
                        
            bool hadSpace = false;

            foreach (char item in s)
            {
                if (char.Equals(item, ' '))
                {
                    hadSpace = true;
                }
                else if (hadSpace)
                {
                    result = 1;
                    hadSpace = false;
                }
                else
                {
                    result++;
                }
            }

            return result;
        }
    }
}
