
var ddl = new DoublyLinkedList();

ddl.AddToFront(3);
ddl.AddToFront(2);
ddl.AddToFront(1);
ddl.AddToEnd(4);
ddl.AddToEnd(5);

Console.Write("Forward: [ ");
PrintList(ddl.Head);
Console.Write("]");

void PrintList(Node node)
{
    if (node.Next is null)
        return;

    Console.Write(node.Value + " ");
    PrintList(node.Next);   
}

class Node
{
    public object? Value { get; set; }
    public Node? Next { get; set; } = null;
    public Node? Prev { get; set; } = null;

    public Node(object value)
    {
        this.Value = value;
    }
}

class DoublyLinkedList
{
    public Node? Head { get; set; }
    public Node? Tail { get; set; }

    public DoublyLinkedList()
    {
        this.Head = null;
        this.Tail = null;
    }

    public void AddToFront(object value)
    {
        var newNode = new Node(value);

        if (Head is null)
        {
            Head = Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
        }
    }

    public void AddToEnd(object value)
    { 
        var newNode = new Node(value);  

        if(Tail is null)
        {
            Head = Tail = newNode;
        }
        else
        {
            newNode.Prev = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
    }

    public object? RemoveFromFront(Node value)
    {
        if (Head is null)
            return null;

        var removedValue = Head.Value;

        if (Head == Tail)
            Head = Tail = null;
        else
        {
            Head = Head.Next;
            Head.Prev = null;
        }

        return removedValue;
    }

    public object? RemoveFromEnd(Node value)
    {
        if (Tail is null)
            return null;

        var removedValue = Tail.Value;

        if (Head == Tail)
            Head = Tail = null;
        else
        {
            Tail = Tail.Prev;
            Tail.Next = null;
        }

        return removedValue;
    }
}
