namespace CodeChallenges
{
  public class InsertableLinkedList : LinkedList
  {
    //adds a new node with the given value to the end of the list
    public void Append(int value)
    {
      Node newNode = new Node(value); //create a new node with the given value

      if (Head == null) //if the list is empty
      {
        Head = newNode; //make the new node the head of the list
      }
      else //if the list is not empty
      {
        Node current = Head; //start from the head of the list
        while (current.Next != null) //loop until reaching the last node
        {
          current = current.Next; //move to the next node
        }
        current.Next = newNode; //make the new node the next of the last node
      }
    }
    //adds a new node with the given new value immediately before the first node that has the value specified
    public void InsertBefore(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert); //create a new node with the given value to insert

      if (Head != null) //if the list is not empty
      {
        if (Head.Value == value) //if the head of the list has the value specified
        {
          newNode.Next = Head; //make the new node point to the head of the list
          Head = newNode; //make the new node the head of the list
          return; //exit the method
        }

        Node current = Head; //start from the head of the list
        while (current.Next != null) //loop until reaching the node before the one with the value specified or the end of the list
        {
          if (current.Next.Value == value) //if the next node has the value specified
          {
            newNode.Next = current.Next; //make the new node point to the next node
            current.Next = newNode; //make the current node point to the new node
            break; //exit the loop
          }
          current = current.Next; //move to the next node
        }
      }

    }
    //adds a new node with the given new value immediately after the first node that has the value specified
    public void InsertAfter(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert); //create a new node with the given value to insert

      if (Head != null) //if the list is not empty
      {
        Node current = Head; //start from the head of the list
        while (current != null) //loop until reaching the node with the value specified or the end of the list
        {
          if (current.Value == value) //if the current node has the value specified
          {
            newNode.Next = current.Next; //make the new node point to the next node of current node
            current.Next = newNode; //make current node point to new node
            return; //exit method 
          }

          current = current.Next; //move to next node 
        }
      }
    }
