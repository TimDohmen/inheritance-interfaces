using System;
using System.Collections.Generic;
using inht_inter.Interfaces;
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

      Chris chris = new Chris(400, "Chris", 30);
      System.Console.WriteLine(chris.CalculateTime());
      System.Console.WriteLine(chris.EatDoritos());
      System.Console.WriteLine(tim.EatDoritos());

      System.Console.WriteLine((tim as IOrderWriter).Orders);

      List<IDeveloper> developers = new List<IDeveloper>();
      Kaleb kaleb = new Kaleb("Kaleb", 29);
      Music kalebsMusic = (kaleb as IMusician).PlayMusic();
      // kaleb.
      developers.Add(tim);
      developers.Add(chris);
      developers.Add(kaleb);
      developers.ForEach(developer =>
      {
        if (developer is Person)
        {
          // NOTE Two different ways of casting to a type
          Person p = developer as Person;
          Person person = (Person)developer;
          System.Console.WriteLine($"Hi my name is {p.Name}");

        }
        if (developer is IMusician)
        {
          IMusician ownMusicMaker = (IMusician)developer;
          Music selfMadeMusic = ownMusicMaker.PlayMusic();
          developer.WriteCode(selfMadeMusic);
        }
        developer.WriteCode(kalebsMusic);
      });


    }
  }
}
