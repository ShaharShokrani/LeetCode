using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Maths
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    [TestClass]
    public class ValidParentheses
    {
        [TestMethod]
        public void IsValidTest()
        {
            Assert.AreEqual(true, IsValid("()"));
            Assert.AreEqual(true, IsValid("()[]{}"));
            Assert.AreEqual(false, IsValid("(]"));
            Assert.AreEqual(false, IsValid("([)]"));
            Assert.AreEqual(true, IsValid("{{}[][[[]]]}"));
            Assert.AreEqual(true, IsValid("[[[]]]"));
            Assert.AreEqual(true, IsValid("{}[]"));
        }

        [TestInitialize]
        public void Init()
        {            
        }
        Stack<char> _stack;

        public bool IsValid(string s)
        {
            _stack = new Stack<char>();
            foreach (char item in s)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    _stack.Push(item);
                }
                else
                {                     
                    if (_stack.TryPeek(out char peeked))
                    {
                        if ((item == ')' && peeked == '(') || 
                            (item == ']' && peeked == '[') ||
                            (item == '}' && peeked == '{'))
                            _stack.Pop();
                        else
                            return false;
                    }
                    else
                    {
                        return false;
                    }                    
                }
            }

            return _stack.Count == 0;
        }
    }
}