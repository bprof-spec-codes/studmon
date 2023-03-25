

using studmonBackend.Data.Models;

namespace studmonBackend.Logic.Interfaces
{
    public interface ITanarLogic
    {
        void Create(Tanar item);

        IEnumerable<Tanar> ReadAll();

        Tanar Readone(string id);

        void Update(Tanar item);

        void Delete(string id);
    }
}
