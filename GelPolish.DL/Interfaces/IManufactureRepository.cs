using GelPolishStore.Models.Models;

namespace GelPolishStore.DL.Interfaces
{
    public interface IManufactureRepository
    {
        List<Manufacture> GetAll();

        Manufacture? GetById(int id);

        void Add(Manufacture manufacture);

        void Delete(int id);
        void Add(GelPolishStore.Models.Models.Manufacture manufacture);
        void Add(GelPolishStore.Models.Models.Manufacture manufacture);
    }
}
