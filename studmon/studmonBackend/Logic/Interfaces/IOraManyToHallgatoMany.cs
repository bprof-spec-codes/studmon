using studmonBackend.Data.Models.ManyToManyModels;

namespace studmonBackend.Logic.Interfaces
{
    public interface IOraManyToHallgatoMany
    {
        void Create(OraManyToHallgatoMany item);

        IEnumerable<OraManyToHallgatoMany> ReadAll();

        OraManyToHallgatoMany ReadOne(string id);

        void Update(OraManyToHallgatoMany item);

        void Delete(string id);
    }
}
