using studmonBackend.Data.Models;
using studmonBackend.Data.Repositories;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Logic
{
    public class TanarLogic : ITanarLogic
    {
        IRepository<Tanar> repo;

        public TanarLogic(IRepository<Tanar> repo)
        {
            this.repo = repo;
        }

        public void Create(Tanar item)
        {
            repo.Create(item);
        }

        public void Delete(string id)
        {
            repo.DeleteById(id);
        }

        public IEnumerable<Tanar> ReadAll()
        {
            return repo.ReadAll();
        }

        public Tanar Readone(string id)
        {
            return repo.ReadOne(id);
        }

        public void Update(Tanar item)
        {
            repo.Update(item);
        }
    }

}
