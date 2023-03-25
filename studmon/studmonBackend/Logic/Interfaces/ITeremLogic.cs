

using studmonBackend.Data.Models;

namespace studmonBackend.Logic.Interfaces
{
    public interface ITeremLogic
    {
        void Create(Terem item);

        IEnumerable<Terem> ReadAll();

        Terem Readone(string id);

        void Update(Terem item);

        void Delete(string id);
    }
}
