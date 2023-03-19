using studmon.Models;
using studmonBackend.Data.Repositories;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Logic
{
    public class OraLogic : IOraLogic
    {
        IRepository<Ora> repo;

        public OraLogic(IRepository<Ora> repo)
        {
            this.repo = repo;
        }

        public void Create(Ora item)
        {
            repo.Create(item);
        }

        public void Delete(string id)
        {
            repo.DeleteById(id);
        }

        public IEnumerable<Ora> ReadAll()
        {
            return repo.ReadAll();
        }

        public Ora Readone(string id)
        {
            return repo.ReadOne(id);
        }

        public void Update(Ora item)
        {
            repo.Update(item);
        }
    }

}
