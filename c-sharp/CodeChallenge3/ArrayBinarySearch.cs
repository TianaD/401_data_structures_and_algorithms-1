namespace CodeChallenges
{
  public class CodeChallenge3
  {
    //public static int method named BinarySearch that takes two parameters: an integer array named array and an integer named key
    public static int BinarySearch(int[] array, int key)
    {
      //  integer variable named low initialized to 0
      int low = 0;
      // integer variable named high initialized to the length of the array minus 1
      int high = array.Length - 1;
      // while loop that continues as long as low is less than or equal to high
      while (low <= high)
      {
        // mid is calculated by adding low and high together and dividing by 2
        int mid = (low + high) / 2;
        // if statement checks if the key matches the element at the middle index of the array
        if (key == array[mid])
        {
          // if the key matches the element at the middle index of the array, then mid is returned
          return mid;
        }
        else if (key < array[mid])
        {
          // if the key is less than the element at the middle index of the array, then high is set to be one less than the middle index
          high = mid - 1;
        }
        else if (key > array[mid])
        {
          // if the key is greater than the element at the middle index of the array, then low is set to be one more than the middle index
          low = mid + 1;
        }
      }
      return -1;
    }
  }
}
