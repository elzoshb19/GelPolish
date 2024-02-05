using GelPolishStore.DL.Interfaces;
using GelPolishStore.DL.MemoryDB;
using GelPolishStore.Models.Models;

namespace GelPolishStore.DL.Repositories
{
    public class ManufactureRepository : IManufactureRepository
    {
        public List<Manufacture> GetAll()
        {
            return InMemoryDB.ManufactureData;
        }

        public Manufacture? GetById(int id)
        {
            return InMemoryDB.ManufactureData.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Manufacture manufacture)
        {
            InMemoryDB.ManufactureData.Add(manufacture);
        }

        public void Delete(int id)
        {
            var manufacture = GetById(id);

            if (manufacture != null)
            {
                InMemoryDB.ManufactureData.Remove(manufacture);
            }
        }
    }
}