using studmon.Models;

namespace studmonBackend.Logic.Interfaces
{
    public interface ITeljesitmenyLogic
    {
        void Create(Teljesitmeny item);

        IEnumerable<Teljesitmeny> ReadAll();

        Teljesitmeny Readone(string id);

        void Update(Teljesitmeny item);

        void Delete(string id);
    }
}
