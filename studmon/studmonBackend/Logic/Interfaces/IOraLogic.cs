using studmon.Models;

namespace studmonBackend.Logic.Interfaces
{
    public interface IOraLogic
    {
        void Create(Ora item);

        IEnumerable<Ora> ReadAll();

        Ora Readone(string id);

        void Update(Ora item);

        void Delete(string id);
    }
}
