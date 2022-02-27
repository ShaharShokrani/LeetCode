using LeetCode.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    [TestClass]
    public class MergeTwoSortedLists
    {
        [TestMethod]
        public void MergeTwoListsTest()
        {
            ListNode list1 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 4                        
                    }
                }
            };
            ListNode list2 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 4
                    }
                }
            };
            ListNode expected = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val = 3,
                            next = new ListNode()
                            {
                                val = 4,
                                next = new ListNode()
                                {
                                    val = 4
                                }
                            }
                        }
                    }
                }
            };
            //171
            ListNode? actual = MergeTwoLists(list1, list2);
            AssertLinkedList(actual, expected);
        }

        private void AssertLinkedList(ListNode actual, ListNode expected)
        {
            if (actual == null)
                return;

            Assert.AreEqual(actual.val, expected.val);
            AssertLinkedList(actual.next, expected.next);
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }
            else if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}