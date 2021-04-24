using LiteDB;

namespace SS.Contacts.WebAPI.POCOs
{
    public class Contact_Address
    {
        #region Constructors

        public Contact_Address()
        {
        }

        [BsonCtor]
        public Contact_Address(string street,
            string city,
            string state,
            string zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        #endregion

        #region Properties

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        #endregion
    }
}