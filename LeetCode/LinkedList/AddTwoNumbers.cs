using LeetCode.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    [TestClass]
    public class AddTwoNumbersClass
    {
        [TestMethod]
        public void AddTwoNumbersTest1()
        {
            ListNode list1 = new ListNode()
            {
                val = 2,
                next = new ListNode()
                {
                    val = 4,
                    next = new ListNode()
                    {
                        val = 3
                    }
                }
            };
            ListNode list2 = new ListNode()
            {
                val = 5,
                next = new ListNode()
                {
                    val = 6,
                    next = new ListNode()
                    {
                        val = 4
                    }
                }
            };
            ListNode expected = new ListNode()
            {
                val = 7,
                next = new ListNode()
                {
                    val = 0,
                    next = new ListNode()
                    {
                        val = 8
                    }
                }
            };
            //171
            ListNode? actual = AddTwoNumbers(list1, list2);
            LinkedListAssertion.AssertLinkedList(actual, expected);
        }

        [TestMethod]
        public void AddTwoNumbersTest2()
        {
            ListNode list1 = new ListNode()
            {
                val = 0
            };
            ListNode list2 = new ListNode()
            {
                val = 0
            };
            ListNode expected = new ListNode()
            {
                val = 0
            };
            //171
            ListNode? actual = AddTwoNumbers(list1, list2);
            LinkedListAssertion.AssertLinkedList(actual, expected);
        }

        [TestMethod]
        public void AddTwoNumbersTest3()
        {
            ListNode list1 = new ListNode()
            {
                val = 9,
                next = new ListNode()
                {
                    val = 9,
                    next = new ListNode()
                    {
                        val = 9,
                        next = new ListNode()
                        {
                            val = 9,
                            next = new ListNode()
                            {
                                val = 9,
                                next = new ListNode()
                                {
                                    val = 9,
                                    next = new ListNode()
                                    {
                                        val = 9
                                    }
                                }
                            }
                        }
                    }
                }
            };

            ListNode list2 = new ListNode()
            {
                val = 9,
                next = new ListNode()
                {
                    val = 9,
                    next = new ListNode()
                    {
                        val = 9,
                        next = new ListNode()
                        {
                            val = 9
                        }
                    }
                }
            };

            ListNode expected = new ListNode()
            {
                val = 8,
                next = new ListNode()
                {
                    val = 9,
                    next = new ListNode()
                    {
                        val = 9,
                        next = new ListNode()
                        {
                            val = 9,
                            next = new ListNode()
                            {
                                val = 0,
                                next = new ListNode()
                                {
                                    val = 0,
                                    next = new ListNode()
                                    {
                                        val = 0,
                                        next = new ListNode()
                                        {
                                            val = 1
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            //171
            ListNode? actual = AddTwoNumbers(list1, list2);
            LinkedListAssertion.AssertLinkedList(actual, expected);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode();
            ListNode current = dummyHead;
            int curry = 0;

            while (l1 != null || l2 != null)
            {                
                int sum = curry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                current.next = new ListNode(sum % 10);
                current = current.next;

                curry = sum > 9 ? 1 : 0;
            }

            if (curry == 1)
            {
                current.next = new ListNode(1);
            }

            return dummyHead.next;
        }
    }
}