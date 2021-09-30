using System;

namespace _053506_SIM__Lab1
{
  class MyCustomCollection<T> : ICustomCollection<T>
  {
    public MyCustomCollection()
    {
      head = tail = current = null;
      Count = 0;
    }
    private class Node
    {
      public Node(T data)
      {
        Data = data;
      }
      public T Data { get; set; }
      public Node Next { get; set; }
    }

    private Node head;
    private Node tail;
    private Node current;

    public int Count { get; private set; }
    public void Reset()
    {
      current = head;
    }

    public void Next()
    {
      if (current != null)
        current = current.Next;
      else
        throw new Exception("Can`t increment pointer to the element following the last element");
    }

    public T Current()
    {
      if (current != null)
        return current.Data;
      else
        throw new Exception("No items in collection");
    }

    public void Add(T item)
    {
      if (tail != null)
      {
        tail.Next = new Node(item);
        tail = tail.Next;
      }
      else
      {
        tail = head = current = new Node(item);
      }
      Count++;
    }

    public void Remove(T item)
    {
      if (Count != 0)
      {
        Node found = head;
        Node preFound = null;
        while (!found.Data.Equals(item) && found.Next != null)
        {
          preFound = found;
          found = found.Next;
        }
        if (found.Data.Equals(item))
        {
          if (found == current)
            current = null;

          if (found == head && found == tail)
          {
            head = tail = null;
          }
          else if (found == head)
          {
            head = head.Next;
          }
          else if (found == tail)
          {
            tail = preFound;
            preFound.Next = null;

          }
          else
          {
            preFound.Next = found.Next;
          }
          --Count;
        }
        else
          throw new Exception("Element not found");
      }
      else
        throw new Exception("Element not found");
    }

    public T RemoveCurrent()
    {
      T temp = Current();
      Remove(temp);
      return temp;
    }

    public T this[int index]
    {
      get
      {
        if (index < 0 || index > Count - 1)
          throw new IndexOutOfRangeException();
        int curInd = 0;
        Node temp = head;
        while (curInd++ != index)
          temp = temp.Next;
        return temp.Data;
      }
      set
      {
        if (index < 0 || index > Count - 1)
          throw new IndexOutOfRangeException();
        Node temp = head;
        for (int i = 0; i != index; i++)
          temp = temp.Next;
        temp.Data = value;
      }
    }
  }
}
