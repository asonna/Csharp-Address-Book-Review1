using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Address
  {
    private string _fullName;
    private string _homeAddress;
    private string _phoneNumber;

    private static List<Address> _addressBook = new List<Address> {};
    // private static Array<Address> _selectedAddress = new Array<Address>[];

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

    public void AddToAddressBook()
    {
      _addressBook.Add(this);
    }

    public static List<Address> ViewAddressBook()
    {
      return _addressBook;
    }

    public static void ClearAddressBook()
    {
      _addressBook.Clear();
    }


    public static  List<Address> ViewSelectedAddress(string _fullname)
    {
       List<Address> selectedAddress =   new List<Address> {};
      foreach (Address _addr in _addressBook)
      {
        if (_addr.GetFullName() == _fullname)
        {
          selectedAddress.Add(_addr);
          break;
        }
      }
        return selectedAddress;
    }
  }
}
