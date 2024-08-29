using LeetCode.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-cycle/
    /// </summary>
    [TestClass]
    public class LinkedListCycle
    {
        [TestMethod]
        public void HasCycleTest1()
        {
            ListNode three = new ListNode(3);
            ListNode two = new ListNode(2);
            ListNode zero = new ListNode(2);
            ListNode four = new ListNode(-4);
            
            
            three.next = two;
            two.next = zero;
            zero.next = four;
            four.next = two;
            
            Assert.IsTrue(HasCycle(three));
        }

        public bool HasCycle(ListNode head)
        {
            if (head != null &&
                head.next != null && 
                head.next.next != null)
            {
                return DoubleRound(head.next, head.next.next);
            }

            return false;
        }

        private bool DoubleRound(ListNode next, ListNode next_next)
        {
            if (next == null || next_next == null)
                return false;

            if (next ==  next_next)
                return true;

            if (next.next != null &&
                next_next.next != null &&
                next_next.next.next != null)
            {
                return DoubleRound(next.next, next_next.next.next);
            }

            return false;
        }
    }
}