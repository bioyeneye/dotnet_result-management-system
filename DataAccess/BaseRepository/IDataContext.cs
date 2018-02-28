using System;

namespace DataAccess.BaseRepository
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();

    }
}