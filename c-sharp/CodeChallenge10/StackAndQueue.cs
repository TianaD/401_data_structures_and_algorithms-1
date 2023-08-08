namespace CodeChallenges
{
<<<<<<< HEAD
  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }

  }

  public class Stack
  {
    //Create a Stack class that has a top property. It creates an empty Stack when instantiated
    private Node Top { get; set; }
    public Stack(Node node)
    {
      Top = null; //This object should be aware of a default empty value assigned to top when the stack is created.
    }
    // push class, Arguments: value
    public void Push( int value )
    {
      // adds a new node with that value to the top of the stack with an O(1) Time performance.
      Node newNode = new Node(value);
      newNode.Next = Top;
      Top = newNode;
=======
    public class Node
    {
        
>>>>>>> 5372d16f7aa81242fa014b2e80489e021d50f1e8
    }

  }

public class Queue
{

<<<<<<< HEAD
}
=======
    public class Queue
    {

    }
>>>>>>> 5372d16f7aa81242fa014b2e80489e021d50f1e8
}
