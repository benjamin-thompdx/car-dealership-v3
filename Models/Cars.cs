namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
  }
}