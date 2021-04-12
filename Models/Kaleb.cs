using inht_inter.Interfaces;

namespace inht_inter.Models
{
  public class Kaleb : Person, IDeveloper, IMusician
  {
    public Kaleb(string name, int age) : base(name, age)
    {
    }

    public int Repositories { get; set; }

    public bool EatDoritos()
    {
      System.Console.WriteLine("They aite");
      return true;
    }

    public void WriteCode(Music music)
    {
      System.Console.WriteLine("As long as Ive got some music im good to go");
    }
    //explicit vs implicit implementing of methods
    Music IMusician.PlayMusic()
    {
      System.Console.WriteLine("Makin some music!");
      return new Music();
    }
    // public Music PlayMusic()
    // {
    //   System.Console.WriteLine("Makin some music!");
    //   return new Music();
    // }


    public override int MileTime()
    {
      throw new System.NotImplementedException();
    }


  }
}