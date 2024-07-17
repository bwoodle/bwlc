public class MinStack {

/*
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

Implement the MinStack class:

MinStack() initializes the stack object.
void push(int val) pushes the element val onto the stack.
void pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int getMin() retrieves the minimum element in the stack.
You must implement a solution with O(1) time complexity for each function.

-231 <= val <= 231 - 1
Methods pop, top and getMin operations will always be called on non-empty stacks.
At most 3 * 104 calls will be made to push, pop, top, and getMin.
*/
    private int[] _currentMin;
    private int[] _stack;
    private int _headIdx = 0;

    public MinStack() {
        _currentMin = new int[10000];
        _stack = new int[10000];
    }
    
    public void Push(int val) {
        if(_headIdx == 0 || val < _currentMin[_headIdx - 1])
        {
            _currentMin[_headIdx] = val;
        }
        else
        {
            _currentMin[_headIdx] = _currentMin[_headIdx - 1];
        }
        _stack[_headIdx++] = val;
    }
    
    public void Pop() {
        if (_headIdx > 0)
        {
            _headIdx--;
        }
    }
    
    public int Top() {
        if (_headIdx > 0)
        {
            return _stack[_headIdx-1];
        }
        return -1;
    }
    
    public int GetMin() {
        if (_headIdx > 0)
        {
            return _currentMin[_headIdx-1];
        }
        return -1;
    }
}
