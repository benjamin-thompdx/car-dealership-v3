using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      CustomerService prospect = new CustomerService("(948)564-9385", "lonnyslemons@hotmail.com", " @lonnyssicklemons");
      CustomerService customer = new CustomerService("(495)925-9854", "lonnyscustomer@gmail.com", "@lonnyssicklemons");

      // Example calling on/evoking the Setter method
      yugo.SetPrice(300);

      Console.WriteLine("Welcome to Lonny's! Are you interested in buying a car today? (Y/N)");
      string userResponse = Console.ReadLine().ToLower();
      
      if (userResponse == "n")
      {
        Console.WriteLine("If you change your mind, feel free to contact us! " + prospect.GetEmail() + " " + prospect.GetPhone() + " " + prospect.GetSocialMedia());
      }
      else if (userResponse == "y")
      {
        Console.WriteLine("Enter maximum price: ");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);

        List<Car> CarsMatchingSearch = new List<Car>(0);

        foreach (Car automobile in Cars)
        {
          if (automobile.WorthBuying(maxPrice))
          {
            CarsMatchingSearch.Add(automobile);
          }
        }

        foreach(Car automobile in CarsMatchingSearch)
        {
          Console.WriteLine("---------------");
          // Example calling on/evoking a the Getter method (instance method)
          Console.WriteLine(automobile.GetMakeModel());
          Console.WriteLine(automobile.GetMiles() + " miles");
          Console.WriteLine("$" + automobile.GetPrice());
          Console.WriteLine("For customer support, here is our contact information: " + customer.GetPhone() + " " + customer.GetEmail() + " " + customer.GetSocialMedia());
        }
      }

      // Example calling on/evoking a static method
      Console.WriteLine("- - - - - - - -");
      Console.WriteLine(Car.MakeSound("bang"));
    }
  }
}