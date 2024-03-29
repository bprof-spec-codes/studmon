﻿
using studmonBackend.Data.DBContext;

namespace studmonBackend.Data.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        public ApplicationDBContext db;

        public BaseRepository(ApplicationDBContext db)
        {
            this.db = db;
        }

        public void Create(T item)
        {
            try
            {
                db.Set<T>().Add(item);
                db.SaveChanges();
            }
            catch(Exception) { }
        }

        public void DeleteById(string id)
        {
            db.Set<T>().Remove(ReadOne(id));
            db.SaveChanges();
        }

        public IQueryable<T> ReadAll()
        {
            return db.Set<T>();
        }

        public abstract T ReadOne(string id);


        public abstract void Update(T item);
        
    }
}
