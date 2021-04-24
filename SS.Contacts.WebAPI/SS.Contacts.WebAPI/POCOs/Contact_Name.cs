using LiteDB;

namespace SS.Contacts.WebAPI.POCOs
{
    public class Contact_Name
    {
        #region Constructors

        public Contact_Name()
        {
        }

        [BsonCtor]
        public Contact_Name(string first,
            string middle,
            string last)
        {
            First = first;
            Middle = middle;
            Last = last;
        }

        #endregion

        #region Properties

        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }

        #endregion
    }
}