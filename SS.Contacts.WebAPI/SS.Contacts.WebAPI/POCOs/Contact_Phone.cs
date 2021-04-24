using LiteDB;

namespace SS.Contacts.WebAPI.POCOs
{
    public class Contact_Phone
    {
        #region Constructors

        public Contact_Phone()
        {
        }

        [BsonCtor]
        public Contact_Phone(string number,
            string type)
        {
            Number = number;
            Type = type;
        }

        #endregion

        #region Properties

        public string Number { get; set; }
        public string Type { get; set; }

        #endregion
    }
}