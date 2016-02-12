using System.Collections.Generic;
namespace Contacts.Objects
{
  public class Contact
  {
    private string _name;
    private int _phoneNumber;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string Name, string PhoneNumber, string Address)
    {
      _name = Name;
      _phoneNumber = PhoneNumber;
      _address = Address;
      _instances.Add(this);
      _instances.Count();
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void DeleteAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances(searchId - 1);
    }
  }
}
