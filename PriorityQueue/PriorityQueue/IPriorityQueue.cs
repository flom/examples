using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
  public interface IPriorityQueue
  {
    // inserts new key and returns unique ID associated to key
    int Insert(int key);
    // returns minimum key and removes it from queue
    int ExtractMinimum();
    // returns minimum key without removing it from queue
    int FindMinimum();
    // decreases key with given id
    void DecreaseKey(int id, int newKey);
    // returns number of elements in queue
    int Number();
  }
}
