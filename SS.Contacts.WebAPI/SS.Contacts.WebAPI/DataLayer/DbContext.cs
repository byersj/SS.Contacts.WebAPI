using LiteDB;
using SS.Contacts.WebAPI.Interfaces;

namespace SS.Contacts.WebAPI.DataLayer
{
    public class DbContext : IDbContext
    {
        #region Variables

        public LiteDatabase Database { get; }

        #endregion

        #region Constructors

        public DbContext()
        {
            Database = new LiteDatabase(@"c:\temp\LiteDbContacts.db");
        }

        #endregion
    }
}