using Microsoft.EntityFrameworkCore;
using SMS.core.Models;
using SMS.data.SMS_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository
{
    public abstract  class Repository<T> : IRepository<T> where T : BaseEntiry
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }
        public DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }

        public async Task Add(T entity)
        {
           await Table.AddAsync(entity);
           await _db.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            await Task.Run(() => { 
                Table.Remove(entity);
                _db.SaveChangesAsync();

            });
        }

        public async Task DeleteById(int id)
        {
            T entity = await Table.FindAsync(id);
            await Task.Run(() =>
            {
                Table.Remove(entity);
                 _db.SaveChangesAsync();
            });
            
        }

        public async Task< IEnumerable<T>> GetAll()
        {
            return await Table.ToListAsync();
        }

        public async Task< T> GetById(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task UpdateById(T entity)
        {
            await Task.Run(() =>
            {
                Table.Update(entity);
                _db.SaveChanges();

            });
        }
    }
}
