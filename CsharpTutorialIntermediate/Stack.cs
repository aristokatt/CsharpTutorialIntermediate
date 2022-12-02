// See https://aka.ms/new-console-template for more information



public class Stack
{
    private List<object> stack = new List<object>();

    public void Push(object obj)
    {
        if (obj == null)
            throw new InvalidOperationException();
        stack.Insert(0, obj);
    }

    public object Pop()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException();
        var topObject = stack[0];
        stack.Remove(topObject);
        return topObject;
    }

    public void Clear()
    {
        stack.Clear();
    }
}