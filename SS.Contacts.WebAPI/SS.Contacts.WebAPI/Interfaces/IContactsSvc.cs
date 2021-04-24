using SS.Contacts.WebAPI.POCOs;
using System.Collections.Generic;

namespace SS.Contacts.WebAPI.Interfaces
{
    public interface IContactsSvc
    {
        bool Delete(int id);

        IEnumerable<HomeList> GetCallList();

        Contact Insert(Contact contact);

        Contact Select(int id);

        IEnumerable<Contact> SelectAll();

        Contact Update(int id, Contact contact);
    }
}