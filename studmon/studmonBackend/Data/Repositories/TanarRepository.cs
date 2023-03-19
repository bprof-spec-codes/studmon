using studmon.Models;

namespace studmonBackend.Data.Repositories
{
    public class TanarRepository : BaseRepository<Tanar>, IRepository<Tanar>
    {
        public TanarRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override Tanar ReadOne(string id)
        {
           return db.Set<Tanar>().FirstOrDefault(t => t.neptunKod == id); 
        }

        public override void Update(Tanar item)
        {
            var old = ReadOne(item.neptunKod);
            old.nev = item.nev;
            old.orakColl = item.orakColl;
        }
    }
}
