using studmonBackend.Data.Models.ManyToManyModels;
using studmonBackend.Data.Repositories;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Logic
{
    public class OraManyToHallgatoManyLogic : IOraManyToHallgatoMany
    {

        IRepository<OraManyToHallgatoMany> repo;

        public OraManyToHallgatoManyLogic(IRepository<OraManyToHallgatoMany> repo)
        {
            this.repo = repo;
        }

        public void Create(OraManyToHallgatoMany item)
        {
            repo.Create(item);
        }

        public void Delete(string id)
        {
            repo.DeleteById(id);
        }

        public IEnumerable<OraManyToHallgatoMany> ReadAll()
        {
            return repo.ReadAll();
        }

        public OraManyToHallgatoMany ReadOne(string id)
        {
            return repo.ReadOne(id);
        }

        public void Update(OraManyToHallgatoMany item)
        {
            repo.Update(item);
        }
    }
}
