
using studmonBackend.Data.DBContext;
using studmonBackend.Data.Models;

namespace studmonBackend.Data.Repositories
{
    public class TeljesitmenyRepository : BaseRepository<Teljesitmeny>, IRepository<Teljesitmeny>
    {
        public TeljesitmenyRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override Teljesitmeny ReadOne(string id)
        {
            return db.Set<Teljesitmeny>().FirstOrDefault(t => t.teljesitmenyID == id);
        }

        public override void Update(Teljesitmeny item)
        {
            var old = ReadOne(item.teljesitmenyID);
            old.ertekelesek = item.ertekelesek;
            old.hallgatoNeptunKod = item.hallgatoNeptunKod;
            db.SaveChanges();
        }
    }
}

