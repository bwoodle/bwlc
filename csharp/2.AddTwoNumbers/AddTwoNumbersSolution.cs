using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class AddTwoNumbersSolution
{
    public void Test()
    {
        var ln1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
        var ln2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
        WriteResult(AddTwoNumbers(ln1, ln2));
        
        var ln3 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null)))))));
        var ln4 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));
        WriteResult(AddTwoNumbers(ln3, ln4));
    }

    private void WriteResult(ListNode? res)
    {
        var str = "[";
        while(res != null)
        {
            str += res.val + ", ";
            res = res.next;
        }
        str = str.Substring(0, str.Length - 2) + "]";
        Console.WriteLine(str);
    }
 
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var rootNode = new ListNode((l1!.val + l2!.val) % 10, null);
        var nextNode = rootNode;
        var remainder = (l1.val + l2.val) / 10;
        l1 = l1.next;
        l2 = l2.next;
        while (l1 != null || l2 != null || remainder != 0)
        {
            Console.WriteLine("l1 " + (l1 != null ? l1.val : 0));
            Console.WriteLine("l2 " + (l2 != null ? l2.val : 0));
            Console.WriteLine("remainder: " + remainder);
            var val = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + remainder;
            Console.WriteLine("val: " + val);
            nextNode.next = new ListNode(val % 10, null);
            remainder = val / 10;
            nextNode = nextNode.next;
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
        }
        return rootNode;
    }
}

// Definition for singly-linked list.
// internal class ListNode
// {
//     public int val;
//     public ListNode? next;
//     public ListNode(int val = 0, ListNode? next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }