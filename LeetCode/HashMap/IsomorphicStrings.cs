using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/isomorphic-strings/
    /// </summary>
    [TestClass]
    public class IsomorphicStrings
    {
        [TestMethod]
        public void IsIsomorphicTest()
        {
            //Assert.IsTrue(IsIsomorphic("egg", "add"));
            //Assert.IsFalse(IsIsomorphic("foo", "bar"));
            //Assert.IsTrue(IsIsomorphic("paper", "title"));
            Assert.IsFalse(IsIsomorphic("ac", "aa"));            
        }

        [TestInitialize]
        public void Init()
        {
        }

        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> set = new Dictionary<char, char>();
            HashSet<char> ts = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (set.ContainsKey(s[i]))
                {
                    if (set[s[i]] != t[i])
                        return false;
                }
                else
                {
                    if (ts.Contains(t[i]))
                    {
                        return false;
                    }
                    else
                    {
                        ts.Add(t[i]);
                        set.Add(s[i], t[i]);
                    }
                }
            }
            return true;
        }
    }
}