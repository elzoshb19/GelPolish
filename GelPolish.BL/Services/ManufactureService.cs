using GelPolishStore.BL.Interfaces;
using GelPolishStore.DL.Interfaces;
using GelPolishStore.Models.Models;

namespace GelPolishStore.BL.Services
{
    public class ManufactureService : IManufactureService
    {
        private readonly IManufactureRepository _manufactureRepository;

        public ManufactureService(IManufactureRepository manufactureRepository)
        {
            _manufactureRepository = manufactureRepository;
        }
        public List<Manufacture> GetAll()
        {
            return _manufactureRepository.GetAll();
        }

        public Manufacture? GetById(int id)
        {
            if (id <= 0) return null;

            return _manufactureRepository.GetById(id);
        }

        public void Add(Manufacture manufacture)
        {
            _manufactureRepository.Add(manufacture);
        }

        public void Delete(int id)
        {
            _manufactureRepository.Delete(id);
        }
    }
}