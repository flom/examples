using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
  class Program
  {
    static void Main(string[] args)
    {
      var q = new HeapPriorityQueue(15);

      int[] foo = new int[] { 25, 50, 20, 7, 30, 15, 5, 10, 1 };
      for (int i = 0; i < foo.Length; i++)
      {
        q.Insert(foo[i]);
      }

      for (int i = 0; i < foo.Length; i++)
      {
        Console.WriteLine(q.ExtractMinimum());
      }

      Console.Read();
    }
  }
}
