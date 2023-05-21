
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
            return db.Set<Teljesitmeny>().FirstOrDefault(t => t.teljesitmenyID == int.Parse(id));
        }

        public override void Update(Teljesitmeny item)
        {
            var old = ReadOne(item.teljesitmenyID.ToString());
            old.ertekeles = item.ertekeles;
            old.hallgatoNeptunKod = item.hallgatoNeptunKod;
            db.SaveChanges();
        }
    }
}

