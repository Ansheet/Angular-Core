using System;
using System.Collections.Generic;
using System.Text;

namespace WebCore
{
    public interface GenericIRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int ID);
        void Save();
        void Delete(object ID);
        void Update(T Entity);
        void Create(T Entity);
    }
}
