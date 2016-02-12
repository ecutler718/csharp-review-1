using Nancy;
using Contacts.Objects;
using System;
using System.Collections.Generic;


namespace ContactsInfo
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/addContact"] = _ => {
        return View["createContact.cshtml"];
      };
      Get["/contactList"] = _ => {
        var allContact = Contact.GetAll();
        return View["viewContact.cshtml", allContact];
      };
      Post["/contact_created"] = _ => {
        Contact newContact = new Contact(Request.Form["Name"], Request.Form["PhoneNumber"], Request.Form["Address"]);
        List<Contact> getContact = Contact.GetAll();
        return View["newContact.cshtml",newContact];
      };
      Post["/contacts_deleted"] = _ => {
        Contact.DeleteAll();
        return View["eraseContact.cshtml"];
      };
      Get["/contactList/{id}"] = parameters => {
        Contact contact = Contact.find(parameters.id);
        return View["/.cshtml", contact];
      };
    }
  }
}
