internal class ValidParens
{
    public void Test()
    {
        Console.WriteLine($"Expect {IsValid("()")} to be true");
        Console.WriteLine($"Expect {IsValid("()[]{}")} to be true");
        Console.WriteLine($"Expect {IsValid("(])")} to be false");
    }
/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
*/
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == ']' && stack.Count > 0 && stack.Peek() == '[')
            {
                stack.Pop();
            }
            else if (s[i] == ')' && stack.Count > 0 && stack.Peek() == '(')
            {
                stack.Pop();
            }
            else if (s[i] == '}' && stack.Count > 0 && stack.Peek() == '{')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        return stack.Count == 0;
    }

}