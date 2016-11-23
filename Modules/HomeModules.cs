using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/add_address"] = _ => {
        return View["add_address.cshtml"];
      };

    }
  }
}
