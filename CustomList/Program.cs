using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
  class Program
  {
    static void Main(string[] args)
    {
      // Testing what is actually stored in a list when an object is stored

      List<ObjTestClass> testList = new List<ObjTestClass>();

      for(int i = 0; i < 10; i++)
      {
        testList.Add(new ObjTestClass());
      }

      for(int i = 0; i < testList.Count; i++)
      {
        Console.WriteLine(testList[i]);
      }
      Console.ReadLine();
    }
  }
}