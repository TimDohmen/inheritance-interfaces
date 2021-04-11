namespace inht_inter.Models
{
  public abstract class Person
  {
    protected Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public string Name { get; private set; }
    public int Age { get; set; }

    public abstract int MileTime();
    // cannot declare a body for a method if it is marked abstract
    public virtual int CalculateTime()
    {
      return (Age * 7) / 2;
    }



  }
}