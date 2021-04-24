using LiteDB;
using System.Collections.Generic;

namespace SS.Contacts.WebAPI.POCOs
{
    public class Contact
    {
        #region Constructors

        public Contact()
        {
            Name = new Contact_Name();
            Address = new Contact_Address();
            Phone = new List<Contact_Phone>();
        }

        [BsonCtor]
        public Contact(int id,
            Contact_Name name,
            Contact_Address address,
            List<Contact_Phone> phones,
            string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phones;
            Email = email;
        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public Contact_Name Name { get; set; }
        public Contact_Address Address { get; set; }
        public List<Contact_Phone> Phone { get; set; }
        public string Email { get; set; }

        #endregion
    }
}