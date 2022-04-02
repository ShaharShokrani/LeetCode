using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    [TestClass]
    public class RomanToInteger
    {
        private IDictionary<char, int> _romanLetters = new Dictionary<char, int>();
        private IDictionary<string, int> _romanSubstract = new Dictionary<string, int>();

        [TestMethod]
        public void RomanToIntTest()
        {
            Assert.AreEqual(3, RomanToInt("III"));
            Assert.AreEqual(58, RomanToInt("LVIII"));
            Assert.AreEqual(1994, RomanToInt("MCMXCIV"));
        }

        [TestInitialize]
        public void Init()
        {
            _romanLetters.Add('I', 1);
            _romanLetters.Add('V', 5);
            _romanLetters.Add('X', 10);
            _romanLetters.Add('L', 50);
            _romanLetters.Add('C', 100);
            _romanLetters.Add('D', 500);
            _romanLetters.Add('M', 1000);

            _romanSubstract.Add("IV", -2);
            _romanSubstract.Add("IX", -2);
            _romanSubstract.Add("XL", -20);
            _romanSubstract.Add("XC", -20);
            _romanSubstract.Add("CD", -200);
            _romanSubstract.Add("CM", -200);
        }

        public int RomanToInt(string s)
        {            
            int result = 0;
            char previous = '\0';
            foreach (char current in s)
            {
                result = result + _romanLetters[current];

                var substractKey = string.Concat(previous, current);
                if (_romanSubstract.ContainsKey(substractKey))
                {
                    result = result + _romanSubstract[substractKey];
                }

                previous = current;
            }
            
            return result;
        }
    }
}
