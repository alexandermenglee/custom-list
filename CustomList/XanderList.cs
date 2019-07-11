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
      capacity = 4;
      list = new T[capacity];
      count = 0;
    }

    // Member methods
    public void Add(T input)
    {
      // if count does not equal capacity add it into the list
      // else create a temporary array with capacity = capacity * 2
        // copy everything from list to the temporary array
        // reassign list to the temporary array
        // add input into list[count]
      // increment count

      if(count != capacity)
      {
        list[count] = input;
      }
      else
      {
        capacity *= 2;
        T[] temporaryList = new T[capacity];

        // copies everything from list to temporaryList
        for(int i = 0; i < list.Length; i++)
        {
          temporaryList[i] = list[i];
        }

        list = temporaryList;
        list[count] = input;
      }
      count++;
    }

    public bool Remove(T value)
    {
      // loop through array (list)
      // check if element at i equals value
      // if true 
        // set the value of i to the value of i+1
                
      for(int i = 0; i < count; i++)
      {
        if(list[i].Equals(value))
        {
          for(int j = i; j < count - 1; j++)
          {
            list[j] = list[j + 1];
          }
          count--;
          return true;  
        }
      }
      return false;
    }

    public override string ToString()
    {
      return "";
    }

  }
}
