using studmon.Models;
using studmonBackend.Data.DBContext;

namespace studmonBackend.Data.Repositories
{
    public class OraRepository : BaseRepository<Ora>, IRepository<Ora>
    {
        public OraRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override Ora ReadOne(string id)
        {
            return db.Set<Ora>().FirstOrDefault(t => t.Id == id);
        }

        public override void Update(Ora item)
        {
            var old = ReadOne(item.Id);
            old.terem = item.terem;
            old.nev = item.nev;
            old.ulesRend = item.ulesRend;
            old.leiras = item.leiras;
            old.oraKezdet = item.oraKezdet;
            old.oraVeg = item.oraVeg;
            old.alkalmakSzama = item.alkalmakSzama;
            old.hallgatokColl = item.hallgatokColl;
            db.SaveChanges();
        }
    }
}
