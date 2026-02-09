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

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummy.next;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Liste 1: 1 -> 2 -> 4
        ListNode list1 = CreateList(new int[] { 1, 2, 4 });

        // Liste 2: 1 -> 3 -> 4
        ListNode list2 = CreateList(new int[] { 1, 3, 4 });

        Solution solution = new Solution();
        ListNode merged = solution.MergeTwoLists(list1, list2);

        Console.WriteLine("Birleştirilmiş Liste:");
        PrintList(merged);
    }

    // Array → LinkedList oluşturur
    static ListNode CreateList(int[] values)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        foreach (int val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }

        return dummy.next;
    }

    // LinkedList yazdırır
    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " -> ");
            head = head.next;
        }
        Console.WriteLine("null");
    }
}
