using Microsoft.EntityFrameworkCore.Query;

using studmonBackend.Data.DBContext;
using studmonBackend.Data.Models;

namespace studmonBackend.Data.Repositories
{
    public class TeremRepository : BaseRepository<Terem>, IRepository<Terem>
    {
        public TeremRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override Terem ReadOne(string id)
        {
            return db.Set<Terem>().FirstOrDefault(t => t.nev == id);
        }

        public override void Update(Terem item)
        {
            var old = ReadOne(item.nev);
            old.elrendezes = item.elrendezes;
            db.SaveChanges();
        }
    }
}
