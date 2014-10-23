using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
  public class HeapPriorityQueue : IPriorityQueue
  {
    private int[] elements;
    private int[] indicies;
    private int length;
    private int idCounter;

    public HeapPriorityQueue(int maxNumber)
    {
      elements = new int[maxNumber + 1]; // + 1 because index starts at 1
      indicies = new int[maxNumber + 1];
      elements[0] = -1; // index 0 not used
      length = 0;
      idCounter = 0;
    }

    public int Insert(int key)
    {
      idCounter++;

      elements[length + 1] = key;
      indicies[length + 1] = idCounter;

      HeapifyUp(length + 1);

      length++;

      return idCounter;
    }

    public int ExtractMinimum()
    {
      int minimum = elements[1];

      Swap(1, length);
      length--;
      HeapifyDown(1);

      return minimum;
    }

    public int FindMinimum()
    {
      return elements[1];
    }

    public void DecreaseKey(int id, int newKey)
    {
      int index = 0;
      for (int i = 1; i <= length; i++)
      {
        if (indicies[i] == id)
        {
          index = i;
          break;
        }
      }

      elements[index] = newKey;
      HeapifyUp(index);
    }

    public int Number()
    {
      return length;
    }

    private void HeapifyUp(int index)
    {
      if (index == 1) return;

      int parent = index / 2;

      if (elements[index] < elements[parent])
      {
        Swap(parent, index);

        HeapifyUp(parent);
      }
    }

    private void HeapifyDown(int index)
    {
      int left = index * 2;
      int right = (index * 2) + 1;

      int minimum = index;

      if (left <= length && elements[left] < elements[minimum])
      {
        minimum = left;
      }
      if (right <= length && elements[right] < elements[minimum])
      {
        minimum = right;
      }

      if (minimum != index)
      {
        Swap(index, minimum);
        HeapifyDown(minimum);
      }
    }

    private void Swap(int index1, int index2)
    {
      int temp = elements[index1];
      elements[index1] = elements[index2];
      elements[index2] = temp;

      temp = indicies[index1];
      indicies[index1] = indicies[index2];
      indicies[index2] = temp;
    }
  }
}
