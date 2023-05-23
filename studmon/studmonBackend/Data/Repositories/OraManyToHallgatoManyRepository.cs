using studmonBackend.Data.DBContext;
using studmonBackend.Data.Models.ManyToManyModels;

namespace studmonBackend.Data.Repositories
{
    public class OraManyToHallgatoManyRepository : BaseRepository<OraManyToHallgatoMany>, IRepository<OraManyToHallgatoMany>
    {
        //----------------------------------------------------------------------------------------
        //Ezeknek itt nincs igazán funkciója, de azért megírtam -> a ReadOne kell a DeleteById-hoz
        //----------------------------------------------------------------------------------------

        public OraManyToHallgatoManyRepository(ApplicationDBContext db) : base(db)
        {
        }

        public override OraManyToHallgatoMany ReadOne(string id)
        {
            return db.Set<OraManyToHallgatoMany>().FirstOrDefault(t => t.ID == int.Parse(id));
        }

        public override void Update(OraManyToHallgatoMany item)
        {
            var old = ReadOne(item.ID.ToString());
            old.OraId = item.OraId;
            old.HallgatoId = item.HallgatoId;
            db.SaveChanges();
        }
    }
}
