using System.Diagnostics.CodeAnalysis;

internal class MergeTwoSortedListsSolution
{


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

    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2) 
    {
        ListNode head = new ListNode();
        ListNode rval = head;
        while(list1 != null || list2 != null)
        {
            if (list1 != null && (list2 == null || list1.val <= list2.val))
            {
                head.next = new ListNode(list1.val);
                head = head.next;
                list1 = list1.next;
            }
            else if (list2 != null && (list1 == null || list2.val < list1.val))
            {
                head.next = new ListNode(list2.val);
                head = head.next;
                list2 = list2.next;
            }
        }
        return rval.next;
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