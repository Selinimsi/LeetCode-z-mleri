using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode current = head;

        while (current != null && current.next != null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
}

class Program
{
    static void Main()
    {
        // 1 -> 1 -> 2 -> 3 -> 3
        ListNode head = new ListNode(1,
            new ListNode(1,
                new ListNode(2,
                    new ListNode(3,
                        new ListNode(3)))));

        Solution sol = new Solution();
        ListNode result = sol.DeleteDuplicates(head);

        PrintList(result); // 1 -> 2 -> 3
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
    }
}