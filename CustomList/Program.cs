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
      XanderList<int> test = new XanderList<int>();
      test.Add(1);
      test.Add(2);
      test.Add(3);
      test.Add(4);
      test.Add(5);
      Console.WriteLine(test.Remove(7));
      Console.WriteLine(test[0]);
      Console.WriteLine(test[1]);
      Console.WriteLine(test[2]);
      Console.WriteLine(test[3]);
      Console.WriteLine(test[4]);
      Console.WriteLine($"Count: {test.Count}");

      Console.ReadLine();
    }
  }
}