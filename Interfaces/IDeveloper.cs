using inht_inter.Models;

namespace inht_inter.Interfaces
{
  public interface IDeveloper
  {
    int Repositories { get; set; }
    void WriteCode(Music music);
    bool EatDoritos();

  }
}