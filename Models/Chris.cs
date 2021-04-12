using inht_inter.Interfaces;

namespace inht_inter.Models
{
  public class Chris : Person, IDeveloper, ITrader
  {
    public Chris(int repositories, string name, int age) : base(name, age)
    {
      Repositories = repositories;
    }

    public int Repositories { get; set; }

    public bool EatDoritos()
    {
      System.Console.WriteLine(" I dont like doritos");
      return false;
    }

    public bool MakeMoney()
    {
      throw new System.NotImplementedException();
    }

    public override int MileTime()
    {
      throw new System.NotImplementedException();
    }

    public void WriteCode(Music music)
    {
      System.Console.WriteLine("this things like a whole checkpoint");
    }
  }
}