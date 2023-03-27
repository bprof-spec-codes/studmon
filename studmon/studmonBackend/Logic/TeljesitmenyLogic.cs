using studmonBackend.Data.Models;
using studmonBackend.Data.Repositories;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Logic
{
    public class TeljesitmenyLogic : ITeljesitmenyLogic
    {
        IRepository<Teljesitmeny> repo;

        public TeljesitmenyLogic(IRepository<Teljesitmeny> repo)
        {
            this.repo = repo;
        }

        public void Create(Teljesitmeny item)
        {
            repo.Create(item);
        }

        public void Delete(string id)
        {
            repo.DeleteById(id);
        }

        public IEnumerable<Teljesitmeny> ReadAll()
        {
            return repo.ReadAll();
        }

        public Teljesitmeny Readone(string id)
        {
            return repo.ReadOne(id);
        }

        public void Update(Teljesitmeny item)
        {
            repo.Update(item);
        }
    }
}
