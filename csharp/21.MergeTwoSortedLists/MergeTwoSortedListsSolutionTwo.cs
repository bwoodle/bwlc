using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32;

internal class MergeTwoSortedListsSolutionTwo
{
    // Optimizing for performance

    public void Test()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var output = MergeTwoLists(list1, list2);
        Console.WriteLine("124 + 134 expect 112344");
        while(output != null)
        {
            Console.WriteLine(output.val);
            output = output.next;
        }
    }

    public ListNode? MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if (list1 == null)
        {
            return list2;
        }
        if (list2 == null)
        {
            return list1;
        }
        var primary = list2;
        var secondary = list1;
        if (list1.val <= list2.val)
        {
            primary = list1;
            secondary = list2;
        }
        var rval = primary;

        while (primary.next != null && secondary != null)
        {
            if (primary.next.val <= secondary.val)
            {
                primary = primary.next;
            }
            else
            {
                var save = secondary.next;
                secondary.next = primary.next;
                primary.next = secondary;
                secondary = save;
            }
        }
        if (secondary != null)
        {
            primary.next = secondary;
        }
        
        return rval;
    }
}

internal class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}