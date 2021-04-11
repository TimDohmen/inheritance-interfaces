using inht_inter.Interfaces;

namespace inht_inter.Models
{
  public class Tim : Person, IDeveloper, IOrderWriter
  {
    public Tim(string name, int age, int orders, int repositories) : base(name, age)
    {
      Orders = orders;
      Repositories = repositories;
    }

    public int Orders { get; set; }
    public int Repositories { get; set; }

    public bool EatDoritos()
    {
      throw new System.NotImplementedException();
    }

    public override int MileTime()
    {
      throw new System.NotImplementedException();
    }

    //can use virtual in the base class to define and still override in the inheriting class
    public override int CalculateTime()
    {
      return (Age * 2) / 2;
    }
    public void WriteCode()
    {
      System.Console.WriteLine("Anything but carousels.");
    }
  }
}