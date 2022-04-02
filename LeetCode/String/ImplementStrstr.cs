using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/
    /// </summary>
    [TestClass]
    public class ImplementStrstr
    {
        [TestMethod]
        public void StrStrTest()
        {
            Assert.AreEqual(2, StrStr("hello", "ll"));
        }

        [TestMethod]
        public void StrStrTest2()
        {
            Assert.AreEqual(-1, StrStr("aaaaa", "bba"));
        }

        [TestMethod]
        public void StrStrTest3()
        {
            Assert.AreEqual(-1, StrStr("helo", "ll"));
        }

        [TestMethod]
        public void StrStrTest4()
        {
            Assert.AreEqual(2, StrStr("helo", "l"));
        }

        [TestMethod]
        public void StrStrTest5()
        {
            Assert.AreEqual(-1, StrStr("helo", "zl"));
        }

        [TestMethod]
        public void StrStrTest6()
        {
            Assert.AreEqual(-1, StrStr("isisiz", "isip"));
        }

        [TestMethod]
        public void StrStrTest7()
        {
            Assert.AreEqual(4, StrStr("mississippi", "issip"));
        }

        [TestMethod]
        public void StrStrTest8()
        {
            Assert.AreEqual(0, StrStr("a", "a"));
        }

        [TestMethod]
        public void StrStrTest9()
        {
            Assert.AreEqual(-1, StrStr("mississippi", "issipi"));
        }

        [TestInitialize]
        public void Init()
        {
        }

        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0 || needle.Length > haystack.Length)
                return -1;

            char needleChar = char.MinValue;
            char haystackChar = char.MinValue;

            for (int j = 0; j < haystack.Length - needle.Length + 1; j++)
            {
                haystackChar = haystack[j];
                needleChar = needle[0];

                if (haystackChar.Equals(needleChar))
                {
                    bool found = false;
                    for (int i = 0; i < needle.Length; i++)
                    {
                        needleChar = needle[i];
                        haystackChar = haystack[j + i];

                        if (haystackChar.Equals(needleChar))
                        {
                            found = true;                            
                        }
                        else
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                        return j;
                }
            }

            return -1;
        }
    }
}