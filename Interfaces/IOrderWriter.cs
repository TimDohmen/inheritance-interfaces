namespace inht_inter.Interfaces
{
  public interface IOrderWriter
  {
    int Orders { get; set; }
    int OrderStock()
    {
      Orders++;
      return Orders;
    }
  }
}