using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;
namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["add_address.cshtml"];
      };

      Post["/address/new"] = _ => {
        string inputName = Request.Form["new-full-name"];
        string inputHomeAddress = Request.Form["new-home-address"];
        string inputNumber = Request.Form["new-phone-number"];

        Address inputAddress = new Address(inputName, inputHomeAddress, inputNumber);
        inputAddress.AddToAddressBook();

        return View["address_added.cshtml", inputAddress];
      };

      Get["/addresses"] = _ => {
        return View["address_book.cshtml", Address.ViewAddressBook()];
      };

      Post["/addresses/cleared"] = _ => {
        Address.ClearAddressBook();
        return View["/cleared_book.cshtml"];
      };

      Get["/address/selected"] = _ => {
        string selectFullName = Request.Query["myname"];

        return View["selected_address.cshtml",Address.ViewSelectedAddress(selectFullName)];
      };

    }
  }
}
