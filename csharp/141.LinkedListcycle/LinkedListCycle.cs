internal class LinkedListCycle
{
    public void Test()
    {
        HasCycle(new ListNode(1));
    }
/*
Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.

The number of the nodes in the list is in the range [0, 10^4].
-10^5 <= Node.val <= 10^5
pos is -1 or a valid index in the linked-list.
*/
    private bool HasCycle(ListNode head) {
        var dictionary = new Dictionary<int, IList<ListNode>>();
        var node = head;
        while(node != null)
        {
            if(dictionary.ContainsKey(node.val) && dictionary[node.val].Contains(node))
            {
                return true;
            }
            if(dictionary.ContainsKey(node.val))
            {
                dictionary[node.val].Add(node);
            }
            else
            {
                dictionary.Add(node.val, new List<ListNode>{node});
            }
            node = node.next;
        }
        return false;
    }

    internal class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
            next = null;
        }
    }
}