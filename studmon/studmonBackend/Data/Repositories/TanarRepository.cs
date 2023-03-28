
using studmonBackend.Data.DBContext;
using studmonBackend.Data.Models;

namespace studmonBackend.Data.Repositories
{
    public class TanarRepository : BaseRepository<Tanar>, IRepository<Tanar>
    {
        public TanarRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override Tanar ReadOne(string id)
        {
           return db.Set<Tanar>().FirstOrDefault(t => t.Id == id); 
        }

        public override void Update(Tanar item)
        {
            var old = ReadOne(item.Id);
            old.nev = item.nev;
            old.Email = item.Email;
            db.SaveChanges();
        }
    }
}
