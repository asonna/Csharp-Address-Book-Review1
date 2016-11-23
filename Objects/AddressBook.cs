using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Address
  {
    private string _fullName;
    private string _homeAddress;
    private string _phoneNumber;

    private static List<Address> _addressList = new List<Address> {};

    public Address (string fullName, string homeAddress,string phoneNumber)
    {
      _fullName = fullName;
      _homeAddress = homeAddress;
      _phoneNumber = phoneNumber;
    }

    public void SetFullName(string newFullName)
    {
      _fullName = newFullName;
    }
    public string GetFullName()
    {
      return _fullName;
    }

    public void SetHomeAddress(string newHomeAddress)
    {
      _homeAddress = newHomeAddress;
    }
    public string GetHomeAddress()
    {
      return _homeAddress;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void AddToAddressList()
    {
      _addressList.Add(this);
    }
    public static List<Address> ViewAddressList()
    {
      return _addressList;
    }
    public static void ClearAddressList()
    {
      _addressList.Clear();
    }
  }
}
