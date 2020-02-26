namespace Dealership.Models
{
  public class Car
  {
    // Example setting "visibility" and creating "encapsulation" within our Car class by setting our fields to "private" 
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    // Getter method example (instance method)
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    // Setter method example (instance method)
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }

    // Static method example
    public static string MakeSound(string sound)
    {
      return "You know Lonny's Lemons are truly lemons because our cars make " + sound + " sounds!";
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
  }
}