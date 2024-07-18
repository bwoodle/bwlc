internal class IntersectionOfLinkedLists
{
    public void Test()
    {
        GetIntersectionNode(new ListNode(1), new ListNode(2));
    }

/*
Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.

For example, the following two linked lists begin to intersect at node c1:

The test cases are generated such that there are no cycles anywhere in the entire linked structure.

Note that the linked lists must retain their original structure after the function returns.

The number of nodes of listA is in the m.
The number of nodes of listB is in the n.
1 <= m, n <= 3 * 10^4
1 <= Node.val <= 10^5
0 <= skipA < m
0 <= skipB < n
intersectVal is 0 if listA and listB do not intersect.
intersectVal == listA[skipA] == listB[skipB] if listA and listB intersect.
*/
    public ListNode? GetIntersectionNode(ListNode headA, ListNode headB) {
        var stackA = new Stack<ListNode>();
        var stackB = new Stack<ListNode>();

        while(headA != null)
        {
            stackA.Push(headA);
            headA = headA.next;
        }
        while(headB != null)
        {
            stackB.Push(headB);
            headB = headB.next;
        }

        if (stackA.Peek() != stackB.Peek())
        {
            return null;
        }
        while(stackA.Peek() == stackB.Peek() && stackA.Count > 1 && stackB.Count > 1)
        {
            stackA.Pop();
            stackB.Pop();
        }
        if (stackA.Peek() == stackB.Peek())
        {
            // The intersected node is at the beginning of either headA or headB
            return stackA.Peek();
        }
        return stackA.Peek().next;
    }

    internal class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}

