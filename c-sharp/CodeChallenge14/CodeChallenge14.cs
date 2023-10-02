using System;


namespace CodeChallenges
{
  public class CodeChallenge14
  {


    public class MaxStack : Stack
    {
      public int GetMax()
      {


        Node currentNode = Top;
        int highestValue = Top.Value;


        while (currentNode != null)
        {

          if (currentNode.Value > highestValue)
          {

            highestValue = currentNode.Value;

          }


          currentNode = currentNode.Next;
        }


        return highestValue;

      }

    }

    public static string DuckDuckGoose(string[] stringArray, int k)
    {

      if (k >= stringArray.Length)
      {
        k = 0;
      }

      if (stringArray.Length == 0)
      {
        throw new ArgumentException();
      }

      if (k < 0)
      {
        throw new ArgumentException();
      }

      for (int i = 0; i < stringArray.Length; i++)
      {

        if (i == k)
        {
          return stringArray[i];
        }

      }
      return "";
    }
  }




  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }


    public Node(int value)
    {
      Value = value;
      Next = null;
    }
  }


  public class Stack
  {
    public Node? Top { get; set; }

    public Stack(Node node)
    {
      Top = node;

    }
    public Stack()
    {
      Top = null;


    }

    public void Push(int value)
    {


      Node newNode = new Node(value);


      newNode.Next = Top;
      Top = newNode;

    }



    public bool IsEmpty()
    {

      if (Top == null)
      {
        return true;
      }
      else
      {
        return false;
      }

    }




    public int Pop()
    {

      if (Top == null)
      {
        throw new Exception("Stack is empty");

      }
      int value = Top.Value;
      Top = Top.Next;

      return value;

    }

    public int Peek()
    {
      if (Top == null)
      {
        throw new Exception("Oh no! Empty Stack");

      }

      return Top.Value;

    }
  }
}
