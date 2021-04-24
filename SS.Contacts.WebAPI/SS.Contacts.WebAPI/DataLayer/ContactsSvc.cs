using LiteDB;
using SS.Contacts.WebAPI.Interfaces;
using SS.Contacts.WebAPI.POCOs;
using System.Collections.Generic;
using System.Linq;

namespace SS.Contacts.WebAPI.DataLayer
{
    public class ContactsSvc : IContactsSvc
    {
        #region Variables

        private LiteDatabase _liteDb;

        #endregion

        #region Constructors

        public ContactsSvc(IDbContext liteDbContext)
        {
            _liteDb = liteDbContext.Database;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Selects all contacts.
        /// </summary>
        /// <returns>List of Contacts</returns>

        public IEnumerable<Contact> SelectAll()
        {
            return _liteDb.GetCollection<Contact>("Contacts").FindAll();
        }

        /// <summary>
        /// Selects a single contact based on Id.
        /// </summary>
        /// <param name="id">Id of contact</param>
        /// <returns>A single contact</returns>
        public Contact Select(int id)
        {
            return _liteDb.GetCollection<Contact>("Contacts").Find(x => x.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Inserts a new contact.
        /// </summary>
        /// <param name="contact">a contact object.</param>
        /// <returns>The new contact with Id</returns>
        public Contact Insert(Contact contact)
        {
            var col = _liteDb.GetCollection<Contact>("Contacts");
            var id = col.Insert(contact);
            return col.FindById(id);
        }

        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="contact">The contact.</param>
        /// <returns>The contact</returns>
        public Contact Update(int id, Contact contact)
        {
            if (Select(id) == default || contact.Id == 0)
            {
                return Insert(contact);
            }
            if (_liteDb.GetCollection<Contact>("Contacts").Update(contact))
                return Select(id);
            else
                throw new System.Exception("Update Failed");
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return _liteDb.GetCollection<Contact>("Contacts").Delete(id);
        }

        /// <summary>
        /// Gets the call list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HomeList> GetCallList()
        {
            List<HomeList> hList = new List<HomeList>();
            var col = _liteDb.GetCollection<Contact>("Contacts")
                .Find(x => x.Phone.Where(w => w.Type.Equals("home", System.StringComparison.CurrentCultureIgnoreCase)).Any())
                .ToList();

            //Should use mapper
            foreach (Contact contact in col)
            {
                hList.Add(new HomeList(contact.Id, contact.Name, contact.Phone.Where(w => w.Type.Equals("home", System.StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().Number));
            }
            return hList;
        }

        #endregion
    }
}