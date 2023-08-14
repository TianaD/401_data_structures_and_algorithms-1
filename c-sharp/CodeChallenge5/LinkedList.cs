namespace CodeChallenges
{
  public class LinkedList
  {
    //property that holds the reference to the first node in the list
    public Node? Head { get; set; }

    //method that inserts a new node with a given value at the beginning of the list
    public void Insert(int value)
    {

      // Create a new node object with the given value
      Node node = new Node(value);

      // Check if the list is empty
      if (Head != null)

      {

        // If !empty, make the new node point to the current head node , make the new node the new head node
        node.Next = Head;
        Head = node;

      }

      else

      {
        // If the list is empty, make the new node the head node
        Head = node;
      }
    }

    // method checks if a given value exists in the list
    public bool Includes(int value)
    {
      // start from the head node and traverse the list
      Node? current = Head;

      while (current != null)

      {

        // if the current node's value matches the given value, return true
        if (current.Value == value)

        {

          return true;

        }
        // else, move to the next node
        current = current.Next;

      }
      // if the loop ends without finding a match, return false
      return false;
    }

    // method returns a string representation of the list
    public override string ToString()

    {

      Node? current = Head;
      string outputStr = "";
      while (current != null)

      {

        // append current node's value and an arrow symbol to the output string, then move to the next node
        outputStr += $"{current.Value} -> ";
        current = current.Next;

      }

      // append NULL to indicate the end of the list
      outputStr += "NULL";
      return outputStr;
    }

  }

  // class represents a node in a linked list
  public class Node
  {
    // A property that holds the reference to the next node in the list
    public Node? Next { get; set; }
    // A property that holds the value stored in the node
    public int Value { get; set; }

    // A constructor that takes a value and initializes a new node object with it
    public Node(int value)
    {
      Value = value;
    }
  }

}
