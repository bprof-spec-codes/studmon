
using studmonBackend.Data.DBContext;
using studmonBackend.Data.Models;

namespace studmonBackend.Data.Repositories
{
    public class HallgatoRepository : BaseRepository<Hallgato>, IRepository<Hallgato>
    {
        public HallgatoRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override Hallgato ReadOne(string id)
        {
            return db.Set<Hallgato>().FirstOrDefault(t => t.neptunKod == id);
        }

        public override void Update(Hallgato item)
        {
            var old = ReadOne(item.neptunKod);
            old.kar = item.kar;
            old.kepzesNev = item.kepzesNev;
            old.nev = item.nev;
            old.teljesitmeny = item.teljesitmeny;
            db.SaveChanges();
        }
    }
}
