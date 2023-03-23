using studmon.Models;
using studmonBackend.Data.DBContext;

namespace studmonBackend.Data.Repositories
{
    public class TeljesitmenyRepository : BaseRepository<Teljesitmeny>, IRepository<Teljesitmeny>
    {
        public TeljesitmenyRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override Teljesitmeny ReadOne(string id)
        {
            return db.Set<Teljesitmeny>().FirstOrDefault(t => t.Id == id);
        }

        public override void Update(Teljesitmeny item)
        {
            var old = ReadOne(item.Id);
            old.ertekelesek = item.ertekelesek;
            
        }
    }
}

