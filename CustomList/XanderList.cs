using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
  public class XanderList<T>
  {
    // Member variables
    private int count;
    private int capacity;
    // access level type [ ] < Name_Array > = new < datatype > [size];
    public T[] list;

    // Properties
    public int Count
    {
      get => count;
    }
    public int Capacity
    {
      get => capacity;
    }
    // indexer, allows user to use bracket notation
    public T this[int i]
    {
      get => list[i];
      set => list[i] = value;
    }

    // Constructor
    public XanderList()
    {
        
    }

    // Member methods

  }
}
