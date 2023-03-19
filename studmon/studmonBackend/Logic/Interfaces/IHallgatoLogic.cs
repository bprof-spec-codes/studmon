using studmon.Models;

namespace studmonBackend.Logic.Interfaces
{
    public interface IHallgatoLogic
    {
        void Create(Hallgato item);

        IEnumerable<Hallgato> ReadAll();

        Hallgato Readone(string id);

        void Update(Hallgato item);

        void Delete(string id);

    }
}
