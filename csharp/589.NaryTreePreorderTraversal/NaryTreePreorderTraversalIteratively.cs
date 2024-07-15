internal class NaryTreePreorderTraversalIteratively
{
    public void Test()
    {
        // Too much work to create complex test cases
        Preorder(new Node());
    }
/*
Given the root of an n-ary tree, return the preorder traversal of its nodes' values.

Nary-Tree input serialization is represented in their level order traversal. Each group of children is separated by the null value (See examples)

The number of nodes in the tree is in the range [0, 104].
0 <= Node.val <= 104
The height of the n-ary tree is less than or equal to 1000.
*/
    private IList<int> Preorder(Node root) {
        var rval = new List<int>();
        if (root == null)
        {
            return rval;
        }

        rval.Add(root.val);
        
        var stack = new Stack<Node>();
        var node = root;
        while (node != null)
        {
            while(node.children.Count > 0)
            {
                
                var child = node.children[0];
                node.children.Remove(child);
                stack.Push(node);
                node = child;
                rval.Add(node.val);
            }
            if (stack.Count > 0)
            {
                node = stack.Pop();
            }
            else
            {
                node = null;
            }
        }

        return rval;
    }

    internal class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val,IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
}

