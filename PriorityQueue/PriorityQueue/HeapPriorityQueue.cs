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

    public HeapPriorityQueue(int maxNumber)
    {
      elements = new int[maxNumber];
    }

    public int Insert(int key)
    {
      throw new NotImplementedException();
    }

    public int ExtractMinimum()
    {
      throw new NotImplementedException();
    }

    public int FindMinimum()
    {
      throw new NotImplementedException();
    }

    public void DecreaseKey(int id, int newKey)
    {
      throw new NotImplementedException();
    }

    public int Number()
    {
      throw new NotImplementedException();
    }
  }
}
