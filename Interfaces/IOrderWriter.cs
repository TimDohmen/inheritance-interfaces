using System;

namespace inht_inter.Interfaces
{
  public interface IOrderWriter
  {
    int Orders { get; set; }
    static int OrderStock()
    {
      Random random = new Random();
      return random.Next(100);
    }
  }
}