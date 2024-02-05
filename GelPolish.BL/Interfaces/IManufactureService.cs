using GelPolishStore.Models.Models;

namespace GelPolishStore.BL.Interfaces
{
    public interface IManufactureService
    {
        List<Manufacture> GetAll();

        Manufacture? GetById(int id);

        void Add(Manufacture manufacture);

        void Delete(int id);
    }
}
