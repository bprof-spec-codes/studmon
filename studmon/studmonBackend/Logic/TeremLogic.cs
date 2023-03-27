using studmonBackend.Data.Models;
using studmonBackend.Data.Repositories;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Logic
{
    public class TeremLogic :  ITeremLogic
    {
        IRepository<Terem> repo;

    public TeremLogic(IRepository<Terem> repo)
    {
        this.repo = repo;
    }

    public void Create(Terem item)
    {
        repo.Create(item);
    }

    public void Delete(string id)
    {
        repo.DeleteById(id);
    }

    public IEnumerable<Terem> ReadAll()
    {
        return repo.ReadAll();
    }

    public Terem Readone(string id)
    {
        return repo.ReadOne(id);
    }

    public void Update(Terem item)
    {
        repo.Update(item);
    }
}
    
}
