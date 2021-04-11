using System;
using inht_inter.Models;

namespace inht_inter
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");
      //   Tim tim = new Tim(20, 900, "Timbo");
      Tim tim = new Tim("Tim", 24, 20, 900);

      System.Console.WriteLine(tim.Name);
      System.Console.WriteLine(tim.Orders);
      System.Console.WriteLine(tim.CalculateTime());
    }
  }
}
