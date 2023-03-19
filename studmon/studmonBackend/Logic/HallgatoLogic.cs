using studmon.Models;
using studmonBackend.Data.Repositories;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Logic
{
    public class HallgatoLogic : IHallgatoLogic
    {
        IRepository<Hallgato> repo;

        public HallgatoLogic(IRepository<Hallgato> repo)
        {
            this.repo = repo;
        }

        public void Create(Hallgato item)
        {
            repo.Create(item);
        }

        public void Delete(string id)
        {
            repo.DeleteById(id);
        }

        public IEnumerable<Hallgato> ReadAll()
        {
           return repo.ReadAll();
        }

        public Hallgato Readone(string id)
        {
            return repo.ReadOne(id);
        }

        public void Update(Hallgato item)
        {
            repo.Update(item);    
        }
    }
}
