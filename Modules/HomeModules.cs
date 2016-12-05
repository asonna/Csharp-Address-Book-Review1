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

      Post["/address_added"] = _ => {
        string inputName = Request.Form["new-full-name"];
        string inputHomeAddress = Request.Form["new-home-address"];
        string inputNumber = Request.Form["new-phone-number"];

        Address inputAddress = new Address(inputName, inputHomeAddress, inputNumber);
        inputAddress.AddToAddressBook();

        return View["address_added.cshtml", inputAddress];
      };

      Get["/address_book"] = _ => {
        return View["address_book.cshtml", Address.ViewAddressBook()];
      };

      Post["/cleared_book"] = _ => {
        Address.ClearAddressBook();
        return View["/cleared_book.cshtml"];
      };

      Get["/selected_address"] = _ => {
        string selectFullName = Request.Query["myname"];

        return View["selected_address.cshtml",Address.ViewSelectedAddress(selectFullName)];
      };

    }
  }
}
