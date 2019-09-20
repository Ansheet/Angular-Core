using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebData;

namespace WebCore
{
    public class GenericRepository<T> : GenericIRepository<T> where T : class
    {
        public readonly EmployeeDB _employeeDB;
        private DbSet<T> _context;
        public GenericRepository(EmployeeDB EmployeeDB)
        {
            _employeeDB = EmployeeDB;
            _context = _employeeDB.Set<T>();
        }

        public void Create(T Entity)
        {
            _employeeDB.Entry(Entity).State = EntityState.Added;
        }

        public void Delete(object ID)
        {
            T existing = _context.Find(ID);
            _context.Remove(existing);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.ToList();
        }

        public T GetByID(int ID)
        {
            return _context.Find(ID);
        }

        public void Save()
        {
            _employeeDB.SaveChanges();
        }

        public void Update(T Entity)
        {
            _employeeDB.Entry(Entity).State = EntityState.Modified;
        }
    }
}
