using System;
using System.Collections.Generic;

namespace ResipositoryLibrary
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T item);
        T GetEntity(int id);
        IEnumerable<T> GetEntitysList();
        void Delete(T item);
        void Edit(T item);
    }
}
