using LiteDB;

namespace SS.Contacts.WebAPI.POCOs
{
    public class HomeList
    {
        #region Constructors

        public HomeList()
        {
            Name = new Contact_Name();
        }

        [BsonCtor]
        public HomeList(int id,
            Contact_Name name,
            string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public Contact_Name Name { get; set; }
        public string Phone { get; set; }

        #endregion
    }
}