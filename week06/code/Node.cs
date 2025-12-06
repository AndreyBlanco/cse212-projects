using System.ComponentModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        var contain = false;

        if (value == Data)
        {
            contain = true;
        }
        else if (value > Data)
        {
            if (Right is null)
            {
                contain = false;
            }
            else contain = Right.Contains(value);
        }
        else if (value < Data)
        {
            if (Left is null)
            {
                contain = false;
            }
            else contain = Left.Contains(value);
        }

        return contain;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        var heightRight = 0;
        var heightLeft = 0;
        var result = 1;

        if (Left is not null) heightLeft += Left.GetHeight();
        if (Right is not null) heightRight += Right.GetHeight();

        if (heightRight > heightLeft) result += heightRight;
        else result += heightLeft;

        return result; // Replace this line with the correct return statement(s)
    }
}