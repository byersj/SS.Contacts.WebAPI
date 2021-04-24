using LiteDB;

namespace SS.Contacts.WebAPI.Interfaces
{
    public interface IDbContext
    {
        LiteDatabase Database { get; }
    }
}