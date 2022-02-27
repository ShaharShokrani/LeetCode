using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.LinkedList
{
    public static class LinkedListAssertion
    {
        public static void AssertLinkedList(ListNode actual, ListNode expected)
        {
            if (actual == null)
                return;

            Assert.AreEqual(actual.val, expected.val);
            AssertLinkedList(actual.next, expected.next);
        }
    }
}