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
    private T[] list;

    // Properties
    public int Count
    {
      get => count;
    }
    public int Capacity
    {
      get => capacity;
    }

    // Constructor
    public XanderList()
    {
      
    }
  }
}
