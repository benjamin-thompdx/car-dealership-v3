namespace Dealership.Models
{
  public class CustomerService
  {
    private string _phone;
    private string _email;
    private string _socialMedia;

    public CustomerService(string phone, string email, string socialMedia)
    {
      _phone = phone;
      _email = email;
      _socialMedia = socialMedia;
    }

    public string GetPhone()
    {
      return _phone;
    }
    public string GetEmail()
    {
      return _email;
    }
    public string GetSocialMedia()
    {
      return _socialMedia;
    }
  }
}